using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CG_Lab.Lab2
{
    public partial class LaboratoryCG2 : Form
    {
        public int xn, yn, xk, yk;
        Bitmap myBitmap;
        Color currentBorderColor = Color.Red;
        Color currentFillColor = Color.Blue;

        public LaboratoryCG2()
        {
            InitializeComponent();
            myBitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            using (Graphics g = Graphics.FromImage(myBitmap))
            {
                g.Clear(Color.White);
            }
            PictureBox.Image = myBitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Алгоритм ЦДА для отрезка
        private void CDA(int xStart, int yStart, int xEnd, int yEnd, Color color)
        {
            int dx = xEnd - xStart;
            int dy = yEnd - yStart;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            if (steps == 0)
            {
                myBitmap.SetPixel(xStart, yStart, color);
                return;
            }

            float xIncrement = dx / (float)steps;
            float yIncrement = dy / (float)steps;
            float x = xStart;
            float y = yStart;

            for (int i = 0; i <= steps; i++)
            {
                if (x >= 0 && x < myBitmap.Width && y >= 0 && y < myBitmap.Height)
                {
                    myBitmap.SetPixel((int)Math.Round(x), (int)Math.Round(y), color);
                }
                x += xIncrement;
                y += yIncrement;
            }
        }

        // Рисование толстой линии
        private void DrawThickLine(int xStart, int yStart, int xEnd, int yEnd, Color color)
        {
            int dx = xEnd - xStart;
            int dy = yEnd - yStart;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            if (steps == 0)
            {
                for (int offsetX = -1; offsetX <= 1; offsetX++)
                {
                    for (int offsetY = -1; offsetY <= 1; offsetY++)
                    {
                        int newX = xStart + offsetX;
                        int newY = yStart + offsetY;
                        if (newX >= 0 && newX < myBitmap.Width && newY >= 0 && newY < myBitmap.Height)
                        {
                            myBitmap.SetPixel(newX, newY, color);
                        }
                    }
                }
                return;
            }

            float xIncrement = dx / (float)steps;
            float yIncrement = dy / (float)steps;
            float x = xStart;
            float y = yStart;

            for (int i = 0; i <= steps; i++)
            {
                for (int offsetX = -1; offsetX <= 1; offsetX++)
                {
                    for (int offsetY = -1; offsetY <= 1; offsetY++)
                    {
                        int newX = (int)Math.Round(x) + offsetX;
                        int newY = (int)Math.Round(y) + offsetY;
                        if (newX >= 0 && newX < myBitmap.Width && newY >= 0 && newY < myBitmap.Height)
                        {
                            myBitmap.SetPixel(newX, newY, color);
                        }
                    }
                }
                x += xIncrement;
                y += yIncrement;
            }
        }

        // Алгоритм Брезенхема для окружности
        private void BresenhamCircle(int xc, int yc, int r, Color color)
        {
            int x = 0;
            int y = r;
            int d = 3 - 2 * r;

            DrawCirclePoints(xc, yc, x, y, color);

            while (y >= x)
            {
                x++;

                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                {
                    d = d + 4 * x + 6;
                }

                DrawCirclePoints(xc, yc, x, y, color);
            }
        }

        // Рисование симметричных точек окружности
        private void DrawCirclePoints(int xc, int yc, int x, int y, Color color)
        {
            if (xc + x >= 0 && xc + x < myBitmap.Width && yc + y >= 0 && yc + y < myBitmap.Height)
                myBitmap.SetPixel(xc + x, yc + y, color);

            if (xc - x >= 0 && xc - x < myBitmap.Width && yc + y >= 0 && yc + y < myBitmap.Height)
                myBitmap.SetPixel(xc - x, yc + y, color);

            if (xc + x >= 0 && xc + x < myBitmap.Width && yc - y >= 0 && yc - y < myBitmap.Height)
                myBitmap.SetPixel(xc + x, yc - y, color);

            if (xc - x >= 0 && xc - x < myBitmap.Width && yc - y >= 0 && yc - y < myBitmap.Height)
                myBitmap.SetPixel(xc - x, yc - y, color);

            if (xc + y >= 0 && xc + y < myBitmap.Width && yc + x >= 0 && yc + x < myBitmap.Height)
                myBitmap.SetPixel(xc + y, yc + x, color);

            if (xc - y >= 0 && xc - y < myBitmap.Width && yc + x >= 0 && yc + x < myBitmap.Height)
                myBitmap.SetPixel(xc - y, yc + x, color);

            if (xc + y >= 0 && xc + y < myBitmap.Width && yc - x >= 0 && yc - x < myBitmap.Height)
                myBitmap.SetPixel(xc + y, yc - x, color);

            if (xc - y >= 0 && xc - y < myBitmap.Width && yc - x >= 0 && yc - x < myBitmap.Height)
                myBitmap.SetPixel(xc - y, yc - x, color);
        }

        // Заливка с затравкой
        private void FloodFill(int x1, int y1)
        {
            if (x1 < 0 || x1 >= myBitmap.Width || y1 < 0 || y1 >= myBitmap.Height)
                return;

            Color currentColor = myBitmap.GetPixel(x1, y1);

            // Если текущий цвет - это цвет границы или уже цвет заливки - выходим
            if (currentColor.ToArgb() == currentBorderColor.ToArgb() ||
                currentColor.ToArgb() == currentFillColor.ToArgb())
                return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x1, y1));

            while (pixels.Count > 0)
            {
                Point pt = pixels.Pop();

                if (pt.X < 0 || pt.X >= myBitmap.Width || pt.Y < 0 || pt.Y >= myBitmap.Height)
                    continue;

                Color pixelColor = myBitmap.GetPixel(pt.X, pt.Y);

                // Если пиксель не является границей и не залит
                if (pixelColor.ToArgb() != currentBorderColor.ToArgb() &&
                    pixelColor.ToArgb() != currentFillColor.ToArgb())
                {
                    // Закрашиваем пиксель
                    myBitmap.SetPixel(pt.X, pt.Y, currentFillColor);

                    // Добавляем соседей в стек
                    pixels.Push(new Point(pt.X + 1, pt.Y));
                    pixels.Push(new Point(pt.X - 1, pt.Y));
                    pixels.Push(new Point(pt.X, pt.Y + 1));
                    pixels.Push(new Point(pt.X, pt.Y - 1));
                }
            }
        }
        

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                xn = e.X;
                yn = e.Y;
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                xk = e.X;
                yk = e.Y;

                if (CDARadioButton.Checked)
                {
                    if (ThicknessCheckedBox.Checked)
                    {
                        DrawThickLine(xn, yn, xk, yk, currentBorderColor);
                    }
                    else
                    {
                        CDA(xn, yn, xk, yk, currentBorderColor);
                    }
                    PictureBox.Refresh();
                }
                else
                {
                    MessageBox.Show("Выберите алгоритм вывода фигуры!");
                }
            }
            else if (e.Button == MouseButtons.Right && FillRadioButton.Checked)
            {
                FloodFill(e.X, e.Y);
                PictureBox.Refresh();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(myBitmap))
            {
                g.Clear(Color.White);
            }
            PictureBox.Refresh();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            // Если выбран алгоритм ЦДА
            if (CDARadioButton.Checked)
            {
                // Рисование прямоугольника
                CDA(10, 10, 10, 110, currentBorderColor);
                CDA(10, 10, 110, 10, currentBorderColor);
                CDA(10, 110, 110, 110, currentBorderColor);
                CDA(110, 10, 110, 110, currentBorderColor);

                // Рисование треугольника
                CDA(150, 10, 150, 200, currentBorderColor);
                CDA(250, 50, 150, 200, currentBorderColor);
                CDA(150, 10, 250, 150, currentBorderColor);

                PictureBox.Refresh();
            }
            // Если выбран алгоритм Брезенхема для окружности
            else if (BresenhamRadioButton.Checked)
            {
                int centerX = PictureBox.Width / 2;
                int centerY = PictureBox.Height / 2;
                int radius = 100;

                BresenhamCircle(centerX, centerY, radius, currentBorderColor);
                PictureBox.Refresh();
            }
            // Если выбран режим заливки
            else if (FillRadioButton.Checked)
            {
                MessageBox.Show("Для заливки используйте правую кнопку мыши внутри фигуры");
            }
            else
            {
                MessageBox.Show("Выберите алгоритм!");
            }
        }

        private void ColorFillButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog2.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                currentFillColor = colorDialog2.Color;
            }
        }

        private void ColorLineButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                currentBorderColor = colorDialog1.Color;
            }
        }
    }
}