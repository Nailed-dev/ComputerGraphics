using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace cosmos
{
    public partial class Cosmos : Form
    {
        private System.Windows.Forms.Timer timer1;

        private bool isRunning = false;

        private double angle1 = 0;
        private double angle2 = Math.PI;

        private double speed1 = 0.03;
        private double speed2 = -0.02;

        public Cosmos()
        {
            InitializeComponent();

            this.Text = "Космические корабли";
            this.ClientSize = new Size(900, 600);

            // Подключаем события к элементам, созданным в конструкторе
            btnStart.Click += BtnStart_Click;
            panelSpace.Paint += PanelSpace_Paint;

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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            angle1 += speed1;
            angle2 += speed2;

            panelSpace.Invalidate();
        }

        private void PanelSpace_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int cx = panelSpace.Width / 2;
            int cy = panelSpace.Height / 2;

            int earthR = 50;
            int orbitR1 = 140;
            int orbitR2 = 210;

            // Очистка области космоса
            g.Clear(Color.Black);

            // Земля
            g.FillEllipse(
                Brushes.DodgerBlue,
                cx - earthR,
                cy - earthR,
                earthR * 2,
                earthR * 2
            );

            g.DrawEllipse(
                Pens.White,
                cx - earthR,
                cy - earthR,
                earthR * 2,
                earthR * 2
            );

            // Материки
            g.FillEllipse(Brushes.Green, cx - 25, cy - 15, 30, 20);
            g.FillEllipse(Brushes.Green, cx + 5, cy + 5, 25, 15);

            // Орбиты
            using (Pen orbitPen = new Pen(Color.Gray, 1))
            {
                orbitPen.DashStyle = DashStyle.Dash;

                g.DrawEllipse(
                    orbitPen,
                    cx - orbitR1,
                    cy - orbitR1,
                    orbitR1 * 2,
                    orbitR1 * 2
                );

                g.DrawEllipse(
                    orbitPen,
                    cx - orbitR2,
                    cy - orbitR2,
                    orbitR2 * 2,
                    orbitR2 * 2
                );
            }

            // Первый корабль
            float x1 = cx + orbitR1 * (float)Math.Cos(angle1);
            float y1 = cy + orbitR1 * (float)Math.Sin(angle1);

            // Второй корабль
            float x2 = cx + orbitR2 * (float)Math.Cos(angle2);
            float y2 = cy + orbitR2 * (float)Math.Sin(angle2);

            // Внизу корабль больше, вверху меньше
            float scale1 = 0.5f + (((float)Math.Sin(angle1) + 1f) / 2f) * 0.8f;
            float scale2 = 0.5f + (((float)Math.Sin(angle2) + 1f) / 2f) * 0.8f;

            DrawShip(g, x1, y1, scale1, Brushes.Orange);
            DrawShip(g, x2, y2, scale2, Brushes.LightGreen);
        }

        private void DrawShip(Graphics g, float x, float y, float scale, Brush brush)
        {
            float w = 20 * scale;
            float h = 12 * scale;

            // Корпус
            g.FillEllipse(brush, x - w / 2, y - h / 2, w, h);
            g.DrawEllipse(Pens.White, x - w / 2, y - h / 2, w, h);

            // Нос корабля
            PointF[] nose =
            {
                new PointF(x + w / 2, y),
                new PointF(x + w / 2 + 8 * scale, y - 4 * scale),
                new PointF(x + w / 2 + 8 * scale, y + 4 * scale)
            };

            g.FillPolygon(brush, nose);
            g.DrawPolygon(Pens.White, nose);

            // Иллюминатор
            g.FillEllipse(
                Brushes.LightBlue,
                x - 3 * scale,
                y - 3 * scale,
                6 * scale,
                6 * scale
            );

            g.DrawEllipse(
                Pens.White,
                x - 3 * scale,
                y - 3 * scale,
                6 * scale,
                6 * scale
            );
        }
    }
}