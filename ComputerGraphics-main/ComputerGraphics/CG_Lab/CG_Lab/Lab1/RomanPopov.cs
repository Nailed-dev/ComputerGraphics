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
    public partial class RomanPopov : Form
    {
        /// <summary>
        /// Maximum length of a vector
        /// </summary>
        const int maxN = 4;

        /// <summary>
        /// Length of the vector
        /// </summary>
        int n = 0;

        /// <summary>
        /// An array of text boxes
        /// </summary>
        TextBox[] textBoxVector = null;

        /// <summary>
        /// An array of the first vector
        /// </summary>
        double[] firstVector = new double[maxN];

        /// <summary>
        /// An array of the secon vector
        /// </summary>
        double[] secondVector = new double[maxN];

        /// <summary>
        /// Bolean flags for vector inputs
        /// </summary>
        bool firstFlag;
        bool secondFlag;

        /// <summary>
        /// Sizes of the text boxes
        /// </summary>
        int dx = 70;
        int dy = 50;

        InputValue secondForm = null;

        public RomanPopov()
        {
            InitializeComponent();
        }

        private void IndividualTaskForm_Load(object sender, EventArgs e)
        {
            SizeTextBox.Text = "";
            firstFlag = secondFlag = false;
            label2.Text = "false";
            label3.Text = "false";

            secondForm = new InputValue();
            textBoxVector = new TextBox[maxN];

            for (int i = 0; i < maxN; i++)
            {
                textBoxVector[i] = new TextBox();
                textBoxVector[i].Text = "0";
                textBoxVector[i].Location = new System.Drawing.Point(dx, i * dy);
                textBoxVector[i].Size = new System.Drawing.Size(dx, dy);
                textBoxVector[i].Visible = false;
                secondForm.Controls.Add(textBoxVector[i]);
            }
        }

        /// <summary>
        /// Function that clears the text box vector
        /// </summary>
        /// <param name="n"></param>
        private void ClearVectorText(int n)
        {
            for (int i = 0; i < n; i++)
            {
                textBoxVector[i].Text = "0";
                textBoxVector[i].Visible = false;
            }
        }

        private void FirstVectorButton_Click(object sender, EventArgs e)
        {
            if (SizeTextBox.Text == "")
            {
                MessageBox.Show("Please enter dimensions for the first vector.");
                return;
            }
            if (!int.TryParse(SizeTextBox.Text, out n) || n <= 0 || n > 4)
            {
                MessageBox.Show("Please enter a valid integer for dimensions.");
                return;
            }
            else
            {
                n = int.Parse(SizeTextBox.Text);
            }

            ClearVectorText(n);

            for (int i = 0; i < n; i++)
            {
                textBoxVector[i].TabIndex = i;
                textBoxVector[i].Visible = true;
            }

            secondForm.Width = 10 + n * dx + 20;
            secondForm.Height = 70 + n * dy + secondForm.ButtonOK.Height + 100;

            secondForm.ButtonOK.Left = 10;
            secondForm.ButtonOK.Top = 10 + n * dy + 10;
            secondForm.ButtonOK.Width = secondForm.Width - 30;

            if (secondForm.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                {
                    if (textBoxVector[i].Text != "")
                    {
                        firstVector[i] = Double.Parse(textBoxVector[i].Text);
                    }
                    else
                    {
                        firstVector[i] = 0;
                    }

                }
            }
            ClearVectorText(n);
            firstFlag = true;
            label2.Text = "True";
        }

        private void SecondVectorButton_Click(object sender, EventArgs e)
        {
            if (SizeTextBox.Text == "")
            {
                MessageBox.Show("Please enter dimensions for the second vector.");
                return;
            }
            if (!int.TryParse(SizeTextBox.Text, out n) || n <= 0 || n > 4)
            {
                MessageBox.Show("Please enter a valid integer for dimensions.");
                return;
            }
            else
            {
                n = int.Parse(SizeTextBox.Text);
            }

            ClearVectorText(n);

            for (int i = 0; i < n; i++)
            {
                textBoxVector[i].TabIndex = i;
                textBoxVector[i].Visible = true;
            }

            secondForm.Width = 10 + n * dx + 20;
            secondForm.Height = 70 + n * dy + secondForm.ButtonOK.Height + 100;

            secondForm.ButtonOK.Left = 10;
            secondForm.ButtonOK.Top = 10 + n * dy + 10;
            secondForm.ButtonOK.Width = secondForm.Width - 30;

            if (secondForm.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                {
                    if (textBoxVector[i].Text != "")
                    {
                        secondVector[i] = Double.Parse(textBoxVector[i].Text);
                    }
                    else
                    {
                        secondVector[i] = 0;
                    }

                }
            }
            ClearVectorText(n);
            secondFlag = true;
            label3.Text = "True";

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (!(firstFlag && secondFlag))
            {
                MessageBox.Show("u should enter both vectors");
                return;
            }

            double result = 0;

            for (int i = 0; i < n; i++)
            {
                result += firstVector[i] * secondVector[i];
            }
            ClearVectorText(n);
            textBoxVector[0].Text = result.ToString();
            textBoxVector[0].Visible = true;

            secondForm.Width = 10 + dx + 20;
            secondForm.Height = 70 + n * dy + secondForm.ButtonOK.Height + 100;

            secondForm.ButtonOK.Left = 10;
            secondForm.ButtonOK.Top = 10 + dy + 10;
            secondForm.ButtonOK.Width = secondForm.Width - 30;

            secondForm.ShowDialog();
        }

        private void SizeTextBox_Leave(object sender, EventArgs e)
        {
            if (SizeTextBox.Text == "")
            {
                firstFlag = secondFlag = false;
                label2.Text = "false";
                label3.Text = "false";
                return;
            }
            if (!int.TryParse(SizeTextBox.Text, out int nn))
            {
                MessageBox.Show("Please enter a valid integer.");
                firstFlag = secondFlag = false;
                label2.Text = "false";
                label3.Text = "false";
                return;
            }
            if (nn <= 0)
            {
                MessageBox.Show("Please enter a valid integer.");
                firstFlag = secondFlag = false;
                label2.Text = "false";
                label3.Text = "false";
                return;
            }
            if (nn != n)
            {
                firstFlag = secondFlag = false;
                label2.Text = "false";
                label3.Text = "false";
            }
        }
    }
}
