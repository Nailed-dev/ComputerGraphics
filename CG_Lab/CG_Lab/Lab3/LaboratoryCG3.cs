using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab.Lab3
{
    public partial class LaboratoryCG3 : Form
    {


        int[,] fg1 = new int[5, 3]; // матрица тела
        int[,] osi = new int[4, 3]; // матрица координат осей
        int[,] matr_sdv = new int[3, 3]; //матрица преобразования
        bool f = false;


        int k, l;
        public LaboratoryCG3()
        {
            InitializeComponent();
        }

        private void Init_figure1()
        {
            fg1[0, 0] = 87;
            fg1[0, 1] = 291;
            fg1[0, 2] = 1;


            fg1[1, 0] = 86;
            fg1[1, 1] = 13;
            fg1[1, 2] = 1;


            fg1[2, 0] = 185;
            fg1[2, 1] = 10;
            fg1[2, 2] = 1;


            fg1[3, 0] = 397;
            fg1[3, 1] = 336;
            fg1[3, 2] = 1;

            fg1[4, 0] = 394;
            fg1[4, 1] = 244;
            fg1[4, 2] = 1;
        }






        private void Init_matr_preob(int k1, int l1)
        {
            matr_sdv[0, 0] = 1; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = 1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }


        private void Init_osi()
        {
            osi[0, 0] = -400; osi[0, 1] = 0; osi[0, 2] = 1;
            osi[1, 0] = 400; osi[1, 1] = 0; osi[1, 2] = 1;
            osi[2, 0] = 0; osi[2, 1] = 400; osi[2, 2] = 1;
            osi[3, 0] = 0; osi[3, 1] = -400; osi[3, 2] = 1;

        }



        private void DrawFigure1()
        {
            Init_figure1();

            // Вычисляем центр фигуры 
            if (k == 0 && l == 0)
            {
                int minX = int.MaxValue, minY = int.MaxValue;
                int maxX = int.MinValue, maxY = int.MinValue;

                for (int i = 0; i < fg1.GetLength(0); i++)
                {
                    if (fg1[i, 0] < minX) minX = fg1[i, 0];
                    if (fg1[i, 1] < minY) minY = fg1[i, 1];
                    if (fg1[i, 0] > maxX) maxX = fg1[i, 0];
                    if (fg1[i, 1] > maxY) maxY = fg1[i, 1];
                }

                int figureCenterX = (minX + maxX) / 2;
                int figureCenterY = (minY + maxY) / 2;

                // Добавляем центрирование в k и l
                k = pictureBox1.Width / 2 - figureCenterX;
                l = pictureBox1.Height / 2 - figureCenterY;
            }

            Init_matr_preob(k, l);
            int[,] kv1 = Multiply_matr(fg1, matr_sdv);

            using (Pen myPen = new Pen(Color.Black, 3))
            using (Graphics g = Graphics.FromHwnd(pictureBox1.Handle))
            {
                g.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
                g.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
                g.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
                g.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[4, 0], kv1[4, 1]);
                g.DrawLine(myPen, kv1[4, 0], kv1[4, 1], kv1[0, 0], kv1[0, 1]);
            }
        }

        private void Draw_osi()
        {
            Init_osi();
            Init_matr_preob(k, l);
            int[,] osi1 = Multiply_matr(osi, matr_sdv);
            Pen myPen = new Pen(Color.Red, 3);// цвет линии и ширина
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // рисуем ось ОХ
            g.DrawLine(myPen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1,
            1]);
            // рисуем ось ОУ
            g.DrawLine(myPen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3,
            1]);
            g.Dispose();
            myPen.Dispose();
        }
        //вывод осей в центре pictureBox
        private void DrawOsiButton_Click(object sender, EventArgs e)
        {
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;
            Draw_osi();
        }


        private int[,] Multiply_matr(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int[,] r = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;
                    for (int ii = 0; ii < m; ii++)
                    {
                        r[i, j] += a[i, ii] * b[ii, j];
                    }
                }
            }
            return r;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            StartButton.Text = "Стоп";
            if (f == true)
                timer1.Start();
            else
            {
                timer1.Stop();
                StartButton.Text = "Старт";
            }
            f = !f;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            k++;
            DrawFigure1();
            Thread.Sleep(100);

        }

        private void DrawFigure1Button_Click(object sender, EventArgs e)
        {

            k = 0;
            l = 0;
            DrawFigure1();
        }

        private void ClearButton_Click(Object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {

            k += 5;
            DrawFigure1();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            k -= 5;
            DrawFigure1();
        }
        private void DownButton_Click(object sender, EventArgs e)
        {
            l -= 5;
            DrawFigure1();

        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            l += 5;
            DrawFigure1();

        }

      
    }
}
