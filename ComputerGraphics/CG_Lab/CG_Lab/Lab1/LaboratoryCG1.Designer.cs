namespace CG_Lab.Lab1
{
    partial class LaboratoryCG1
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
            OlegButton = new Panel();
            button1 = new Button();
            RomanButton = new Button();
            ArtemButton = new Button();
            AndreyButton = new Button();
            MatrixCalculate = new Button();
            OlegButton.SuspendLayout();
            SuspendLayout();
            // 
            // OlegButton
            // 
            OlegButton.Controls.Add(button1);
            OlegButton.Controls.Add(RomanButton);
            OlegButton.Controls.Add(ArtemButton);
            OlegButton.Controls.Add(AndreyButton);
            OlegButton.Controls.Add(MatrixCalculate);
            OlegButton.Dock = DockStyle.Fill;
            OlegButton.Location = new Point(0, 0);
            OlegButton.Name = "OlegButton";
            OlegButton.Size = new Size(1496, 950);
            OlegButton.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(729, 451);
            button1.Name = "button1";
            button1.Size = new Size(272, 149);
            button1.TabIndex = 4;
            button1.Text = "Oleg";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Oleg_Click;
            // 
            // RomanButton
            // 
            RomanButton.Location = new Point(388, 451);
            RomanButton.Name = "RomanButton";
            RomanButton.Size = new Size(272, 149);
            RomanButton.TabIndex = 3;
            RomanButton.Text = "Roman";
            RomanButton.UseVisualStyleBackColor = true;
            RomanButton.Click += Roman_Click;
            // 
            // ArtemButton
            // 
            ArtemButton.Location = new Point(884, 238);
            ArtemButton.Name = "ArtemButton";
            ArtemButton.Size = new Size(272, 149);
            ArtemButton.TabIndex = 2;
            ArtemButton.Text = "Artem";
            ArtemButton.UseVisualStyleBackColor = true;
            ArtemButton.Click += Artem_Click;
            // 
            // AndreyButton
            // 
            AndreyButton.Location = new Point(556, 238);
            AndreyButton.Name = "AndreyButton";
            AndreyButton.Size = new Size(272, 149);
            AndreyButton.TabIndex = 1;
            AndreyButton.Text = "Andrey";
            AndreyButton.UseVisualStyleBackColor = true;
            AndreyButton.Click += Andrey_Click;
            // 
            // MatrixCalculate
            // 
            MatrixCalculate.Location = new Point(228, 238);
            MatrixCalculate.Name = "MatrixCalculate";
            MatrixCalculate.Size = new Size(272, 149);
            MatrixCalculate.TabIndex = 0;
            MatrixCalculate.Text = "MatrixCalculate";
            MatrixCalculate.UseVisualStyleBackColor = true;
            MatrixCalculate.Click += MatrixCalculate_Click;
            // 
            // LaboratoryCG1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 950);
            Controls.Add(OlegButton);
            Name = "LaboratoryCG1";
            Text = "LaboratoryCG1";
            Load += LaboratoryCG1_Load;
            OlegButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel OlegButton;
        private Button AndreyButton;
        private Button MatrixCalculate;
        private Button ArtemButton;
        private Button button1;
        private Button RomanButton;
    }
}