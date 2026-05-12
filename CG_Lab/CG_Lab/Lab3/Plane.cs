using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PaperPlane
{
    public partial class Plane : Form
    {
        private System.Windows.Forms.Timer timer1;

        private bool isRunning = false;

        // Положение самолётика (нос самолета)
        private float planeX = 85;
        private float planeY;

        // Масштаб самолётика
        private float planeScale = 0.5f;

        public Plane()
        {
            InitializeComponent();

            StartButton.Click += StartButton_Click;
            ResetButton.Click += ResetButton_Click;
            panelScene.Paint += PanelScene_Paint;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 30;
            timer1.Tick += Timer1_Tick;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                timer1.Start();
                StartButton.Text = "Стоп";
            }
            else
            {
                timer1.Stop();
                StartButton.Text = "Старт";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            planeY = panelScene.Height - 280;
            planeX = 85;
            planeScale = 0.5f;
            panelScene.Invalidate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Движение: смещение вправо
            planeX = planeX + 2.0f;

            // Движение: плавное смещение вниз (положительное значение = вниз)
            planeY = planeY + 0.7f;

            // Плавное увеличение масштаба (приближение)
            planeScale = planeScale + 0.008f;

            // Проверка выхода за границы
            if (planeX > panelScene.Width + 150 || planeY > panelScene.Height + 150 || planeScale > 2.5f)
            {
                // Ручной сброс координат
                planeY = panelScene.Height - 280;
                planeX = 85;
                planeScale = 0.5f;
            }

            panelScene.Invalidate();
        }

        private void PanelScene_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = panelScene.Width;
            int h = panelScene.Height;

            if (planeY == 0)
                planeY = h - 280;

            DrawCastle(g, h);
            DrawPlane(g, planeX, planeY, planeScale);
        }

        private void DrawCastle(Graphics g, int h)
        {
            int groundY = h - 100;

            // Основное здание
            Rectangle castleBody = new Rectangle(40, groundY - 180, 140, 180);
            g.FillRectangle(Brushes.Gray, castleBody);
            g.DrawRectangle(Pens.Black, castleBody);

            // Правая башня
            int towerRightX = 150;
            Rectangle towerRight = new Rectangle(towerRightX, groundY - 230, 50, 230);
            g.FillRectangle(Brushes.DimGray, towerRight);
            g.DrawRectangle(Pens.Black, towerRight);

            Point[] roofRight =
            {
                new Point(towerRightX, groundY - 230),
                new Point(towerRightX + 25, groundY - 270),
                new Point(towerRightX + 50, groundY - 230)
            };
            g.FillPolygon(Brushes.DarkRed, roofRight);
            g.DrawPolygon(Pens.Black, roofRight);

            // Левая башня (главная, из которой вылетает самолётик)
            int towerLeftX = 20;
            Rectangle towerLeft = new Rectangle(towerLeftX, groundY - 230, 50, 230);
            g.FillRectangle(Brushes.DimGray, towerLeft);
            g.DrawRectangle(Pens.Black, towerLeft);

            // Окно в левой башне
            int windowWidth = 24;
            int windowHeight = 28;
            int windowX = towerLeftX + (50 - windowWidth) / 2;
            int windowY = groundY - 230 + 40;
            Rectangle window = new Rectangle(windowX, windowY, windowWidth, windowHeight);
            g.FillRectangle(Brushes.LightBlue, window);
            g.DrawRectangle(Pens.Black, window);

            // Крестовина окна
            g.DrawLine(Pens.Black, windowX, windowY + windowHeight / 2, windowX + windowWidth, windowY + windowHeight / 2);
            g.DrawLine(Pens.Black, windowX + windowWidth / 2, windowY, windowX + windowWidth / 2, windowY + windowHeight);

            // Крыша левой башни
            Point[] roofLeft =
            {
                new Point(towerLeftX, groundY - 230),
                new Point(towerLeftX + 25, groundY - 270),
                new Point(towerLeftX + 50, groundY - 230)
            };
            g.FillPolygon(Brushes.DarkRed, roofLeft);
            g.DrawPolygon(Pens.Black, roofLeft);
        }

        private void DrawPlane(Graphics g, float x, float y, float scale)
        {
            // ========================================
            // ШАГ 1: Задаём локальные координаты точек
            // ========================================

            // Точка A: нос самолётика
            float localAX = 0;
            float localAY = 0;

            // Точка B: верхняя часть хвоста
            float localBX = -50;
            float localBY = -18;

            // Точка C: середина
            float localCX = -35;
            float localCY = 0;

            // Точка D: нижняя часть хвоста
            float localDX = -50;
            float localDY = 18;

            // ========================================
            // ШАГ 2: Масштабирование
            // Умножаем каждую локальную координату на scale
            // ========================================

            // Точка A после масштабирования
            float scaledAX = localAX * scale;
            float scaledAY = localAY * scale;

            // Точка B после масштабирования
            float scaledBX = localBX * scale;
            float scaledBY = localBY * scale;

            // Точка C после масштабирования
            float scaledCX = localCX * scale;
            float scaledCY = localCY * scale;

            // Точка D после масштабирования
            float scaledDX = localDX * scale;
            float scaledDY = localDY * scale;

            // ========================================
            // ШАГ 3: Перемещение в мировые координаты
            // ========================================

            // Точка A в мире
            float worldAX = scaledAX + x;
            float worldAY = scaledAY + y;

            // Точка B в мире
            float worldBX = scaledBX + x;
            float worldBY = scaledBY + y;

            // Точка C в мире
            float worldCX = scaledCX + x;
            float worldCY = scaledCY + y;

            // Точка D в мире
            float worldDX = scaledDX + x;
            float worldDY = scaledDY + y;

            // ========================================
            // ШАГ 4: Собираем массив мировых точек
            // ========================================
            PointF[] worldPlane = new PointF[4];
            worldPlane[0] = new PointF(worldAX, worldAY); // Нос (A)
            worldPlane[1] = new PointF(worldBX, worldBY); // Верх хвоста (B)
            worldPlane[2] = new PointF(worldCX, worldCY); // Середина (C)
            worldPlane[3] = new PointF(worldDX, worldDY); // Низ хвоста (D)

            // ========================================
            // ШАГ 5: Рисуем самолётик
            // ========================================
            using (SolidBrush brush = new SolidBrush(Color.Blue))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.FillPolygon(brush, worldPlane);
                g.DrawPolygon(pen, worldPlane);

                // Линия сгиба: соединяем нос (точка 0) с серединой (точка 2)
                g.DrawLine(pen, worldPlane[0], worldPlane[2]);
            }
        }
    }

    public class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true
            );

            this.UpdateStyles();
        }
    }
}