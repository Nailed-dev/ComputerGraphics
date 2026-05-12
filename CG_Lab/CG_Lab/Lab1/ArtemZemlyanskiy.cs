using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CG_Lab.Lab1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CG_Lab.Lab1
{
    public partial class ArtemZemlyanskiy : Form
    {

        const int MaxN = 4; // максимально допустимая размерность матрицы
        const int VectorSize = 3; // вектор всегда размером 3

        int n = 0; // текущая размерность матрицы

        System.Windows.Forms.TextBox[,] MatrixText = null; // матрица элементов типа TextBox

        double[,] Matrix1 = new double[MaxN, MaxN]; // матрица 1 чисел с плавающей точкой

        double[,] Vector = new double[1, VectorSize]; // вектор для операций (всегда 3 элемента)

        double[,] VectorResult = new double[1, VectorSize]; // вектор результатов

        double constant = 1.0; // константа для умножения

        bool flag1; // флажок, который указывает о вводе данных в матрицу Matrix1

        bool flagVector; // флажок, который указывает о вводе данных в вектор

        int dx = 70, dy = 50; // ширина и высота ячейки в MatrText[,]

        InputValue inputValue = null; // экземпляр (объект) класса формы InputValue

        public ArtemZemlyanskiy()
        {
            InitializeComponent();
        }

        private void MatrixButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            if (!int.TryParse(textBox1.Text, out n) || n > 4 || n <= 0)
            {
                MessageBox.Show("Введите корректное число!");
                return;
            }

            MatrixClearText();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrixText[i, j].TabIndex = i * n + j + 1;
                    MatrixText[i, j].Visible = true;
                    if (flag1)
                    {
                        MatrixText[i, j].Text = Matrix1[i, j].ToString();
                    }
                }
            }
            inputValue.Width = 10 + n * dx + 20;
            inputValue.Height = 10 + n * dy + inputValue.ButtonOK.Height + 50;

            inputValue.ButtonOK.Left = 10;
            inputValue.ButtonOK.Top = 10 + n * dy + 10;
            inputValue.ButtonOK.Width = inputValue.Width - 30;

            inputValue.Text = "Ввод матрицы";

            if (inputValue.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (MatrixText[i, j].Text != "")
                        {
                            try
                            {
                                Matrix1[i, j] = Double.Parse(MatrixText[i, j].Text);
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Некорректное значение в ячейке!");
                                return;
                            }
                        }
                        else
                        {
                            Matrix1[i, j] = 0;
                        }
                    }
                }
                flag1 = true;
                label2.Text = "true";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            flag1 = flagVector = false;
            label2.Text = "false";
            label3.Text = "false";

            int i, j;
            inputValue = new InputValue();
            MatrixText = new System.Windows.Forms.TextBox[MaxN, MaxN];
            for (i = 0; i < MaxN; i++)
            {
                for (j = 0; j < MaxN; j++)
                {
                    MatrixText[i, j] = new System.Windows.Forms.TextBox();
                    MatrixText[i, j].Text = "0";
                    MatrixText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);
                    MatrixText[i, j].Size = new System.Drawing.Size(dx, dy);
                    MatrixText[i, j].Visible = false;
                    inputValue.Controls.Add(MatrixText[i, j]);
                }
            }
        }

        private void MatrixClearText()
        {
            for (int i = 0; i < MaxN; i++)
            {
                for (int j = 0; j < MaxN; j++)
                {
                    MatrixText[i, j].Text = "0";
                    MatrixText[i, j].Visible = false;
                }
            }
        }

        private void VectorButton_Click(object sender, EventArgs e)
        {
            MatrixClearText();

            // Показываем 3 поля для ввода вектора
            for (int i = 0; i < VectorSize; i++)
            {
                MatrixText[0, i].TabIndex = i;
                MatrixText[0, i].Visible = true;
                if (flagVector)
                {
                    MatrixText[0, i].Text = Vector[0, i].ToString();
                }
            }

            // Настройка размеров формы для вектора (3 элемента)
            inputValue.Width = 10 + VectorSize * dx + 20;
            inputValue.Height = 70 + 1 * dy + inputValue.ButtonOK.Height + 100;

            inputValue.ButtonOK.Left = 10;
            inputValue.ButtonOK.Top = 10 + 1 * dy + 10;
            inputValue.ButtonOK.Width = inputValue.Width - 30;

            inputValue.Text = "Ввод вектора";

            if (inputValue.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < VectorSize; i++)
                {
                    if (MatrixText[0, i].Text != "")
                    {
                        try
                        {
                            Vector[0, i] = Double.Parse(MatrixText[0, i].Text);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Некорректное значение в ячейке!");
                            return;
                        }
                    }
                    else
                    {
                        Vector[0, i] = 0;
                    }
                }
                flagVector = true;
                label3.Text = "true";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // Ничего не делаем - вектор не зависит от textBox1
        }

        private void TranspButton_Click(object sender, EventArgs e)
        {
            if (!(flag1 == true))
            {
                MessageBox.Show("Матрица должна быть заполнена!");
                return;
            }

            double[,] transposedMatrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    transposedMatrix[j, i] = Matrix1[i, j];
                }
            }

            MatrixClearText();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrixText[i, j].Visible = true;
                    MatrixText[i, j].Text = transposedMatrix[i, j].ToString();
                }
            }

            inputValue.Width = 10 + n * dx + 20;
            inputValue.Height = 10 + n * dy + inputValue.ButtonOK.Height + 50;
            inputValue.ButtonOK.Left = 10;
            inputValue.ButtonOK.Top = 10 + n * dy + 10;
            inputValue.ButtonOK.Width = inputValue.Width - 30;
            inputValue.Text = "Транспонированная матрица";

            inputValue.ShowDialog();
        }

        private void ConstButton_Click(object sender, EventArgs e)
        {
            // Скрываем все ячейки
            for (int i = 0; i < MaxN; i++)
            {
                for (int j = 0; j < MaxN; j++)
                {
                    MatrixText[i, j].Visible = false;
                }
            }

            // Показываем только одно поле для ввода константы
            MatrixText[0, 0].Visible = true;
            MatrixText[0, 0].TabIndex = 1;
            MatrixText[0, 0].Text = "0";
            MatrixText[0, 0].BackColor = Color.White;

            // Настройка размеров формы для одного поля
            inputValue.Width = 10 + 1 * dx + 20;
            inputValue.Height = 50 + 1 * dy + inputValue.ButtonOK.Height + 80;

            inputValue.ButtonOK.Left = 10;
            inputValue.ButtonOK.Top = 10 + 1 * dy + 10;
            inputValue.ButtonOK.Width = inputValue.Width - 30;

            inputValue.Text = "Ввод константы";

            if (inputValue.ShowDialog() == DialogResult.OK)
            {
                if (MatrixText[0, 0].Text != "")
                {
                    try
                    {
                        constant = Double.Parse(MatrixText[0, 0].Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Некорректное значение константы!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (!(flagVector == true))
            {
                MessageBox.Show("Вектор должен быть заполнен!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Умножение вектора на константу
            for (int i = 0; i < VectorSize; i++)
            {
                VectorResult[0, i] = Vector[0, i] * constant;
            }

            // Отображение результата
            ShowResultInInputValue();
        }

        private void ShowResultInInputValue()
        {
            // Скрываем все ячейки
            for (int i = 0; i < MaxN; i++)
            {
                for (int j = 0; j < MaxN; j++)
                {
                    MatrixText[i, j].Visible = false;
                }
            }

            // Показываем только вектор-результат
            for (int i = 0; i < VectorSize; i++)
            {
                MatrixText[0, i].Visible = true;
                MatrixText[0, i].TabIndex = i;
                MatrixText[0, i].Text = VectorResult[0, i].ToString();
                MatrixText[0, i].BackColor = Color.White;
            }

            // Настройка размеров формы для вектора
            inputValue.Width = 10 + VectorSize * dx + 20;
            inputValue.Height = 70 + 1 * dy + inputValue.ButtonOK.Height + 120;

            inputValue.ButtonOK.Left = 10;
            inputValue.ButtonOK.Top = 10 + 1 * dy + 10;
            inputValue.ButtonOK.Width = inputValue.Width - 30;

            inputValue.Text = $"Результат умножения на {constant}";
            inputValue.ShowDialog();
        }
    }
}