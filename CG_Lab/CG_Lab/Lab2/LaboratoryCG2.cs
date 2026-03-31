using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CG_Lab.Lab2
{
    /// <summary>
    /// Главная форма лабораторной работы №2 по компьютерной графике.
    /// Реализует алгоритмы ЦДА, рисование толстых линий и заливку с затравкой.
    /// </summary>
    public partial class LaboratoryCG2 : Form
    {
        /// <summary>
        /// Координаты начальной точки отрезка (X, Y).
        /// </summary>
        public int xn, yn;

        /// <summary>
        /// Координаты конечной точки отрезка (X, Y).
        /// </summary>
        public int xk, yk;

        /// <summary>
        /// Растровое изображение для рисования.
        /// </summary>
        Bitmap myBitmap;

        /// <summary>
        /// Текущий цвет границы фигуры.
        /// </summary>
        Color currentBorderColor = Color.Red;

        /// <summary>
        /// Текущий цвет заливки фигуры.
        /// </summary>
        Color currentFillColor = Color.Blue;

        /// <summary>
        /// Конструктор формы. Инициализирует компоненты и создает пустое растровое изображение.
        /// </summary>
        public LaboratoryCG2()
        {
            InitializeComponent();
            // Инициализация растрового изображения с размерами элемента PictureBox
            myBitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            using (Graphics g = Graphics.FromImage(myBitmap))
            {
                // Очистка изображения белым цветом
                g.Clear(Color.White);
            }
            PictureBox.Image = myBitmap;
        }

        /// <summary>
        /// Обработчик события загрузки формы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Алгоритм ЦДА (цифровой дифференциальный анализатор) для рисования отрезка.
        /// Вычисляет промежуточные точки отрезка с плавающей точкой и округляет их.
        /// </summary>
        /// <param name="xStart">Координата X начальной точки.</param>
        /// <param name="yStart">Координата Y начальной точки.</param>
        /// <param name="xEnd">Координата X конечной точки.</param>
        /// <param name="yEnd">Координата Y конечной точки.</param>
        /// <param name="color">Цвет отрезка.</param>
        private void CDA(int xStart, int yStart, int xEnd, int yEnd, Color color)
        {
            // Вычисление разницы координат
            int dx = xEnd - xStart;
            int dy = yEnd - yStart;
            // Определение количества шагов (максимальная разница по осям)
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            // Если точки совпадают, рисуем один пиксель
            if (steps == 0)
            {
                myBitmap.SetPixel(xStart, yStart, color);
                return;
            }

            // Вычисление приращений
            float xIncrement = dx / (float)steps;
            float yIncrement = dy / (float)steps;
            float x = xStart;
            float y = yStart;

            // Цикл по всем шагам
            for (int i = 0; i <= steps; i++)
            {
                // Проверка выхода за границы изображения
                if (x >= 0 && x < myBitmap.Width && y >= 0 && y < myBitmap.Height)
                {
                    // Установка пикселя с округлением координат
                    myBitmap.SetPixel((int)Math.Round(x), (int)Math.Round(y), color);
                }
                x += xIncrement;
                y += yIncrement;
            }
        }

        /// <summary>
        /// Рисование толстой линии путем закрашивания соседних пикселей.
        /// Создает эффект утолщения за счет рисования пикселей в окрестности 3x3.
        /// </summary>
        /// <param name="xStart">Координата X начальной точки.</param>
        /// <param name="yStart">Координата Y начальной точки.</param>
        /// <param name="xEnd">Координата X конечной точки.</param>
        /// <param name="yEnd">Координата Y конечной точки.</param>
        /// <param name="color">Цвет линии.</param>
        private void DrawThickLine(int xStart, int yStart, int xEnd, int yEnd, Color color)
        {
            // Вычисление разницы координат
            int dx = xEnd - xStart;
            int dy = yEnd - yStart;
            // Определение количества шагов
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            // Если точки совпадают, рисуем группу пикселей 3x3
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

            // Вычисление приращений
            float xIncrement = dx / (float)steps;
            float yIncrement = dy / (float)steps;
            float x = xStart;
            float y = yStart;

            // Цикл по всем шагам
            for (int i = 0; i <= steps; i++)
            {
                // Рисуем квадрат 3x3 вокруг каждой точки линии
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

        /// <summary>
        /// Алгоритм заливки с затравкой (итеративная версия с использованием стека).
        /// Заполняет замкнутую область, ограниченную цветом границы.
        /// Использует стек вместо рекурсии для предотвращения переполнения стека.
        /// </summary>
        /// <param name="x1">Координата X точки затравки.</param>
        /// <param name="y1">Координата Y точки затравки.</param>
        private void FloodFill(int x1, int y1)
        {
            // Проверка выхода за границы изображения
            if (x1 < 0 || x1 >= myBitmap.Width || y1 < 0 || y1 >= myBitmap.Height)
                return;

            // Получение цвета начального пикселя
            Color targetColor = myBitmap.GetPixel(x1, y1);

            // Если начальный пиксель уже залит или является границей, выходим
            if (targetColor.ToArgb() == currentFillColor.ToArgb() ||
                targetColor.ToArgb() == currentBorderColor.ToArgb())
                return;

            // Использование стека для итеративной заливки (избегаем ограничений рекурсии)
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x1, y1));

            while (pixels.Count > 0)
            {
                Point pt = pixels.Pop();

                // Проверка выхода за границы изображения
                if (pt.X < 0 || pt.X >= myBitmap.Width || pt.Y < 0 || pt.Y >= myBitmap.Height)
                    continue;

                Color currentColor = myBitmap.GetPixel(pt.X, pt.Y);

                // Если этот пиксель является целевым цветом (не граница и не залит)
                if (currentColor.ToArgb() == targetColor.ToArgb())
                {
                    // Закрашиваем этот пиксель
                    myBitmap.SetPixel(pt.X, pt.Y, currentFillColor);

                    // Добавляем соседние пиксели в стек
                    pixels.Push(new Point(pt.X + 1, pt.Y));
                    pixels.Push(new Point(pt.X - 1, pt.Y));
                    pixels.Push(new Point(pt.X, pt.Y + 1));
                    pixels.Push(new Point(pt.X, pt.Y - 1));
                }
            }
        }

        /// <summary>
        /// Альтернативная итеративная версия заливки с затравкой.
        /// Отличается логикой сравнения цветов (заливает по цвету области, а не по целевому цвету).
        /// </summary>
        /// <param name="x">Координата X точки затравки.</param>
        /// <param name="y">Координата Y точки затравки.</param>
        /// <param name="fillColor">Цвет заливки.</param>
        private void FloodFillIterative(int x, int y, Color fillColor)
        {
            // Проверка выхода за границы изображения
            if (x < 0 || x >= myBitmap.Width || y < 0 || y >= myBitmap.Height)
                return;

            // Получение цвета начального пикселя
            Color oldColor = myBitmap.GetPixel(x, y);
            // Если пиксель уже залит или является границей, выходим
            if (oldColor.ToArgb() == fillColor.ToArgb() || oldColor.ToArgb() == currentBorderColor.ToArgb())
                return;

            // Использование стека для итеративной заливки
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point pt = pixels.Pop();
                if (pt.X < 0 || pt.X >= myBitmap.Width || pt.Y < 0 || pt.Y >= myBitmap.Height)
                    continue;

                Color pixelColor = myBitmap.GetPixel(pt.X, pt.Y);
                // Если цвет пикселя соответствует исходному цвету области
                if (pixelColor.ToArgb() == oldColor.ToArgb())
                {
                    // Закрашиваем пиксель
                    myBitmap.SetPixel(pt.X, pt.Y, fillColor);
                    // Добавляем соседние пиксели в стек
                    pixels.Push(new Point(pt.X + 1, pt.Y));
                    pixels.Push(new Point(pt.X - 1, pt.Y));
                    pixels.Push(new Point(pt.X, pt.Y + 1));
                    pixels.Push(new Point(pt.X, pt.Y - 1));
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки мыши на PictureBox.
        /// Запоминает координаты начальной точки для рисования отрезка.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события мыши.</param>
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Левая кнопка мыши - начало рисования отрезка
            if (e.Button == MouseButtons.Left)
            {
                xn = e.X;
                yn = e.Y;
            }
        }

        /// <summary>
        /// Обработчик отпускания кнопки мыши на PictureBox.
        /// Выполняет рисование отрезка или заливку в зависимости от выбранного режима.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события мыши.</param>
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            // Левая кнопка мыши - рисование отрезка
            if (e.Button == MouseButtons.Left)
            {
                xk = e.X;
                yk = e.Y;

                // Рисование в зависимости от выбранного алгоритма
                if (CDARadioButton.Checked)
                {
                    if (ThicknessCheckedBox.Checked)
                    {
                        // Рисование толстой линии
                        DrawThickLine(xn, yn, xk, yk, currentBorderColor);
                    }
                    else
                    {
                        // Рисование обычной линии алгоритмом ЦДА
                        CDA(xn, yn, xk, yk, currentBorderColor);
                    }
                    PictureBox.Refresh();
                }
                else
                {
                    MessageBox.Show("Выберите алгоритм вывода фигуры!");
                }
            }
            // Правая кнопка мыши - заливка области
            else if (e.Button == MouseButtons.Right && FillRadioButton.Checked)
            {
                // Выполнение заливки по правой кнопке мыши
                currentFillColor = colorDialog2.Color;
                FloodFill(e.X, e.Y);
                PictureBox.Refresh();
            }
        }

        /// <summary>
        /// Обработчик кнопки очистки. Очищает все изображение белым цветом.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(myBitmap))
            {
                // Очистка изображения белым цветом
                g.Clear(Color.White);
            }
            PictureBox.Refresh();
        }

        /// <summary>
        /// Обработчик кнопки выполнения. Рисует предустановленные фигуры (прямоугольник и треугольник).
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
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

        /// <summary>
        /// Обработчик кнопки выбора цвета заливки.
        /// Открывает диалог выбора цвета и сохраняет выбранный цвет.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ColorFillButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog2.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                currentFillColor = colorDialog2.Color;
            }
        }

        /// <summary>
        /// Обработчик кнопки выбора цвета границы.
        /// Открывает диалог выбора цвета и сохраняет выбранный цвет.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
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