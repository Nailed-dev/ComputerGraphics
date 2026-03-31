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
            label2 = new Label();
            label1 = new Label();
            LabButton4 = new Button();
            LabButton3 = new Button();
            LabButton2 = new Button();
            pictureBox1 = new PictureBox();
            LabButton1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LabButton4);
            panel1.Controls.Add(LabButton3);
            panel1.Controls.Add(LabButton2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LabButton1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1276, 958);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 535);
            label2.Name = "label2";
            label2.Size = new Size(258, 128);
            label2.TabIndex = 11;
            label2.Text = "Сучилин Андрей \r\nПопов Роман \r\nЗемлянский Артемий \r\nДубров Олег\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(144, 494);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 10;
            label1.Text = "Группа 514-1";
            // 
            // LabButton4
            // 
            LabButton4.Location = new Point(566, 841);
            LabButton4.Name = "LabButton4";
            LabButton4.Size = new Size(669, 105);
            LabButton4.TabIndex = 9;
            LabButton4.Text = "Лабораторная работа №4\r\n\r\n";
            LabButton4.UseVisualStyleBackColor = true;
            // 
            // LabButton3
            // 
            LabButton3.Location = new Point(566, 711);
            LabButton3.Name = "LabButton3";
            LabButton3.Size = new Size(669, 105);
            LabButton3.TabIndex = 8;
            LabButton3.Text = "Лабораторная работа №3\r\n";
            LabButton3.UseVisualStyleBackColor = true;
            // 
            // LabButton2
            // 
            LabButton2.Location = new Point(566, 584);
            LabButton2.Name = "LabButton2";
            LabButton2.Size = new Size(669, 105);
            LabButton2.TabIndex = 7;
            LabButton2.Text = "Лабораторная работа №2\r\n";
            LabButton2.UseVisualStyleBackColor = true;
            LabButton2.Click += LabButton2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cover;
            pictureBox1.Location = new Point(7, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1266, 420);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LabButton1
            // 
            LabButton1.Location = new Point(566, 458);
            LabButton1.Name = "LabButton1";
            LabButton1.Size = new Size(669, 105);
            LabButton1.TabIndex = 1;
            LabButton1.Text = "Лабораторная работа №1";
            LabButton1.UseVisualStyleBackColor = true;
            LabButton1.Click += LabButton1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 958);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Компьютерная графика";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button LabButton1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button LabButton4;
        private Button LabButton3;
        private Button LabButton2;
    }
}
