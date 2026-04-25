namespace CG_Lab.Lab1
{
    partial class OlegDubrov
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
            button1 = new Button();
            button7 = new Button();
            label2 = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 53);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 0;
            label1.Text = "n=";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(176, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(117, 142);
            button1.Name = "button1";
            button1.Size = new Size(252, 104);
            button1.TabIndex = 2;
            button1.Text = "Ввод матрицы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(117, 277);
            button7.Name = "button7";
            button7.Size = new Size(252, 104);
            button7.TabIndex = 3;
            button7.Text = "Константа";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonMultiplyByConstant_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 178);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button8
            // 
            button8.Location = new Point(117, 425);
            button8.Name = "button8";
            button8.Size = new Size(252, 104);
            button8.TabIndex = 5;
            button8.Text = "Вектор";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonCalculateVectorMagnitude_Click;
            // 
            // OlegDubrov
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 889);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "OlegDubrov";
            Text = "Умножение матрицы на константу и модуль вектора";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button7;
        private Label label2;
        private Button button8;
    }
}