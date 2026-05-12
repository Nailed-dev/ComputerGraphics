using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab.Lab1
{
    public partial class AndreySuchilin : Form
    {
        System.Windows.Forms.TextBox[,] MatrixText = null; // матрица элементов типа TextBox

        double[,] Matrix1 = new double[1, 3]; // матрица 1 чисел с плавающей точкой

        double[,] Matrix2 = new double[1, 3]; // матрица 2 чисел с плавающей точкой

        double[,] Matrix3 = new double[1, 3]; // матрица результатов

        bool flag1; // флажок, который указывает о вводе данных в матрицу Matrix1

        bool flag2; // флажок, который указывает о вводе данных в матрицу Matrix2

        int dx = 70, dy = 50; // ширина и высота ячейки в MatrText[,]

        InputValue inputValue = null; // экземпляр (объект) класса формы Form2

        public AndreySuchilin()
        {
            InitializeComponent();

        }

        private void InputVectorButton1_Click(object sender, EventArgs e)
        {
            MatrixClearText();
            for (int i = 0; i < 3; i++)
            {

                MatrixText[0, i].TabIndex = i;
                MatrixText[0, i].Visible = true;

            }
            inputValue.Width = 10 + 3 * dx + 20;
            inputValue.Height = 10 + 3 * dy + inputValue.ButtonOK.Height + 50;

            inputValue.ButtonOK.Left = 10;
            inputValue.ButtonOK.Top = 10 + 3 * dy + 10;
            inputValue.ButtonOK.Width = inputValue.Width - 30;

            if (inputValue.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (MatrixText[0, i].Text != "")
                    {
                        try
                        {
                            Matrix1[0, i] = Double.Parse(MatrixText[0, i].Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Некорректное значение в ячейке!");
                            return;
                        }
                    }
                    else
                    {
                        Matrix1[0, i] = 0;
                    }
                }
                flag1 = true;
                label1.Text = "true";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InputVectorButton2_Click(object sender, EventArgs e)
        {
            MatrixClearText();
            for (int i = 0; i < 3; i++)
            {

                MatrixText[0, i].TabIndex = i;
                MatrixText[0, i].Visible = true;

            }
            inputValue.Width = 10 + 3 * dx + 20;
            inputValue.Height = 10 + 3 * dy + inputValue.ButtonOK.Height + 50;

            inputValue.ButtonOK.Left = 10;
            inputValue.ButtonOK.Top = 10 + 3 * dy + 10;
            inputValue.ButtonOK.Width = inputValue.Width - 30;

            if (inputValue.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (MatrixText[0, i].Text != "")
                    {
                        try
                        {
                            Matrix2[0, i] = Double.Parse(MatrixText[0, i].Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Некорректное значение в ячейке!");
                            return;
                        }
                    }
                    else
                    {
                        Matrix2[0, i] = 0;
                    }
                }
                flag2 = true;
                label2.Text = "true";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VectorProduct_Load(object sender, EventArgs e)
        {
            flag1 = flag2 = false;
            label1.Text = "false";
            label2.Text = "false";

            int i, j;
            inputValue = new InputValue();
            MatrixText = new System.Windows.Forms.TextBox[1, 3];
            for (j = 0; j < 3; j++)
            {
                MatrixText[0, j] = new System.Windows.Forms.TextBox();
                MatrixText[0, j].Text = "0";
                MatrixText[0, j].Location = new System.Drawing.Point(10 + 0 * dx, 10 + j * dy);
                MatrixText[0, j].Size = new System.Drawing.Size(dx, dy);
                MatrixText[0, j].Visible = false;
                inputValue.Controls.Add(MatrixText[0, j]);
            }

        }

        private void MatrixClearText()
        {
            for (int i = 0; i < 3; i++)
            {
                MatrixText[0, i].Text = "0";
                MatrixText[0, i].Visible = false;
            }
        }

        private void ResultProductOfVectors_Click(object sender, EventArgs e)
        {
            if (!((flag1 == true) && (flag2 == true)))
            {
                MessageBox.Show("Векторы должны быть заполнены ");
                return;
            }

            if (Matrix3 == null || Matrix3.GetLength(0) < 1 || Matrix3.GetLength(1) < 3)
            {
                Matrix3 = new double[1, 3];
            }
            Matrix3[0, 0] = (Matrix1[0, 1] * Matrix2[0, 2] - Matrix2[0, 1] * Matrix1[0, 2]);
            Matrix3[0, 1] = (Matrix1[0, 2] * Matrix2[0, 0] - Matrix2[0, 2] * Matrix1[0, 0]);
            Matrix3[0, 2] = (Matrix1[0, 0] * Matrix2[0, 1] - Matrix2[0, 0] * Matrix1[0, 1]);

            for (int i = 0; i < 3; i++)
            {
                if (MatrixText[0, i] != null)
                {
                    MatrixText[0, i].TabIndex = i;
                    MatrixText[0, i].Text = Matrix3[0, i].ToString();
                }
            }
            if (inputValue != null)
            {
                inputValue.ShowDialog();
            }
        }
    }
}
