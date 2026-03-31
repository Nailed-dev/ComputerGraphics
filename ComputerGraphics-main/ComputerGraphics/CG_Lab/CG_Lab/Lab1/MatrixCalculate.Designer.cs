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
            SaveButton = new Button();
            AdditionButton = new Button();
            DeductionButton = new Button();
            MultiplicationButton = new Button();
            MatrLabel2 = new Label();
            MatrLabel1 = new Label();
            InputMatrButton2 = new Button();
            InputMatrButton1 = new Button();
            SizeMatrTextBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(AdditionButton);
            panel1.Controls.Add(DeductionButton);
            panel1.Controls.Add(MultiplicationButton);
            panel1.Controls.Add(MatrLabel2);
            panel1.Controls.Add(MatrLabel1);
            panel1.Controls.Add(InputMatrButton2);
            panel1.Controls.Add(InputMatrButton1);
            panel1.Controls.Add(SizeMatrTextBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 782);
            panel1.TabIndex = 0;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(292, 588);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(260, 100);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Сохранить в файле \r\n\"Res_Matr.txt\"";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AdditionButton
            // 
            AdditionButton.Location = new Point(254, 485);
            AdditionButton.Name = "AdditionButton";
            AdditionButton.Size = new Size(348, 74);
            AdditionButton.TabIndex = 9;
            AdditionButton.Text = "Резульат сложения";
            AdditionButton.UseVisualStyleBackColor = true;
            AdditionButton.Click += AdditionButton_Click;
            // 
            // DeductionButton
            // 
            DeductionButton.Location = new Point(254, 382);
            DeductionButton.Name = "DeductionButton";
            DeductionButton.Size = new Size(348, 74);
            DeductionButton.TabIndex = 8;
            DeductionButton.Text = "Резульат вычитания";
            DeductionButton.UseVisualStyleBackColor = true;
            DeductionButton.Click += DeductionButton_Click;
            // 
            // MultiplicationButton
            // 
            MultiplicationButton.Location = new Point(254, 282);
            MultiplicationButton.Name = "MultiplicationButton";
            MultiplicationButton.Size = new Size(348, 74);
            MultiplicationButton.TabIndex = 7;
            MultiplicationButton.Text = "Результат умножения";
            MultiplicationButton.UseVisualStyleBackColor = true;
            MultiplicationButton.Click += MultiplicationButton_Click;
            // 
            // MatrLabel2
            // 
            MatrLabel2.AutoSize = true;
            MatrLabel2.Location = new Point(323, 168);
            MatrLabel2.Name = "MatrLabel2";
            MatrLabel2.Size = new Size(78, 32);
            MatrLabel2.TabIndex = 6;
            MatrLabel2.Text = "label3";
            // 
            // MatrLabel1
            // 
            MatrLabel1.AutoSize = true;
            MatrLabel1.Location = new Point(323, 90);
            MatrLabel1.Name = "MatrLabel1";
            MatrLabel1.Size = new Size(78, 32);
            MatrLabel1.TabIndex = 5;
            MatrLabel1.Text = "label2";
            // 
            // InputMatrButton2
            // 
            InputMatrButton2.Location = new Point(56, 161);
            InputMatrButton2.Name = "InputMatrButton2";
            InputMatrButton2.Size = new Size(250, 46);
            InputMatrButton2.TabIndex = 3;
            InputMatrButton2.Text = "Ввод матрицы 2";
            InputMatrButton2.UseVisualStyleBackColor = true;
            InputMatrButton2.Click += InputMatrButton2_Click;
            // 
            // InputMatrButton1
            // 
            InputMatrButton1.Location = new Point(56, 83);
            InputMatrButton1.Name = "InputMatrButton1";
            InputMatrButton1.Size = new Size(250, 46);
            InputMatrButton1.TabIndex = 2;
            InputMatrButton1.Text = "Ввод матрицы 1";
            InputMatrButton1.UseVisualStyleBackColor = true;
            InputMatrButton1.Click += InputMatrButton1_Click;
            // 
            // SizeMatrTextBox
            // 
            SizeMatrTextBox.BorderStyle = BorderStyle.FixedSingle;
            SizeMatrTextBox.Location = new Point(97, 20);
            SizeMatrTextBox.Name = "SizeMatrTextBox";
            SizeMatrTextBox.Size = new Size(200, 39);
            SizeMatrTextBox.TabIndex = 1;
            SizeMatrTextBox.Leave += textBox1_Leave;
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
            // MatrixCalculate
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 782);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "MatrixCalculate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Произведение матриц";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button SaveButton;
        private Button AdditionButton;
        private Button DeductionButton;
        private Button MultiplicationButton;
        private Label MatrLabel2;
        private Label MatrLabel1;
        private Button InputMatrButton2;
        private Button InputMatrButton1;
        private TextBox SizeMatrTextBox;
        private Label label1;
    }
}