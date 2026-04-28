using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bicycle : Form
    {
        float bikeX = 50;          // Положение велосипеда по горизонтали
        float angle = 0;           // Угол поворота колес и педалей
        bool isTandem = false;     // Флаг: тандем или обычный велик
        float speed = 3;           // Скорость движения


        public Bicycle()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Мягкие линии
            Pen framePen = new Pen(Color.Black, 3); // Перо для рамы
            Pen wheelPen = new Pen(Color.DarkGray, 2); // Перо для колес

            // Параметры велосипеда
            int wheelRadius = 30;
            int wheelY = 250;
            int wheelDistance = 100; // Расстояние между колесами

            // 1. Рисуем заднее колесо
            DrawWheel(g, wheelPen, bikeX, wheelY, wheelRadius);

            // 2. Рисуем переднее колесо (смещается, если тандем)
            float frontWheelX = isTandem ? bikeX + wheelDistance * 2 : bikeX + wheelDistance;
            DrawWheel(g, wheelPen, frontWheelX, wheelY, wheelRadius);

            // 3. Рисуем раму
            // Задняя часть
            g.DrawLine(framePen, bikeX, wheelY, bikeX + 30, wheelY - 50); // К сиденью 1
            g.DrawLine(framePen, bikeX, wheelY, bikeX + 50, wheelY);      // К педалям 1

            if (isTandem)
            {
                // Рама тандема (соединяем секции)
                g.DrawLine(framePen, bikeX + 50, wheelY, bikeX + 150, wheelY);
                g.DrawLine(framePen, bikeX + 30, wheelY - 50, bikeX + 130, wheelY - 50);
                // Второе сиденье и педали
                DrawPedals(g, bikeX + 150, wheelY, 15);
            }

            // Передняя вилка
            g.DrawLine(framePen, frontWheelX, wheelY, frontWheelX - 20, wheelY - 60);
            // Руль
            g.DrawLine(framePen, frontWheelX - 30, wheelY - 60, frontWheelX - 10, wheelY - 60);

            // 4. Рисуем основные педали
            DrawPedals(g, bikeX + 50, wheelY, 15);
        }

        // Метод для рисования колеса со спицами
        private void DrawWheel(Graphics g, Pen pen, float x, float y, int r)
        {
            g.DrawEllipse(pen, x - r, y - r, r * 2, r * 2);
            // Рисуем 4 спицы для видимости вращения
            for (int i = 0; i < 4; i++)
            {
                double a = angle + i * Math.PI / 2;
                float sx = (float)(x + r * Math.Cos(a));
                float sy = (float)(y + r * Math.Sin(a));
                g.DrawLine(pen, x, y, sx, sy);
            }
        }

        // Метод для рисования педалей
        private void DrawPedals(Graphics g, float x, float y, int size)
        {
            float px = (float)(x + size * Math.Cos(angle));
            float py = (float)(y + size * Math.Sin(angle));
            g.DrawLine(Pens.Red, x, y, px, py); // Сама педаль
            g.FillRectangle(Brushes.Black, px - 5, py - 2, 10, 4); // Подножка
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bikeX += speed; // Двигаем велик вправо
            angle += 0.1f;  // Вращаем колеса

            // Если уехал за экран — возвращаем слева
            if (bikeX > this.Width) bikeX = -200;

            this.Invalidate(); // Перерисовать форму
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isTandem = !isTandem; // Переключаем состояние
        }
    }
}
