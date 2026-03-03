namespace CG_Lab
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            LabButton1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(LabButton1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1474, 829);
            panel1.TabIndex = 0;
            // 
            // LabButton1
            // 
            LabButton1.Location = new Point(581, 334);
            LabButton1.Name = "LabButton1";
            LabButton1.Size = new Size(240, 105);
            LabButton1.TabIndex = 1;
            LabButton1.Text = "Лабораторная работа №1";
            LabButton1.UseVisualStyleBackColor = true;
            LabButton1.Click += LabButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 160);
            label1.TabIndex = 5;
            label1.Text = "Группа 514-1:\r\nЗемлянский Артемий\r\nСучилин Андрей\r\nПопов Роман \r\nДубров Олег \r\n";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 829);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Компьютерная графика";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button LabButton1;
    }
}
