namespace CG_Lab.Lab3
{
    partial class LaboratoryCG3
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            StartButton = new Button();
            DrawFigure4Button = new Button();
            DrawFigure3Button = new Button();
            DrawFigure2Button = new Button();
            UpButton = new Button();
            DownButton = new Button();
            LeftButton = new Button();
            RightButton = new Button();
            label1 = new Label();
            ClearButton = new Button();
            DrawFigure1Button = new Button();
            DrawOsiButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1456, 1121);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(867, 1115);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(StartButton);
            panel1.Controls.Add(DrawFigure4Button);
            panel1.Controls.Add(DrawFigure3Button);
            panel1.Controls.Add(DrawFigure2Button);
            panel1.Controls.Add(UpButton);
            panel1.Controls.Add(DownButton);
            panel1.Controls.Add(LeftButton);
            panel1.Controls.Add(RightButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(DrawFigure1Button);
            panel1.Controls.Add(DrawOsiButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(876, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 1115);
            panel1.TabIndex = 1;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(3, 1035);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(249, 77);
            StartButton.TabIndex = 11;
            StartButton.Text = "Старт";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // DrawFigure4Button
            // 
            DrawFigure4Button.Location = new Point(334, 252);
            DrawFigure4Button.Name = "DrawFigure4Button";
            DrawFigure4Button.Size = new Size(249, 77);
            DrawFigure4Button.TabIndex = 10;
            DrawFigure4Button.Text = "Нарисовать фигуру 4";
            DrawFigure4Button.UseVisualStyleBackColor = true;
            // 
            // DrawFigure3Button
            // 
            DrawFigure3Button.Location = new Point(334, 169);
            DrawFigure3Button.Name = "DrawFigure3Button";
            DrawFigure3Button.Size = new Size(249, 77);
            DrawFigure3Button.TabIndex = 9;
            DrawFigure3Button.Text = "Нарисовать фигуру 3 ";
            DrawFigure3Button.UseVisualStyleBackColor = true;
            // 
            // DrawFigure2Button
            // 
            DrawFigure2Button.Location = new Point(334, 86);
            DrawFigure2Button.Name = "DrawFigure2Button";
            DrawFigure2Button.Size = new Size(249, 77);
            DrawFigure2Button.TabIndex = 8;
            DrawFigure2Button.Text = "Нарисовать фигуру 2";
            DrawFigure2Button.UseVisualStyleBackColor = true;
            // 
            // UpButton
            // 
            UpButton.Location = new Point(165, 711);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(249, 77);
            UpButton.TabIndex = 7;
            UpButton.Text = "По оси OY вверх";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(165, 628);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(249, 77);
            DownButton.TabIndex = 6;
            DownButton.Text = "По оси OY вниз";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Location = new Point(165, 545);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(249, 77);
            LeftButton.TabIndex = 5;
            LeftButton.Text = "По оси OX влево";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.Location = new Point(165, 462);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(249, 77);
            RightButton.TabIndex = 4;
            RightButton.Text = "По оси OX вправо";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(210, 378);
            label1.Name = "label1";
            label1.Size = new Size(155, 65);
            label1.TabIndex = 3;
            label1.Text = "Сдвиг";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(3, 86);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(249, 77);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DrawFigure1Button
            // 
            DrawFigure1Button.Location = new Point(334, 3);
            DrawFigure1Button.Name = "DrawFigure1Button";
            DrawFigure1Button.Size = new Size(249, 77);
            DrawFigure1Button.TabIndex = 1;
            DrawFigure1Button.Text = "Нарисовать фигуру 1 ";
            DrawFigure1Button.UseVisualStyleBackColor = true;
            DrawFigure1Button.Click += DrawFigure1Button_Click;
            // 
            // DrawOsiButton
            // 
            DrawOsiButton.Location = new Point(3, 3);
            DrawOsiButton.Name = "DrawOsiButton";
            DrawOsiButton.Size = new Size(249, 77);
            DrawOsiButton.TabIndex = 0;
            DrawOsiButton.Text = "Нарисовать оси ";
            DrawOsiButton.UseVisualStyleBackColor = true;
            DrawOsiButton.Click += DrawOsiButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // LaboratoryCG3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 1121);
            Controls.Add(tableLayoutPanel1);
            Name = "LaboratoryCG3";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button DrawOsiButton;
        private Button UpButton;
        private Button DownButton;
        private Button LeftButton;
        private Button RightButton;
        private Label label1;
        private Button ClearButton;
        private Button DrawFigure1Button;
        private Button DrawFigure4Button;
        private Button DrawFigure3Button;
        private Button DrawFigure2Button;
        private Button StartButton;
        private System.Windows.Forms.Timer timer1;
    }
}
