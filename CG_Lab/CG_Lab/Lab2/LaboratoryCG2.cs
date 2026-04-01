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
        Color clippedColor = Color.LightGray; // Светло-серый для отсеченных частей
        Color visibleColor = Color.Green; // Зеленый для видимых частей

        private bool isDashed = false;
        private int dashStep = 5;      // Шаг пунктира
        private int dashLength = 5;     // Длина штриха

        // Данные для отсечения
        private List<Segment> segments = new List<Segment>(); // Список отрезков
        private Rectangle clippingWindow = new Rectangle(200, 150, 200, 150); // Отсекающее окно
        private bool isClippingWindowSet = false;

        // Коды для алгоритма Коэна-Сазерленда
        private const int INSIDE = 0; // 0000
        private const int LEFT = 1;   // 0001
        private const int RIGHT = 2;  // 0010
        private const int BOTTOM = 4; // 0100
        private const int TOP = 8;    // 1000

        public LaboratoryCG2()
        {
            InitializeComponent();
            myBitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            using (Graphics g = Graphics.FromImage(myBitmap))
            {
                g.Clear(Color.White);
            }
            PictureBox.Image = myBitmap;

            SetupPunctHandlers();

            // Устанавливаем значения по умолчанию
            StepTextBox.Text = "5";
            LenthTextBox.Text = "5";
            StepTextBox.Visible = false;
            LenthTextBox.Visible = false;
            StepLabel.Visible = false;
            LenthLabel.Visible = false;
        }

        // Структура для хранения отрезка
        private class Segment
        {
            public int X1, Y1, X2, Y2;
            public Color Color;

            public Segment(int x1, int y1, int x2, int y2, Color color)
            {
                X1 = x1; Y1 = y1; X2 = x2; Y2 = y2;
                Color = color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetupPunctHandlers()
        {
            punctCheckBox.CheckedChanged += (s, e) =>
            {
                isDashed = punctCheckBox.Checked;
                StepTextBox.Visible = isDashed;
                LenthTextBox.Visible = isDashed;
                StepLabel.Visible = isDashed;
                LenthLabel.Visible = isDashed;
            };

            StepTextBox.TextChanged += (s, e) =>
            {
                if (int.TryParse(StepTextBox.Text, out int step) && step > 0)
                {
                    dashStep = step;
                }
                else
                {
                    dashStep = 5;
                    StepTextBox.Text = "5";
                }
            };

            LenthTextBox.TextChanged += (s, e) =>
            {
                if (int.TryParse(LenthTextBox.Text, out int length) && length > 0)
                {
                    dashLength = length;
                }
                else
                {
                    dashLength = 5;
                    LenthTextBox.Text = "5";
                }
            };
        }

        // Алгоритм ЦДА для отрезка
        private void CDA(int xStart, int yStart, int xEnd, int yEnd, Color color)
        {
            if (isDashed)
            {
                DrawDashedLine(xStart, yStart, xEnd, yEnd, color);
                return;
            }

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

        // Асимметричный алгоритм ЦДА
        private void AsymmetricCDA(int xStart, int yStart, int xEnd, int yEnd, Color color)
        {
            if (isDashed)
            {
                DrawDashedLine(xStart, yStart, xEnd, yEnd, color);
                return;
            }

            int dx = xEnd - xStart;
            int dy = yEnd - yStart;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                if (dx == 0) return;

                float step = (float)dy / Math.Abs(dx);
                float y = yStart;
                int stepX = dx > 0 ? 1 : -1;

                for (int x = xStart; x != xEnd + stepX; x += stepX)
                {
                    if (x >= 0 && x < myBitmap.Width && (int)Math.Round(y) >= 0 && (int)Math.Round(y) < myBitmap.Height)
                    {
                        myBitmap.SetPixel(x, (int)Math.Round(y), color);
                    }
                    y += step;
                }
            }
            else
            {
                if (dy == 0) return;

                float step = (float)dx / Math.Abs(dy);
                float x = xStart;
                int stepY = dy > 0 ? 1 : -1;

                for (int y = yStart; y != yEnd + stepY; y += stepY)
                {
                    if ((int)Math.Round(x) >= 0 && (int)Math.Round(x) < myBitmap.Width && y >= 0 && y < myBitmap.Height)
                    {
                        myBitmap.SetPixel((int)Math.Round(x), y, color);
                    }
                    x += step;
                }
            }
        }

        // Рисование пунктирной линии
        private void DrawDashedLine(int x1, int y1, int x2, int y2, Color color)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            if (distance == 0) return;

            double stepX = dx / distance;
            double stepY = dy / distance;

            double currentDistance = 0;
            bool drawing = true;

            double currentX = x1;
            double currentY = y1;

            while (currentDistance < distance)
            {
                if (drawing)
                {
                    double endDistance = Math.Min(currentDistance + dashLength, distance);
                    double endX = x1 + stepX * endDistance;
                    double endY = y1 + stepY * endDistance;

                    int steps = (int)(Math.Abs(endX - currentX) + Math.Abs(endY - currentY));
                    if (steps == 0) steps = 1;

                    double xStep = (endX - currentX) / steps;
                    double yStep = (endY - currentY) / steps;
                    double x = currentX;
                    double y = currentY;

                    for (int i = 0; i <= steps; i++)
                    {
                        int px = (int)Math.Round(x);
                        int py = (int)Math.Round(y);
                        if (px >= 0 && px < myBitmap.Width && py >= 0 && py < myBitmap.Height)
                        {
                            DrawThickPixel(px, py, color);
                        }
                        x += xStep;
                        y += yStep;
                    }

                    currentDistance = endDistance;
                    currentX = endX;
                    currentY = endY;
                }
                else
                {
                    double endDistance = Math.Min(currentDistance + dashStep, distance);
                    currentDistance = endDistance;
                    currentX = x1 + stepX * currentDistance;
                    currentY = y1 + stepY * currentDistance;
                }

                drawing = !drawing;
            }
        }

        // Рисование толстой линии
        private void DrawThickLine(int xStart, int yStart, int xEnd, int yEnd, Color color)
        {
            if (isDashed)
            {
                DrawDashedLine(xStart, yStart, xEnd, yEnd, color);
                return;
            }

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

        private void DrawThickPixel(int x, int y, Color color)
        {
            int thickness = ThicknessCheckedBox.Checked ? 2 : 1;
            int radius = thickness / 2;

            for (int dx = -radius; dx <= radius; dx++)
            {
                for (int dy = -radius; dy <= radius; dy++)
                {
                    int newX = x + dx;
                    int newY = y + dy;

                    if (dx * dx + dy * dy <= radius * radius)
                    {
                        if (newX >= 0 && newX < myBitmap.Width && newY >= 0 && newY < myBitmap.Height)
                        {
                            myBitmap.SetPixel(newX, newY, color);
                        }
                    }
                }
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

                if (pixelColor.ToArgb() != currentBorderColor.ToArgb() &&
                    pixelColor.ToArgb() != currentFillColor.ToArgb())
                {
                    myBitmap.SetPixel(pt.X, pt.Y, currentFillColor);
                    pixels.Push(new Point(pt.X + 1, pt.Y));
                    pixels.Push(new Point(pt.X - 1, pt.Y));
                    pixels.Push(new Point(pt.X, pt.Y + 1));
                    pixels.Push(new Point(pt.X, pt.Y - 1));
                }
            }
        }

        #region Алгоритм Коэна-Сазерленда

        private int ComputeCode(int x, int y, Rectangle window)
        {
            int code = INSIDE;

            if (x < window.Left)
                code |= LEFT;
            else if (x > window.Right)
                code |= RIGHT;

            if (y < window.Top)
                code |= TOP;
            else if (y > window.Bottom)
                code |= BOTTOM;

            return code;
        }

        private bool CohenSutherlandClip(ref int x1, ref int y1, ref int x2, ref int y2, Rectangle window)
        {
            int code1 = ComputeCode(x1, y1, window);
            int code2 = ComputeCode(x2, y2, window);
            bool accept = false;

            while (true)
            {
                if ((code1 == 0) && (code2 == 0))
                {
                    accept = true;
                    break;
                }
                else if ((code1 & code2) != 0)
                {
                    break;
                }
                else
                {
                    int codeOut = (code1 != 0) ? code1 : code2;
                    int x = 0, y = 0;

                    if ((codeOut & TOP) != 0)
                    {
                        x = x1 + (x2 - x1) * (window.Top - y1) / (y2 - y1);
                        y = window.Top;
                    }
                    else if ((codeOut & BOTTOM) != 0)
                    {
                        x = x1 + (x2 - x1) * (window.Bottom - y1) / (y2 - y1);
                        y = window.Bottom;
                    }
                    else if ((codeOut & RIGHT) != 0)
                    {
                        y = y1 + (y2 - y1) * (window.Right - x1) / (x2 - x1);
                        x = window.Right;
                    }
                    else if ((codeOut & LEFT) != 0)
                    {
                        y = y1 + (y2 - y1) * (window.Left - x1) / (x2 - x1);
                        x = window.Left;
                    }

                    if (codeOut == code1)
                    {
                        x1 = x;
                        y1 = y;
                        code1 = ComputeCode(x1, y1, window);
                    }
                    else
                    {
                        x2 = x;
                        y2 = y;
                        code2 = ComputeCode(x2, y2, window);
                    }
                }
            }

            return accept;
        }

        private void DrawClippingWindow()
        {
            CDA(clippingWindow.Left, clippingWindow.Top, clippingWindow.Right, clippingWindow.Top, Color.Black);
            CDA(clippingWindow.Right, clippingWindow.Top, clippingWindow.Right, clippingWindow.Bottom, Color.Black);
            CDA(clippingWindow.Right, clippingWindow.Bottom, clippingWindow.Left, clippingWindow.Bottom, Color.Black);
            CDA(clippingWindow.Left, clippingWindow.Bottom, clippingWindow.Left, clippingWindow.Top, Color.Black);
        }

        private void DrawAllSegments()
        {
            foreach (var seg in segments)
            {
                CDA(seg.X1, seg.Y1, seg.X2, seg.Y2, seg.Color);
            }
        }

        private void PerformClipping()
        {
            if (!isClippingWindowSet)
            {
                MessageBox.Show("Сначала установите отсекающее окно, зажав Ctrl и выделив область мышью!");
                return;
            }

            if (segments.Count == 0)
            {
                MessageBox.Show("Нет отрезков для отсечения! Нарисуйте отрезки в режиме ЦДА или асимметричном ЦДА.");
                return;
            }

            // Очищаем изображение
            using (Graphics g = Graphics.FromImage(myBitmap))
            {
                g.Clear(Color.White);
            }

            // Рисуем отсекающее окно
            DrawClippingWindow();

            // Для каждого отрезка выполняем отсечение
            foreach (var seg in segments)
            {
                int x1 = seg.X1, y1 = seg.Y1;
                int x2 = seg.X2, y2 = seg.Y2;

                // Сохраняем оригинальный отрезок
                int origX1 = x1, origY1 = y1, origX2 = x2, origY2 = y2;

                // Выполняем отсечение
                if (CohenSutherlandClip(ref x1, ref y1, ref x2, ref y2, clippingWindow))
                {
                    // Рисуем отсеченную часть исходного отрезка светло-серым
                    CDA(origX1, origY1, origX2, origY2, clippedColor);
                    // Рисуем видимую часть зеленым (жирным)
                    DrawThickLine(x1, y1, x2, y2, visibleColor);
                }
                else
                {
                    // Если отрезок полностью вне окна, рисуем его светло-серым
                    CDA(origX1, origY1, origX2, origY2, clippedColor);
                }
            }

            PictureBox.Refresh();
        }

        #endregion

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (OtsechRadioButton.Checked && ModifierKeys == Keys.Control)
            {
                xn = e.X;
                yn = e.Y;
                isClippingWindowSet = false;
            }
            else if (OtsechRadioButton.Checked && ModifierKeys != Keys.Control)
            {
                if (e.Button == MouseButtons.Left)
                {
                    xn = e.X;
                    yn = e.Y;
                }
            }
            else if ((CDARadioButton.Checked || AsCDARadioButton.Checked) && e.Button == MouseButtons.Left)
            {
                xn = e.X;
                yn = e.Y;
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (OtsechRadioButton.Checked && ModifierKeys == Keys.Control)
            {
                xk = e.X;
                yk = e.Y;

                int left = Math.Min(xn, xk);
                int right = Math.Max(xn, xk);
                int top = Math.Min(yn, yk);
                int bottom = Math.Max(yn, yk);

                clippingWindow = new Rectangle(left, top, right - left, bottom - top);
                isClippingWindowSet = true;

                // Очищаем и перерисовываем
                using (Graphics g = Graphics.FromImage(myBitmap))
                {
                    g.Clear(Color.White);
                }
                DrawClippingWindow();
                DrawAllSegments();
                PictureBox.Refresh();
            }
            else if (OtsechRadioButton.Checked && ModifierKeys != Keys.Control)
            {
                if (e.Button == MouseButtons.Left)
                {
                    xk = e.X;
                    yk = e.Y;

                    segments.Add(new Segment(xn, yn, xk, yk, currentBorderColor));
                    CDA(xn, yn, xk, yk, currentBorderColor);
                    PictureBox.Refresh();
                }
            }
            else if (CDARadioButton.Checked && e.Button == MouseButtons.Left)
            {
                xk = e.X;
                yk = e.Y;

                segments.Add(new Segment(xn, yn, xk, yk, currentBorderColor));

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
            else if (AsCDARadioButton.Checked && e.Button == MouseButtons.Left)
            {
                xk = e.X;
                yk = e.Y;

                segments.Add(new Segment(xn, yn, xk, yk, currentBorderColor));

                if (ThicknessCheckedBox.Checked)
                {
                    DrawThickLine(xn, yn, xk, yk, currentBorderColor);
                }
                else
                {
                    AsymmetricCDA(xn, yn, xk, yk, currentBorderColor);
                }
                PictureBox.Refresh();
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
            segments.Clear();
            isClippingWindowSet = false;
            PictureBox.Refresh();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (OtsechRadioButton.Checked)
            {
                PerformClipping();
                return;
            }

            if (CDARadioButton.Checked)
            {
                segments.Clear();

                if (ThicknessCheckedBox.Checked)
                {
                    DrawThickLine(10, 10, 10, 110, currentBorderColor);
                    DrawThickLine(10, 10, 110, 10, currentBorderColor);
                    DrawThickLine(10, 110, 110, 110, currentBorderColor);
                    DrawThickLine(110, 10, 110, 110, currentBorderColor);

                    segments.Add(new Segment(10, 10, 10, 110, currentBorderColor));
                    segments.Add(new Segment(10, 10, 110, 10, currentBorderColor));
                    segments.Add(new Segment(10, 110, 110, 110, currentBorderColor));
                    segments.Add(new Segment(110, 10, 110, 110, currentBorderColor));

                    DrawThickLine(150, 10, 150, 200, currentBorderColor);
                    DrawThickLine(250, 50, 150, 200, currentBorderColor);
                    DrawThickLine(150, 10, 250, 150, currentBorderColor);

                    segments.Add(new Segment(150, 10, 150, 200, currentBorderColor));
                    segments.Add(new Segment(250, 50, 150, 200, currentBorderColor));
                    segments.Add(new Segment(150, 10, 250, 150, currentBorderColor));
                }
                else
                {
                    CDA(10, 10, 10, 110, currentBorderColor);
                    CDA(10, 10, 110, 10, currentBorderColor);
                    CDA(10, 110, 110, 110, currentBorderColor);
                    CDA(110, 10, 110, 110, currentBorderColor);

                    segments.Add(new Segment(10, 10, 10, 110, currentBorderColor));
                    segments.Add(new Segment(10, 10, 110, 10, currentBorderColor));
                    segments.Add(new Segment(10, 110, 110, 110, currentBorderColor));
                    segments.Add(new Segment(110, 10, 110, 110, currentBorderColor));

                    CDA(150, 10, 150, 200, currentBorderColor);
                    CDA(250, 50, 150, 200, currentBorderColor);
                    CDA(150, 10, 250, 150, currentBorderColor);

                    segments.Add(new Segment(150, 10, 150, 200, currentBorderColor));
                    segments.Add(new Segment(250, 50, 150, 200, currentBorderColor));
                    segments.Add(new Segment(150, 10, 250, 150, currentBorderColor));
                }

                PictureBox.Refresh();
            }
            else if (AsCDARadioButton.Checked)
            {
                segments.Clear();

                if (ThicknessCheckedBox.Checked)
                {
                    DrawThickLine(10, 10, 10, 110, currentBorderColor);
                    DrawThickLine(10, 10, 110, 10, currentBorderColor);
                    DrawThickLine(10, 110, 110, 110, currentBorderColor);
                    DrawThickLine(110, 10, 110, 110, currentBorderColor);

                    segments.Add(new Segment(10, 10, 10, 110, currentBorderColor));
                    segments.Add(new Segment(10, 10, 110, 10, currentBorderColor));
                    segments.Add(new Segment(10, 110, 110, 110, currentBorderColor));
                    segments.Add(new Segment(110, 10, 110, 110, currentBorderColor));

                    DrawThickLine(150, 10, 150, 200, currentBorderColor);
                    DrawThickLine(250, 50, 150, 200, currentBorderColor);
                    DrawThickLine(150, 10, 250, 150, currentBorderColor);

                    segments.Add(new Segment(150, 10, 150, 200, currentBorderColor));
                    segments.Add(new Segment(250, 50, 150, 200, currentBorderColor));
                    segments.Add(new Segment(150, 10, 250, 150, currentBorderColor));
                }
                else
                {
                    AsymmetricCDA(10, 10, 10, 110, currentBorderColor);
                    AsymmetricCDA(10, 10, 110, 10, currentBorderColor);
                    AsymmetricCDA(10, 110, 110, 110, currentBorderColor);
                    AsymmetricCDA(110, 10, 110, 110, currentBorderColor);

                    segments.Add(new Segment(10, 10, 10, 110, currentBorderColor));
                    segments.Add(new Segment(10, 10, 110, 10, currentBorderColor));
                    segments.Add(new Segment(10, 110, 110, 110, currentBorderColor));
                    segments.Add(new Segment(110, 10, 110, 110, currentBorderColor));

                    AsymmetricCDA(150, 10, 150, 200, currentBorderColor);
                    AsymmetricCDA(250, 50, 150, 200, currentBorderColor);
                    AsymmetricCDA(150, 10, 250, 150, currentBorderColor);

                    segments.Add(new Segment(150, 10, 150, 200, currentBorderColor));
                    segments.Add(new Segment(250, 50, 150, 200, currentBorderColor));
                    segments.Add(new Segment(150, 10, 250, 150, currentBorderColor));
                }

                PictureBox.Refresh();
            }
            else if (BresenhamRadioButton.Checked)
            {
                int centerX = PictureBox.Width / 2;
                int centerY = PictureBox.Height / 2;
                int radius = 100;

                BresenhamCircle(centerX, centerY, radius, currentBorderColor);
                PictureBox.Refresh();
            }
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

        private void punctBox_CheckedChanged(object sender, EventArgs e)
        {
            if (punctCheckBox.Checked == true)
            {
                StepTextBox.Visible = true;
                LenthTextBox.Visible = true;
                StepLabel.Visible = true;
                LenthLabel.Visible = true;
            }
            else
            {
                StepTextBox.Visible = false;
                LenthTextBox.Visible = false;
                StepTextBox.Text = "5";
                LenthTextBox.Text = "5";
                StepLabel.Visible = false;
                LenthLabel.Visible = false;
            }
        }
    }
}