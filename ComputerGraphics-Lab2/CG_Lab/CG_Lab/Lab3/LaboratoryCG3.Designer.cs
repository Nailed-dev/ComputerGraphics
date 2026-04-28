namespace CG_Lab.Lab3
{
    partial class LaboratoryCG3
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            StartButton = new Button();
            UpButton = new Button();
            DownButton = new Button();
            LeftButton = new Button();
            RightButton = new Button();
            label1 = new Label();
            ClearButton = new Button();
            DrawFigureButton = new Button();
            DrawAxisButton = new Button();
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
            tableLayoutPanel1.Size = new Size(1248, 914);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(742, 908);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(StartButton);
            panel1.Controls.Add(UpButton);
            panel1.Controls.Add(DownButton);
            panel1.Controls.Add(LeftButton);
            panel1.Controls.Add(RightButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(DrawFigureButton);
            panel1.Controls.Add(DrawAxisButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(751, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 908);
            panel1.TabIndex = 1;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(35, 762);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(177, 57);
            StartButton.TabIndex = 8;
            StartButton.Text = "Старт";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // UpButton
            // 
            UpButton.Location = new Point(110, 654);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(294, 70);
            UpButton.TabIndex = 7;
            UpButton.Text = "По оси ОУ вверх";
            UpButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(110, 578);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(294, 70);
            DownButton.TabIndex = 6;
            DownButton.Text = "По оси ОУ вниз";
            DownButton.UseVisualStyleBackColor = true;
            // 
            // LeftButton
            // 
            LeftButton.Location = new Point(110, 502);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(294, 70);
            LeftButton.TabIndex = 5;
            LeftButton.Text = "По оси ОХ влево";
            LeftButton.UseVisualStyleBackColor = true;
            // 
            // RightButton
            // 
            RightButton.Location = new Point(110, 426);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(294, 70);
            RightButton.TabIndex = 4;
            RightButton.Text = "По оси ОХ вправо";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.8571434F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(155, 336);
            label1.Name = "label1";
            label1.Size = new Size(210, 87);
            label1.TabIndex = 3;
            label1.Text = "Сдвиг";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(110, 215);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(294, 70);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DrawFigureButton
            // 
            DrawFigureButton.Location = new Point(110, 116);
            DrawFigureButton.Name = "DrawFigureButton";
            DrawFigureButton.Size = new Size(294, 70);
            DrawFigureButton.TabIndex = 1;
            DrawFigureButton.Text = "Нарисовать фигуру";
            DrawFigureButton.UseVisualStyleBackColor = true;
            DrawFigureButton.Click += DrawFigureButton_Click;
            // 
            // DrawAxisButton
            // 
            DrawAxisButton.Location = new Point(110, 21);
            DrawAxisButton.Name = "DrawAxisButton";
            DrawAxisButton.Size = new Size(294, 70);
            DrawAxisButton.TabIndex = 0;
            DrawAxisButton.Text = "Нарисовать ОСИ";
            DrawAxisButton.UseVisualStyleBackColor = true;
            DrawAxisButton.Click += DrawAxicButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // LaboratoryCG3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 914);
            Controls.Add(tableLayoutPanel1);
            Name = "LaboratoryCG3";
            Text = "LaboratoryCG3";
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
        private Label label1;
        private Button ClearButton;
        private Button DrawFigureButton;
        private Button DrawAxisButton;
        private Button UpButton;
        private Button DownButton;
        private Button LeftButton;
        private Button RightButton;
        private Button StartButton;
        private System.Windows.Forms.Timer timer1;
    }
}