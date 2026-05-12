namespace CG_Lab.Lab2
{
    partial class LaboratoryCG2
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
            tableLayoutPanel1 = new TableLayoutPanel();
            PictureBox = new PictureBox();
            panel1 = new Panel();
            LenthTextBox = new TextBox();
            StepTextBox = new TextBox();
            StepLabel = new Label();
            LenthLabel = new Label();
            punctCheckBox = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ClearButton = new Button();
            ExecuteButton = new Button();
            ColorFillButton = new Button();
            ColorLineButton = new Button();
            ThicknessCheckedBox = new CheckBox();
            ChooseGroupBox = new GroupBox();
            AsCDARadioButton = new RadioButton();
            OtsechRadioButton = new RadioButton();
            BresenhamRadioButton = new RadioButton();
            FillRadioButton = new RadioButton();
            CDARadioButton = new RadioButton();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ChooseGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(PictureBox, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1284, 985);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(3, 3);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(764, 959);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.MouseDown += PictureBox_MouseDown;
            PictureBox.MouseUp += PictureBox_MouseUp;
            // 
            // panel1
            // 
            panel1.Controls.Add(LenthTextBox);
            panel1.Controls.Add(StepTextBox);
            panel1.Controls.Add(StepLabel);
            panel1.Controls.Add(LenthLabel);
            panel1.Controls.Add(punctCheckBox);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(ThicknessCheckedBox);
            panel1.Controls.Add(ChooseGroupBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(773, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 959);
            panel1.TabIndex = 1;
            // 
            // LenthTextBox
            // 
            LenthTextBox.Location = new Point(231, 541);
            LenthTextBox.Name = "LenthTextBox";
            LenthTextBox.Size = new Size(200, 39);
            LenthTextBox.TabIndex = 8;
            // 
            // StepTextBox
            // 
            StepTextBox.Location = new Point(3, 541);
            StepTextBox.Name = "StepTextBox";
            StepTextBox.Size = new Size(200, 39);
            StepTextBox.TabIndex = 7;
            // 
            // StepLabel
            // 
            StepLabel.AutoSize = true;
            StepLabel.Location = new Point(85, 495);
            StepLabel.Name = "StepLabel";
            StepLabel.Size = new Size(58, 32);
            StepLabel.TabIndex = 6;
            StepLabel.Text = "Шаг";
            // 
            // LenthLabel
            // 
            LenthLabel.AutoSize = true;
            LenthLabel.Location = new Point(231, 495);
            LenthLabel.Name = "LenthLabel";
            LenthLabel.Size = new Size(84, 32);
            LenthLabel.TabIndex = 5;
            LenthLabel.Text = "Длина";
            // 
            // punctCheckBox
            // 
            punctCheckBox.AutoSize = true;
            punctCheckBox.Location = new Point(14, 424);
            punctCheckBox.Name = "punctCheckBox";
            punctCheckBox.Size = new Size(139, 36);
            punctCheckBox.TabIndex = 4;
            punctCheckBox.Text = "Пунктир";
            punctCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ClearButton, 1, 1);
            tableLayoutPanel2.Controls.Add(ExecuteButton, 0, 1);
            tableLayoutPanel2.Controls.Add(ColorFillButton, 1, 0);
            tableLayoutPanel2.Controls.Add(ColorLineButton, 0, 0);
            tableLayoutPanel2.Location = new Point(9, 756);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(490, 200);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // ClearButton
            // 
            ClearButton.Dock = DockStyle.Fill;
            ClearButton.Location = new Point(248, 103);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(239, 94);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExecuteButton
            // 
            ExecuteButton.Dock = DockStyle.Fill;
            ExecuteButton.Location = new Point(3, 103);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(239, 94);
            ExecuteButton.TabIndex = 2;
            ExecuteButton.Text = "Выполнить";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // ColorFillButton
            // 
            ColorFillButton.Dock = DockStyle.Fill;
            ColorFillButton.Location = new Point(248, 3);
            ColorFillButton.Name = "ColorFillButton";
            ColorFillButton.Size = new Size(239, 94);
            ColorFillButton.TabIndex = 1;
            ColorFillButton.Text = "Цвет заливки";
            ColorFillButton.UseVisualStyleBackColor = true;
            ColorFillButton.Click += ColorFillButton_Click;
            // 
            // ColorLineButton
            // 
            ColorLineButton.Dock = DockStyle.Fill;
            ColorLineButton.Location = new Point(3, 3);
            ColorLineButton.Name = "ColorLineButton";
            ColorLineButton.Size = new Size(239, 94);
            ColorLineButton.TabIndex = 0;
            ColorLineButton.Text = "Цвет линии";
            ColorLineButton.UseVisualStyleBackColor = true;
            ColorLineButton.Click += ColorLineButton_Click;
            // 
            // ThicknessCheckedBox
            // 
            ThicknessCheckedBox.AutoSize = true;
            ThicknessCheckedBox.Location = new Point(14, 370);
            ThicknessCheckedBox.Name = "ThicknessCheckedBox";
            ThicknessCheckedBox.Size = new Size(205, 36);
            ThicknessCheckedBox.TabIndex = 1;
            ThicknessCheckedBox.Text = "Толстая линия";
            ThicknessCheckedBox.UseVisualStyleBackColor = true;
            // 
            // ChooseGroupBox
            // 
            ChooseGroupBox.Controls.Add(AsCDARadioButton);
            ChooseGroupBox.Controls.Add(OtsechRadioButton);
            ChooseGroupBox.Controls.Add(BresenhamRadioButton);
            ChooseGroupBox.Controls.Add(FillRadioButton);
            ChooseGroupBox.Controls.Add(CDARadioButton);
            ChooseGroupBox.Location = new Point(3, 9);
            ChooseGroupBox.Name = "ChooseGroupBox";
            ChooseGroupBox.Size = new Size(496, 355);
            ChooseGroupBox.TabIndex = 0;
            ChooseGroupBox.TabStop = false;
            ChooseGroupBox.Text = "Выберите алгоритм";
            // 
            // AsCDARadioButton
            // 
            AsCDARadioButton.AutoSize = true;
            AsCDARadioButton.Location = new Point(6, 278);
            AsCDARadioButton.Name = "AsCDARadioButton";
            AsCDARadioButton.Size = new Size(206, 36);
            AsCDARadioButton.TabIndex = 4;
            AsCDARadioButton.TabStop = true;
            AsCDARadioButton.Text = "Ассиметрично";
            AsCDARadioButton.UseVisualStyleBackColor = true;
            
            // 
            // OtsechRadioButton
            // 
            OtsechRadioButton.AutoSize = true;
            OtsechRadioButton.Location = new Point(6, 227);
            OtsechRadioButton.Name = "OtsechRadioButton";
            OtsechRadioButton.Size = new Size(165, 36);
            OtsechRadioButton.TabIndex = 3;
            OtsechRadioButton.TabStop = true;
            OtsechRadioButton.Text = "Отсечение";
            OtsechRadioButton.UseVisualStyleBackColor = true;
            // 
            // BresenhamRadioButton
            // 
            BresenhamRadioButton.AutoSize = true;
            BresenhamRadioButton.Location = new Point(6, 170);
            BresenhamRadioButton.Name = "BresenhamRadioButton";
            BresenhamRadioButton.Size = new Size(290, 36);
            BresenhamRadioButton.TabIndex = 2;
            BresenhamRadioButton.TabStop = true;
            BresenhamRadioButton.Text = "Алгоритм Брезенхема";
            BresenhamRadioButton.UseVisualStyleBackColor = true;
            // 
            // FillRadioButton
            // 
            FillRadioButton.AutoSize = true;
            FillRadioButton.Location = new Point(6, 112);
            FillRadioButton.Name = "FillRadioButton";
            FillRadioButton.Size = new Size(134, 36);
            FillRadioButton.TabIndex = 1;
            FillRadioButton.TabStop = true;
            FillRadioButton.Text = "Заливка";
            FillRadioButton.UseVisualStyleBackColor = true;
            // 
            // CDARadioButton
            // 
            CDARadioButton.AutoSize = true;
            CDARadioButton.Location = new Point(6, 51);
            CDARadioButton.Name = "CDARadioButton";
            CDARadioButton.Size = new Size(210, 36);
            CDARadioButton.TabIndex = 0;
            CDARadioButton.TabStop = true;
            CDARadioButton.Text = "Обычный ЦДА";
            CDARadioButton.UseVisualStyleBackColor = true;
            // 
            // LaboratoryCG2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 985);
            Controls.Add(tableLayoutPanel1);
            Name = "LaboratoryCG2";
            Text = "LaboratoryCG2";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ChooseGroupBox.ResumeLayout(false);
            ChooseGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox PictureBox;
        private Panel panel1;
        private CheckBox ThicknessCheckedBox;
        private GroupBox ChooseGroupBox;
        private RadioButton FillRadioButton;
        private RadioButton CDARadioButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ClearButton;
        private Button ExecuteButton;
        private Button ColorFillButton;
        private Button ColorLineButton;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private RadioButton BresenhamRadioButton;
        private TextBox LenthTextBox;
        private TextBox StepTextBox;
        private Label StepLabel;
        private Label LenthLabel;
        private CheckBox punctCheckBox;
        private RadioButton OtsechRadioButton;
        private RadioButton AsCDARadioButton;
    }
}