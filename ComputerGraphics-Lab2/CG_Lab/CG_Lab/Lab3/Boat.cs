using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab3_SailboatSeagull
{
    public partial class Boat : Form
    {
        // ─── Глобальные переменные ─────────────────────────────────────────────
        private System.Windows.Forms.Timer animTimer = new System.Windows.Forms.Timer();
        private bool isRunning = false;
        private int tickCount = 0;

        // Лодка
        private float boatX = 100f;
        private float boatY = 0f;
        private float boatScale = 1.0f;
        private int boatDir = 1;

        // Чайка
        private float seagullX = 600f;
        private float seagullY = 80f;
        private float seagullScale = 1.0f;
        private float seagullDirX = -1.2f;
        private float seagullDirY = 0.6f;

        // Солнце
        private float sunY = 60f;

        // ─── Матрицы тела в локальных координатах ─────────────────────────────

        // Корпус лодки — трапеция
        private float[,] hullLocal = {
            { -80,   0, 1 },
            {  80,   0, 1 },
            {  60,  22, 1 },
            { -60,  22, 1 }
        };

        // Мачта
        private float[,] mastLocal = {
            {  0, -85, 1 },
            {  0,   0, 1 }
        };

        // Парус — треугольник
        private float[,] sailLocal = {
            {  0, -85, 1 },
            {  0,   0, 1 },
            { 50,   0, 1 }
        };

        // Чайка: 0=центр, 1=лев.кончик, 2=прав.кончик, 3=хвост лев, 4=хвост прав
        private float[,] seagullLocal = {
            {   0,  0, 1 },
            { -32,  0, 1 },
            {  32,  0, 1 },
            { -10, 12, 1 },
            {  10, 12, 1 }
        };

        // ─── Конструктор ──────────────────────────────────────────────────────
        public Boat()
        {
            InitializeComponent();

            this.Text = "Парусная лодка и чайка (ЛР3)";
            this.Size = new Size(840, 530);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            pictureBox1.Size = new Size(820, 430);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.BackColor = Color.White;
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);

            btnStart.Text = "Старт";
            btnStart.Size = new Size(100, 35);
            btnStart.Location = new Point(10, 440);
            btnStart.Click += new EventHandler(btnStart_Click);

            btnReset.Text = "Сброс";
            btnReset.Size = new Size(100, 35);
            btnReset.Location = new Point(120, 440);
            btnReset.Click += new EventHandler(btnReset_Click);

            lblInfo.Text = "Аффинные преобразования: масштабирование и смещение";
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(240, 448);

            animTimer.Interval = 40;
            animTimer.Tick += new EventHandler(animTimer_Tick);
        }

        // ─── Таймер ───────────────────────────────────────────────────────────
        private void animTimer_Tick(object sender, EventArgs e)
        {
            tickCount++;

            // Лодка: смещение по X + покачивание по Y
            boatX += 1.5f * boatDir;
            boatY = (float)(Math.Sin(tickCount * 0.07) * 5.0);

            if (boatX > 720) { boatDir = -1; boatScale = 0.8f; }
            if (boatX < 80) { boatDir = 1; boatScale = 1.0f; }

            // Чайка: смещение
            seagullX += seagullDirX;
            seagullY += seagullDirY * 0.5f;
            if (seagullX < 60 || seagullX > 740) seagullDirX *= -1;
            if (seagullY < 30 || seagullY > 180) seagullDirY *= -1;

            // Масштаб чайки
            seagullScale = 0.85f + 0.3f * (float)(Math.Sin(tickCount * 0.025));

            // Солнце опускается
            if (sunY < 260) sunY += 0.15f;

            pictureBox1.Invalidate();
        }

        // ─── Аффинные преобразования ──────────────────────────────────────────

        private float[,] ScaleMatrix(float sx, float sy)
        {
            return new float[,] {
                { sx,  0, 0 },
                {  0, sy, 0 },
                {  0,  0, 1 }
            };
        }

        private float[,] TranslateMatrix(float tx, float ty)
        {
            return new float[,] {
                { 1,  0, 0 },
                { 0,  1, 0 },
                { tx, ty, 1 }
            };
        }

        // Умножение матрицы вершин (N×3) на матрицу преобразования (3×3)
        private float[,] MultiplyMatr(float[,] body, float[,] matr)
        {
            int n = body.GetLength(0);
            float[,] result = new float[n, 3];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                        result[i, j] += body[i, k] * matr[k, j];
                }
            return result;
        }

        // Перемножение двух матриц преобразования 3×3
        private float[,] CombineMatr(float[,] a, float[,] b)
        {
            float[,] r = new float[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    r[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                        r[i, j] += a[i, k] * b[k, j];
                }
            return r;
        }

        // ─── Рисование ────────────────────────────────────────────────────────
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 1.5f);

            int W = pictureBox1.Width;
            int horizon = pictureBox1.Height - 130;

            // Горизонт (линия воды)
            g.DrawLine(pen, 0, horizon, W, horizon);

            // Солнце — только контур окружности
            pen.Width = 1.5f;
            g.DrawEllipse(pen, 400 - 38, sunY - 38, 76, 76);

            // Лодка
            DrawBoat(g, pen, horizon);

            // Чайка
            DrawSeagull(g, pen);

            pen.Dispose();
        }

        private void DrawBoat(Graphics g, Pen pen, int horizon)
        {
            float anchorY = horizon + boatY;

            // Составное преобразование: масштаб × смещение
            float[,] scaleM = ScaleMatrix(boatScale * boatDir, boatScale);
            float[,] transM = TranslateMatrix(boatX, anchorY);
            float[,] cm = CombineMatr(scaleM, transM);

            // Корпус — трапеция, только контур
            float[,] hull = MultiplyMatr(hullLocal, cm);
            pen.Width = 2f;
            PointF[] hullPts = {
                new PointF(hull[0,0], hull[0,1]),
                new PointF(hull[1,0], hull[1,1]),
                new PointF(hull[2,0], hull[2,1]),
                new PointF(hull[3,0], hull[3,1])
            };
            g.DrawPolygon(pen, hullPts);

            // Мачта
            float[,] mast = MultiplyMatr(mastLocal, cm);
            pen.Width = 2f;
            g.DrawLine(pen, mast[0, 0], mast[0, 1], mast[1, 0], mast[1, 1]);

            // Парус — треугольник, только контур
            float[,] sail = MultiplyMatr(sailLocal, cm);
            pen.Width = 1.5f;
            PointF[] sailPts = {
                new PointF(sail[0,0], sail[0,1]),
                new PointF(sail[1,0], sail[1,1]),
                new PointF(sail[2,0], sail[2,1])
            };
            g.DrawPolygon(pen, sailPts);
        }

        private void DrawSeagull(Graphics g, Pen pen)
        {
            // Взмах крыльев — изменяем Y кончиков крыльев (прямые линии!)
            float wing = (float)(Math.Sin(tickCount * 0.22) * 14.0);
            float[,] sgLocal = (float[,])seagullLocal.Clone();
            sgLocal[1, 1] = wing;   // лев кончик
            sgLocal[2, 1] = wing;   // прав кончик

            // Масштаб + смещение
            float[,] sm = ScaleMatrix(seagullScale, seagullScale);
            float[,] tm = TranslateMatrix(seagullX, seagullY);
            float[,] cm = CombineMatr(sm, tm);

            float[,] sg = MultiplyMatr(sgLocal, cm);

            pen.Width = 1.5f;

            // Крылья: лев.кончик → центр → прав.кончик (две прямые)
            g.DrawLine(pen, sg[1, 0], sg[1, 1], sg[0, 0], sg[0, 1]);
            g.DrawLine(pen, sg[0, 0], sg[0, 1], sg[2, 0], sg[2, 1]);

            // Хвост: центр → хвост лев, центр → хвост прав
            g.DrawLine(pen, sg[0, 0], sg[0, 1], sg[3, 0], sg[3, 1]);
            g.DrawLine(pen, sg[0, 0], sg[0, 1], sg[4, 0], sg[4, 1]);
        }

        // ─── Кнопки ───────────────────────────────────────────────────────────
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                animTimer.Start();
                isRunning = true;
                btnStart.Text = "Стоп";
            }
            else
            {
                animTimer.Stop();
                isRunning = false;
                btnStart.Text = "Старт";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            animTimer.Stop();
            isRunning = false;
            btnStart.Text = "Старт";

            tickCount = 0;
            boatX = 100f; boatY = 0f; boatScale = 1.0f; boatDir = 1;
            seagullX = 600f; seagullY = 80f; seagullScale = 1.0f;
            seagullDirX = -1.2f; seagullDirY = 0.6f;
            sunY = 60f;

            pictureBox1.Invalidate();
        }
    }
}