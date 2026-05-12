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

        // Положение самолётика
        private float planeX = 130;
        private float planeY = 250;

        // Масштаб самолётика
        private float planeScale = 0.5f;

        public Plane()
        {
            InitializeComponent();

            // Подключаем события
            btnStart.Click += BtnStart_Click;
            btnReset.Click += BtnReset_Click;
            panelScene.Paint += PanelScene_Paint;

            // Создаём таймер
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 30;
            timer1.Tick += Timer1_Tick;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                timer1.Start();
                btnStart.Text = "Стоп";
            }
            else
            {
                timer1.Stop();
                btnStart.Text = "Старт";
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetPlane();
            panelScene.Invalidate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Смещение вправо
            planeX += 3;

            // Смещение немного вниз
            planeY += 1;

            // Масштабирование: самолётик приближается
            planeScale += 0.01f;

            // Если самолётик улетел или стал слишком большим — вернуть к окну
            if (planeX > panelScene.Width + 100 || planeScale > 2.2f)
            {
                ResetPlane();
            }

            // Перерисовать область действия
            panelScene.Invalidate();
        }

        private void ResetPlane()
        {
            planeX = 130;
            planeY = 250;
            planeScale = 0.5f;
        }

        private void PanelScene_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = panelScene.Width;
            int h = panelScene.Height;

           
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

            // Башни
            int[] towerX = { 20, 150 };
            foreach (int x in towerX)
            {
                Rectangle tower = new Rectangle(x, groundY - 230, 50, 230);
                g.FillRectangle(Brushes.DimGray, tower);
                g.DrawRectangle(Pens.Black, tower);

                Point[] roof = {
            new Point(x, groundY - 230),
            new Point(x + 25, groundY - 270),
            new Point(x + 50, groundY - 230)
        };
                g.FillPolygon(Brushes.DarkRed, roof);
                g.DrawPolygon(Pens.Black, roof);
            }
        }

        private void DrawPlane(Graphics g, float x, float y, float scale)
        {
            GraphicsState state = g.Save();

            // Смещение самолётика
            g.TranslateTransform(x, y);

            // Масштабирование самолётика
            g.ScaleTransform(scale, scale);

            // Максимально простой бумажный самолётик:
            // один многоугольник + линия сгиба
            PointF[] plane =
            {
                new PointF(0, 0),        // нос
                new PointF(-50, -18),    // верхняя часть хвоста
                new PointF(-35, 0),      // середина
                new PointF(-50, 18)      // нижняя часть хвоста
            };

            using (SolidBrush brush = new SolidBrush(Color.White))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.FillPolygon(brush, plane);
                g.DrawPolygon(pen, plane);

                // Линия сгиба
                g.DrawLine(pen, 0, 0, -35, 0);
            }

            g.Restore(state);
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