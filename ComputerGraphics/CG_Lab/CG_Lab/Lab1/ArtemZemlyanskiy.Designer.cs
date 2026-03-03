namespace CG_Lab.Lab1
{
    partial class ArtemZemlyanskiy
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
            label1 = new Label();
            textBox1 = new TextBox();
            MatrixButton = new Button();
            TranspButton = new Button();
            label2 = new Label();
            label3 = new Label();
            VectorButton = new Button();
            ConstButton = new Button();
            MultiplyButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 69);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 0;
            label1.Text = "n=";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(183, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            // 
            // MatrixButton
            // 
            MatrixButton.Location = new Point(133, 153);
            MatrixButton.Name = "MatrixButton";
            MatrixButton.Size = new Size(278, 104);
            MatrixButton.TabIndex = 2;
            MatrixButton.Text = "Ввод матрицы ";
            MatrixButton.UseVisualStyleBackColor = true;
            MatrixButton.Click += MatrixButton_Click;
            // 
            // TranspButton
            // 
            TranspButton.Location = new Point(133, 275);
            TranspButton.Name = "TranspButton";
            TranspButton.Size = new Size(278, 104);
            TranspButton.TabIndex = 3;
            TranspButton.Text = "Транспонирование";
            TranspButton.UseVisualStyleBackColor = true;
            TranspButton.Click += TranspButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 189);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 448);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 12;
            label3.Text = "label3";
            // 
            // VectorButton
            // 
            VectorButton.Location = new Point(133, 412);
            VectorButton.Name = "VectorButton";
            VectorButton.Size = new Size(278, 104);
            VectorButton.TabIndex = 13;
            VectorButton.Text = "Ввод вектора";
            VectorButton.UseVisualStyleBackColor = true;
            VectorButton.Click += VectorButton_Click;
            // 
            // ConstButton
            // 
            ConstButton.Location = new Point(133, 560);
            ConstButton.Name = "ConstButton";
            ConstButton.Size = new Size(278, 104);
            ConstButton.TabIndex = 14;
            ConstButton.Text = "Ввод константы";
            ConstButton.UseVisualStyleBackColor = true;
            ConstButton.Click += ConstButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.Location = new Point(506, 560);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(278, 104);
            MultiplyButton.TabIndex = 15;
            MultiplyButton.Text = "Умножение вектора на константу";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // ArtemZemlyanskiy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 808);
            Controls.Add(MultiplyButton);
            Controls.Add(ConstButton);
            Controls.Add(VectorButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TranspButton);
            Controls.Add(MatrixButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ArtemZemlyanskiy";
            Text = "ArtemZemlyanskiy";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button MatrixButton;
        private Button TranspButton;
        private Label label2;
        private Label label3;
        private Button VectorButton;
        private Button ConstButton;
        private Button MultiplyButton;
    }
}