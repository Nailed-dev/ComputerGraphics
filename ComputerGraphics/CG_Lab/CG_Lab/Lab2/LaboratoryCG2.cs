using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CG_Lab.Lab2
{
    public partial class LaboratoryCG2 : Form
    {
        public int xn, yn, xk, yk;
        Bitmap myBitmap;
        Color currentBorderColor;
        Color currentFillColor;

        public LaboratoryCG2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (CDARadioButton.Checked == true)
            {
                xn = e.X;
                yn = e.Y;
            }

            else MessageBox.Show("Вы не выбрали алгоритм вывода фигуры!");
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            int index, numberNodes;
            double xOutput, yOutput, dx, dy;




            Graphics g = Graphics.FromHwnd(PictureBox.Handle);

            xk = e.X;
            yk = e.Y;
            dx = xk - xn;
            dy = yk - yn;
            numberNodes = 200;
            xOutput = xn;
            yOutput = yn;
            for (index = 1; index <= numberNodes; index++)
            {
                if (ThicknessCheckedBox.Checked == false)
                {
                    Pen myPen = new Pen(currentBorderColor, 1);
                    g.DrawRectangle(myPen, (int)xOutput, (int)yOutput, 2, 2);

                    xOutput = xOutput + dx / numberNodes;
                    yOutput = yOutput + dy / numberNodes;
                }
                else
                {
                    Pen myPen = new Pen(currentBorderColor, 1);

                    g.DrawRectangle(myPen, (int)xOutput, (int)yOutput, 2, 2);
                    g.DrawRectangle(myPen, (int)xOutput + 1, (int)yOutput, 2, 2);
                    g.DrawRectangle(myPen, (int)xOutput, (int)yOutput + 1, 2, 2);
                    g.DrawRectangle(myPen, (int)xOutput, (int)yOutput - 1, 2, 2);
                    g.DrawRectangle(myPen, (int)xOutput - 1, (int)yOutput, 2, 2);
                    g.DrawRectangle(myPen, (int)xOutput - 1, (int)yOutput + 1, 2, 2);
                    g.DrawRectangle(myPen, (int)xOutput - 1, (int)yOutput - 1, 2, 2);
                    g.DrawRectangle(myPen, (int)xOutput + 1, (int)yOutput + 1, 2, 2);
                    g.DrawRectangle(myPen, (int)xOutput + 1, (int)yOutput - 1, 2, 2);
                    xOutput = xOutput + dx / numberNodes;
                    yOutput = yOutput + dy / numberNodes;
                }
            }
        }

        private void CDA(int xStart, int yStart, int xEnd, int yEnd)
        {
            int index, numberNodes;
            double xOutput, yOutput, dx, dy;

            xn = xStart;
            yn = yStart;
            xk = xEnd;
            yk = yEnd;
            dx = xk - xn;
            dy = yk - yn;
            numberNodes = 200;
            xOutput = xn;
            yOutput = yn;
            for (index = 1; index <= numberNodes; index++)
            {
                myBitmap.SetPixel((int)xOutput, (int)yOutput,
               currentBorderColor);
                xOutput = xOutput + dx / numberNodes;
                yOutput = yOutput + dy / numberNodes;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
        }



        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            //отключаем кнопки
            ClearButton.Enabled = false;
            ColorLineButton.Enabled = false;
            //создаем новый экземпляр Bitmap размером с элемент
            //pictureBox1 (myBitmap)
            //на нем выводим попиксельно отрезок
            myBitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            using (Graphics g = Graphics.FromHwnd(PictureBox.Handle))
            {
                if (CDARadioButton.Checked == true)
                {
                    //рисуем прямоугольник
                    CDA(10, 10, 10, 110);
                    CDA(10, 10, 110, 10);
                    CDA(10, 110, 110, 110);
                    CDA(110, 10, 110, 110);
                    //рисуем треугольник
                    CDA(150, 10, 150, 200);
                    CDA(250, 50, 150, 200);
                    CDA(150, 10, 250, 150);
                }
                else
                {
                    if (FillRadioButton.Checked == true)
                    {
                        //получаем растр созданного рисунка в mybitmap
                        myBitmap = PictureBox.Image as Bitmap;

                        // задаем координаты затравки
                        xn = 160;
                        yn = 40;
                        // вызываем рекурсивную процедуру заливки с затравкой
                        FloodFill(xn, yn);
                    }
                }
                //передаем полученный растр mybitmap в элемент pictureBox
                PictureBox.Image = myBitmap;


                // обновляем pictureBox и активируем кнопки
                PictureBox.Refresh();
                ClearButton.Enabled = true;
                ColorLineButton.Enabled = true;
            }
        }



        private void FloodFill(int x1, int y1)
        {
            // получаем цвет текущего пикселя с координатами x1, y1
            Color oldPixelColor = myBitmap.GetPixel(x1, y1);
            // сравнение цветов происходит в формате RGB
            // для этого используем метод ToArgb объекта Color
            if ((oldPixelColor.ToArgb() != currentBorderColor.ToArgb())
                && (oldPixelColor.ToArgb() != currentFillColor.ToArgb()))
            {
                //перекрашиваем пиксель
                myBitmap.SetPixel(x1, y1, currentFillColor);

                //вызываем метод для 4-х соседних пикселей
                FloodFill(x1 + 1, y1);
                FloodFill(x1 - 1, y1);
                FloodFill(x1, y1 + 1);
                FloodFill(x1, y1 - 1);
            }
            else
            {
                //выходим из метода
                return;
            }

        }

        private void ColorFillButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog2.ShowDialog();
            if (dialogResult == DialogResult.OK && CDARadioButton.Checked)
            {
                currentFillColor = colorDialog2.Color;
            }
        }

        private void ColorLineButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog2.ShowDialog();
            if (dialogResult == DialogResult.OK && CDARadioButton.Checked)
            {
                currentBorderColor = colorDialog1.Color;
            }
        }
    }


}
