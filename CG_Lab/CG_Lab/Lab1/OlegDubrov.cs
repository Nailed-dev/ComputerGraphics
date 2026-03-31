using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab.Lab1
{
    public partial class OlegDubrov : Form
    {
        const int MaxN = 4;
        int n = 3;
        TextBox[,] MatrText = null;
        double[,] Matr1 = new double[MaxN, MaxN];
        double[,] Matr2 = new double[MaxN, MaxN];
        double[,] Matr3 = new double[MaxN, MaxN];
        bool flag1;
        bool flag2;
        int dx = 70, dy = 50;
        InputValue form3 = null;

        public OlegDubrov()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            flag1 = flag2 = false;
            label2.Text = "false";

            int i, j;
            form3 = new InputValue();
            MatrText = new TextBox[MaxN, MaxN];
            for (i = 0; i < MaxN; i++)
            {
                for (j = 0; j < MaxN; j++)
                {
                    MatrText[i, j] = new TextBox();
                    MatrText[i, j].Text = "0";
                    MatrText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);
                    MatrText[i, j].Size = new System.Drawing.Size(dx, dy);
                    MatrText[i, j].Visible = false;
                    form3.Controls.Add(MatrText[i, j]);
                }
            }
        }

        private void Clear_MatrText()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrText[i, j].Text = "0";
                    MatrText[i, j].Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

            Clear_MatrText();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrText[i, j].TabIndex = i * n + j + 1;
                    MatrText[i, j].Visible = true;
                }
            }
            form3.Width = 10 + n * dx + 20;
            form3.Height = 70 + n * dy + form3.ButtonOK.Height + 120;
            form3.ButtonOK.Left = 10;
            form3.ButtonOK.Top = 10 + n * dy + 10;
            form3.ButtonOK.Width = form3.Width - 30;

            if (form3.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (MatrText[i, j].Text != "")
                        {
                            try
                            {
                                Matr1[i, j] = Double.Parse(MatrText[i, j].Text);
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Некорректное значение в ячейке!");
                                return;
                            }
                        }
                        else
                        {
                            Matr1[i, j] = 0;
                        }
                    }
                }
                flag1 = true;
                label2.Text = "true";
            }

        }

        private void buttonMultiplyByConstant_Click(object sender, EventArgs e)
        {
            if (!flag1)
            {
                MessageBox.Show("Матрица должна быть заполнена");
                return;
            }
            string constantInput = Microsoft.VisualBasic.Interaction.InputBox("Введите константу:",
                "Умножение матрицы на константу", "1");
            if (!double.TryParse(constantInput, out double constant))
            {
                MessageBox.Show("Введите корректное число для константы");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matr3[i, j] = Matr1[i, j] * constant;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrText[i, j].TabIndex = i * n + j + 1;

                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }
            }
            form3.ShowDialog();
        }

        private void buttonCalculateVectorMagnitude_Click(object sender, EventArgs e)
        {
            if (!flag1)
            {
                MessageBox.Show("Вектор должен быть заполнен");
                return;
            }

            double sumOfSquares = 0;

            for (int i = 0; i < n; i++)
            {
                sumOfSquares += Matr1[i, 0] * Matr1[i, 0];
            }

            double magnitude = Math.Sqrt(sumOfSquares);

            MessageBox.Show($"Модуль вектора: {magnitude.ToString("F2")}", "Результат");
        }

    }
}
