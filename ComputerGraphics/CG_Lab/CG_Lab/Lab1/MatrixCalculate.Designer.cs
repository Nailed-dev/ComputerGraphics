namespace CG_Lab.Lab1
{
    partial class MatrixCalculate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            SizeMatrTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SizeMatrTextBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 782);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 22);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 0;
            label1.Text = "n=";
            // 
            // SizeMatrTextBox
            // 
            SizeMatrTextBox.BorderStyle = BorderStyle.FixedSingle;
            SizeMatrTextBox.Location = new Point(97, 20);
            SizeMatrTextBox.Name = "SizeMatrTextBox";
            SizeMatrTextBox.Size = new Size(200, 39);
            SizeMatrTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(56, 83);
            button1.Name = "button1";
            button1.Size = new Size(250, 46);
            button1.TabIndex = 2;
            button1.Text = "Ввод матрицы 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(56, 161);
            button2.Name = "button2";
            button2.Size = new Size(250, 46);
            button2.TabIndex = 3;
            button2.Text = "Ввод матрицы 2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 90);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 168);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // button4
            // 
            button4.Location = new Point(254, 282);
            button4.Name = "button4";
            button4.Size = new Size(348, 74);
            button4.TabIndex = 7;
            button4.Text = "Резульат умножения";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(254, 382);
            button3.Name = "button3";
            button3.Size = new Size(348, 74);
            button3.TabIndex = 8;
            button3.Text = "Резульат вычитания";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(254, 485);
            button5.Name = "button5";
            button5.Size = new Size(348, 74);
            button5.TabIndex = 9;
            button5.Text = "Резульат сложения";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(292, 588);
            button6.Name = "button6";
            button6.Size = new Size(260, 100);
            button6.TabIndex = 10;
            button6.Text = "Сохранить в файле \r\n\"Res_Matr.txt\"";
            button6.UseVisualStyleBackColor = true;
            // 
            // MatrixCalculate
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 782);
            Controls.Add(panel1);
            Name = "MatrixCalculate";
            Text = "MatrixCalculate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox SizeMatrTextBox;
        private Label label1;
    }
}