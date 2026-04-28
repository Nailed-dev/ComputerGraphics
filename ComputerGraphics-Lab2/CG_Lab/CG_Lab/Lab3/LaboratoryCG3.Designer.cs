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
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ReflectZButton = new Button();
            ReflectYButton = new Button();
            ReflectXButton = new Button();
            label4 = new Label();
            ScaleDownButton = new Button();
            ScaleUpButton = new Button();
            label3 = new Label();
            StartButton = new Button();
            RotationButton6 = new Button();
            RotationButton5 = new Button();
            RotationButton4 = new Button();
            RotationButton3 = new Button();
            RotationButton2 = new Button();
            RotationButton1 = new Button();
            label2 = new Label();
            PlusOZButton = new Button();
            MinusOZButton = new Button();
            UpButton = new Button();
            DownButton = new Button();
            LeftButton = new Button();
            RightButton = new Button();
            label1 = new Label();
            ClearButton = new Button();
            StartPositionButton = new Button();
            DrawFigureButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
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
            tableLayoutPanel1.Size = new Size(1897, 1148);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1132, 1142);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(ReflectZButton);
            panel1.Controls.Add(ReflectYButton);
            panel1.Controls.Add(ReflectXButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ScaleDownButton);
            panel1.Controls.Add(ScaleUpButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(StartButton);
            panel1.Controls.Add(RotationButton6);
            panel1.Controls.Add(RotationButton5);
            panel1.Controls.Add(RotationButton4);
            panel1.Controls.Add(RotationButton3);
            panel1.Controls.Add(RotationButton2);
            panel1.Controls.Add(RotationButton1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PlusOZButton);
            panel1.Controls.Add(MinusOZButton);
            panel1.Controls.Add(UpButton);
            panel1.Controls.Add(DownButton);
            panel1.Controls.Add(LeftButton);
            panel1.Controls.Add(RightButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(StartPositionButton);
            panel1.Controls.Add(DrawFigureButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1141, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 1142);
            panel1.TabIndex = 1;
            // 
            // ReflectZButton
            // 
            ReflectZButton.Location = new Point(432, 1002);
            ReflectZButton.Name = "ReflectZButton";
            ReflectZButton.Size = new Size(318, 70);
            ReflectZButton.TabIndex = 24;
            ReflectZButton.Text = "По оси Z";
            ReflectZButton.UseVisualStyleBackColor = true;
            ReflectZButton.Click += ReflectZButton_Click;
            // 
            // ReflectYButton
            // 
            ReflectYButton.Location = new Point(432, 926);
            ReflectYButton.Name = "ReflectYButton";
            ReflectYButton.Size = new Size(318, 70);
            ReflectYButton.TabIndex = 23;
            ReflectYButton.Text = "По оси Y";
            ReflectYButton.UseVisualStyleBackColor = true;
            ReflectYButton.Click += ReflectYButton_Click;
            // 
            // ReflectXButton
            // 
            ReflectXButton.Location = new Point(432, 850);
            ReflectXButton.Name = "ReflectXButton";
            ReflectXButton.Size = new Size(318, 70);
            ReflectXButton.TabIndex = 22;
            ReflectXButton.Text = "По оси X";
            ReflectXButton.UseVisualStyleBackColor = true;
            ReflectXButton.Click += ReflectXButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(427, 773);
            label4.Name = "label4";
            label4.Size = new Size(323, 74);
            label4.TabIndex = 21;
            label4.Text = "Отражение";
            // 
            // ScaleDownButton
            // 
            ScaleDownButton.Font = new Font("Segoe UI", 26.1428585F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ScaleDownButton.Location = new Point(588, 94);
            ScaleDownButton.Name = "ScaleDownButton";
            ScaleDownButton.Size = new Size(90, 90);
            ScaleDownButton.TabIndex = 20;
            ScaleDownButton.Text = "-";
            ScaleDownButton.UseVisualStyleBackColor = true;
            ScaleDownButton.Click += ScaleDownButton_Click;
            // 
            // ScaleUpButton
            // 
            ScaleUpButton.Font = new Font("Segoe UI", 26.1428585F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ScaleUpButton.Location = new Point(492, 94);
            ScaleUpButton.Name = "ScaleUpButton";
            ScaleUpButton.Size = new Size(90, 90);
            ScaleUpButton.TabIndex = 19;
            ScaleUpButton.Text = "+";
            ScaleUpButton.UseVisualStyleBackColor = true;
            ScaleUpButton.Click += ScaleUpButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(366, 91);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 18;
            label3.Text = "Масштаб";
            // 
            // StartButton
            // 
            StartButton.Location = new Point(3, 1063);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(170, 70);
            StartButton.TabIndex = 17;
            StartButton.Text = "Старт";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // RotationButton6
            // 
            RotationButton6.Location = new Point(432, 691);
            RotationButton6.Name = "RotationButton6";
            RotationButton6.Size = new Size(318, 70);
            RotationButton6.TabIndex = 16;
            RotationButton6.Text = "Против часовой Z";
            RotationButton6.UseVisualStyleBackColor = true;
            RotationButton6.Click += RotationButton6_Click;
            // 
            // RotationButton5
            // 
            RotationButton5.Location = new Point(432, 615);
            RotationButton5.Name = "RotationButton5";
            RotationButton5.Size = new Size(318, 70);
            RotationButton5.TabIndex = 15;
            RotationButton5.Text = "По часовой Z";
            RotationButton5.UseVisualStyleBackColor = true;
            RotationButton5.Click += RotationButton5_Click;
            // 
            // RotationButton4
            // 
            RotationButton4.Location = new Point(432, 539);
            RotationButton4.Name = "RotationButton4";
            RotationButton4.Size = new Size(318, 70);
            RotationButton4.TabIndex = 14;
            RotationButton4.Text = "Против часовой X";
            RotationButton4.UseVisualStyleBackColor = true;
            RotationButton4.Click += RotationButton4_Click;
            // 
            // RotationButton3
            // 
            RotationButton3.Location = new Point(432, 463);
            RotationButton3.Name = "RotationButton3";
            RotationButton3.Size = new Size(318, 70);
            RotationButton3.TabIndex = 13;
            RotationButton3.Text = "По часовой X";
            RotationButton3.UseVisualStyleBackColor = true;
            RotationButton3.Click += RotationButton3_Click;
            // 
            // RotationButton2
            // 
            RotationButton2.Location = new Point(432, 387);
            RotationButton2.Name = "RotationButton2";
            RotationButton2.Size = new Size(318, 70);
            RotationButton2.TabIndex = 12;
            RotationButton2.Text = "Против часовой Y";
            RotationButton2.UseVisualStyleBackColor = true;
            RotationButton2.Click += RotationButton2_Click;
            // 
            // RotationButton1
            // 
            RotationButton1.Location = new Point(432, 311);
            RotationButton1.Name = "RotationButton1";
            RotationButton1.Size = new Size(318, 70);
            RotationButton1.TabIndex = 11;
            RotationButton1.Text = "По часовой Y";
            RotationButton1.UseVisualStyleBackColor = true;
            RotationButton1.Click += RotationButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(466, 211);
            label2.Name = "label2";
            label2.Size = new Size(257, 74);
            label2.TabIndex = 10;
            label2.Text = "Поворот";
            // 
            // PlusOZButton
            // 
            PlusOZButton.Location = new Point(3, 691);
            PlusOZButton.Name = "PlusOZButton";
            PlusOZButton.Size = new Size(318, 70);
            PlusOZButton.TabIndex = 9;
            PlusOZButton.Text = "По оси OZ плюс";
            PlusOZButton.UseVisualStyleBackColor = true;
            PlusOZButton.Click += PlusOZButton_Click;
            // 
            // MinusOZButton
            // 
            MinusOZButton.Location = new Point(3, 615);
            MinusOZButton.Name = "MinusOZButton";
            MinusOZButton.Size = new Size(318, 70);
            MinusOZButton.TabIndex = 8;
            MinusOZButton.Text = "По оси OZ минус";
            MinusOZButton.UseVisualStyleBackColor = true;
            MinusOZButton.Click += MinusOZButton_Click;
            // 
            // UpButton
            // 
            UpButton.Location = new Point(3, 539);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(318, 70);
            UpButton.TabIndex = 7;
            UpButton.Text = "По оси OY вверх";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(3, 463);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(318, 70);
            DownButton.TabIndex = 6;
            DownButton.Text = "По оси OY вниз";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Location = new Point(3, 387);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(318, 70);
            LeftButton.TabIndex = 5;
            LeftButton.Text = "По оси OX влево";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.Location = new Point(3, 311);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(318, 70);
            RightButton.TabIndex = 4;
            RightButton.Text = "По оси OX вправо";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(54, 211);
            label1.Name = "label1";
            label1.Size = new Size(182, 74);
            label1.TabIndex = 3;
            label1.Text = "Сдвиг";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(25, 94);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(318, 70);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // StartPositionButton
            // 
            StartPositionButton.Location = new Point(366, 18);
            StartPositionButton.Name = "StartPositionButton";
            StartPositionButton.Size = new Size(318, 70);
            StartPositionButton.TabIndex = 1;
            StartPositionButton.Text = "Вернуть в исходное состояние";
            StartPositionButton.UseVisualStyleBackColor = true;
            StartPositionButton.Click += StartPositionButton_Click;
            // 
            // DrawFigureButton
            // 
            DrawFigureButton.Location = new Point(25, 18);
            DrawFigureButton.Name = "DrawFigureButton";
            DrawFigureButton.Size = new Size(318, 70);
            DrawFigureButton.TabIndex = 0;
            DrawFigureButton.Text = "Нарисовать фигуру";
            DrawFigureButton.UseVisualStyleBackColor = true;
            DrawFigureButton.Click += DrawFigureButton_Click;
            // 
            // LaboratoryCG3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1897, 1148);
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

        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Button ClearButton;
        private Button StartPositionButton;
        private Button DrawFigureButton;
        private Button RotationButton6;
        private Button RotationButton5;
        private Button RotationButton4;
        private Button RotationButton3;
        private Button RotationButton2;
        private Button RotationButton1;
        private Label label2;
        private Button PlusOZButton;
        private Button MinusOZButton;
        private Button UpButton;
        private Button DownButton;
        private Button LeftButton;
        private Button RightButton;
        private Button StartButton;
        private Button ScaleDownButton;
        private Button ScaleUpButton;
        private Label label3;
        private Button ReflectZButton;
        private Button ReflectYButton;
        private Button ReflectXButton;
        private Label label4;
    }
}