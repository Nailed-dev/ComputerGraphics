namespace CG_Lab.Lab1
{
    partial class RomanPopov
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
            SizeTextBox = new TextBox();
            FirstVectorButton = new Button();
            SecondVectorButton = new Button();
            ResultButton = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 51);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 0;
            label1.Text = "n=";
            // 
            // SizeTextBox
            // 
            SizeTextBox.Location = new Point(112, 48);
            SizeTextBox.Name = "SizeTextBox";
            SizeTextBox.Size = new Size(200, 39);
            SizeTextBox.TabIndex = 1;
            // 
            // FirstVectorButton
            // 
            FirstVectorButton.Location = new Point(49, 117);
            FirstVectorButton.Name = "FirstVectorButton";
            FirstVectorButton.Size = new Size(213, 74);
            FirstVectorButton.TabIndex = 2;
            FirstVectorButton.Text = "Первый вектор";
            FirstVectorButton.UseVisualStyleBackColor = true;
            FirstVectorButton.Click += FirstVectorButton_Click;
            // 
            // SecondVectorButton
            // 
            SecondVectorButton.Location = new Point(49, 209);
            SecondVectorButton.Name = "SecondVectorButton";
            SecondVectorButton.Size = new Size(213, 74);
            SecondVectorButton.TabIndex = 3;
            SecondVectorButton.Text = "Второй вектор";
            SecondVectorButton.UseVisualStyleBackColor = true;
            SecondVectorButton.Click += SecondVectorButton_Click;
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(519, 246);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(213, 74);
            ResultButton.TabIndex = 4;
            ResultButton.Text = "Скалярное произведение";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 138);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 230);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // RomanPopov
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ResultButton);
            Controls.Add(SecondVectorButton);
            Controls.Add(FirstVectorButton);
            Controls.Add(SizeTextBox);
            Controls.Add(label1);
            Name = "RomanPopov";
            Text = "Скалярное произведение";
            Load += IndividualTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SizeTextBox;
        private Button FirstVectorButton;
        private Button SecondVectorButton;
        private Button ResultButton;
        private Label label2;
        private Label label3;
    }
}