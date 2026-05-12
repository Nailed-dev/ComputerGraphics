using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CG_Lab.Lab1;


namespace CG_Lab.Lab1
{
    public partial class MatrixCalculate : Form
    {

        const int MaxN = 4;

        int n = 0;

        TextBox[,] MatrixText = null;

        double[,] Matrix1 = new double[MaxN, MaxN];

        double[,] Matrix2 = new double[MaxN, MaxN];

        double[,] Matrix3 = new double[MaxN, MaxN];

        bool flag1;

        bool flag2;

        int dx = 70, dy = 50;

        InputValue
        form2 = null;

        public MatrixCalculate()
        {
            InitializeComponent();
        }

        private void InputMatrButton1_Click(object sender, EventArgs e)
        {
            if (SizeMatrTextBox.Text == "")
            {
                return;
            }
            if (!int.TryParse(SizeMatrTextBox.Text, out n) || n > 4 || n <= 0)
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
                }
            }
            form2.Width = 20 + n * dx + 40;
            form2.Height = 50 + n * dy + form2.ButtonOK.Height + 80;

            form2.ButtonOK.Left = 10;
            form2.ButtonOK.Top = 10 + n * dy + 10;
            form2.ButtonOK.Width = form2.Width - 30;

            if (form2.ShowDialog() == DialogResult.OK)
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
                MatrLabel1.Text = "true";
            }

        }


        private void InputMatrButton2_Click(object sender, EventArgs e)
        {
            if (SizeMatrTextBox.Text == "")
            {
                return;
            }
            if (!int.TryParse(SizeMatrTextBox.Text, out n) || n > 4 || n <= 0)
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
                }
            }
            form2.Width = 20 + n * dx + 40;
            form2.Height = 50 + n * dy + form2.ButtonOK.Height + 80;

            form2.ButtonOK.Left = 10;
            form2.ButtonOK.Top = 10 + n * dy + 10;
            form2.ButtonOK.Width = form2.Width - 30;

            if (form2.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (MatrixText[i, j].Text != "")
                        {
                            try
                            {
                                Matrix2[i, j] = Double.Parse(MatrixText[i, j].Text);
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
                flag2 = true;
                MatrLabel2.Text = "true";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SizeMatrTextBox.Text = "";
            flag1 = flag2 = false;
            MatrLabel1.Text = "false";
            MatrLabel2.Text = "false";

            int i, j;
            form2 = new InputValue();
            MatrixText = new TextBox[MaxN, MaxN];
            for (i = 0; i < MaxN; i++)
            {
                for (j = 0; j < MaxN; j++)
                {
                    MatrixText[i, j] = new TextBox();
                    MatrixText[i, j].Text = "0";
                    MatrixText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);
                    MatrixText[i, j].Size = new System.Drawing.Size(dx, dy);
                    MatrixText[i, j].Visible = false;
                    form2.Controls.Add(MatrixText[i, j]);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_Leave(object sender, EventArgs e)
        {
            int nn;

            if (SizeMatrTextBox.Text == "")
            {
                flag1 = flag2 = false;
                MatrLabel1.Text = "false";
                MatrLabel2.Text = "false";
                return;
            }
            nn = Int16.Parse(SizeMatrTextBox.Text);
            if (nn != n)
            {
                flag1 = flag2 = false;
                MatrLabel1.Text = "false";
                MatrLabel2.Text = "false";
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if (!((flag1 == true) && (flag2 == true)))
            {
                MessageBox.Show("Обе матрицы должны быть заполнены ");
                n = 0;
                return;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matrix3[j, i] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        Matrix3[j, i] = Matrix3[j, i] + Matrix1[k, i] * Matrix2[j, k];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrixText[i, j].TabIndex = i * n + j + 1;
                    MatrixText[i, j].Text = Matrix3[i, j].ToString();
                }
            }
            form2.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FileStream fw = null;
            string msg;
            byte[] msgByte = null;

            fw = new FileStream("Save.txt", FileMode.Create);

            msg = n.ToString() + "\r\n";
            msgByte = Encoding.Default.GetBytes(msg);
            fw.Write(msgByte, 0, msgByte.Length);

            msg = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    msg = msg + Matrix3[i, j].ToString() + " ";
                msg = msg + "\r\n";
            }

            msgByte = Encoding.Default.GetBytes(msg);
            fw.Write(msgByte, 0, msgByte.Length);

            if (fw != null) fw.Close();
        }

        private void DeductionButton_Click(object sender, EventArgs e)
        {
            if (!((flag1 == true) && (flag2 == true)))
            {
                MessageBox.Show("Обе матрицы должны быть заполнены ");
                n = 0;
                return;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matrix3[i, j] = Matrix1[i, j] - Matrix2[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrixText[i, j].TabIndex = i * n + j + 1;
                    MatrixText[i, j].Text = Matrix3[i, j].ToString();
                }
            }
            form2.ShowDialog();


        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            if (!((flag1 == true) && (flag2 == true)))
            {
                MessageBox.Show("Обе матрицы должны быть заполнены ");
                n = 0;
                return;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matrix3[i, j] = 0;
                    Matrix3[i, j] = Matrix1[i, j] + Matrix2[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MatrixText[i, j].TabIndex = i * n + j + 1;
                    MatrixText[i, j].Text = Matrix3[i, j].ToString();
                }
            }
            form2.ShowDialog();


        }

    }
}
