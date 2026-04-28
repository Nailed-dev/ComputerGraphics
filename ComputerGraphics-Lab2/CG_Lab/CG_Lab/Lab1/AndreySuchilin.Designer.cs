namespace CG_Lab.Lab1
{
    partial class AndreySuchilin
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
            InputVectorButton1 = new Button();
            InputVectorButton2 = new Button();
            label1 = new Label();
            label2 = new Label();
            ResultProductOfVectors = new Button();
            SuspendLayout();
            // 
            // InputVectorButton1
            // 
            InputVectorButton1.Location = new Point(77, 102);
            InputVectorButton1.Name = "InputVectorButton1";
            InputVectorButton1.Size = new Size(298, 115);
            InputVectorButton1.TabIndex = 0;
            InputVectorButton1.Text = "Ввод вектора а";
            InputVectorButton1.UseVisualStyleBackColor = true;
            InputVectorButton1.Click += InputVectorButton1_Click;
            // 
            // InputVectorButton2
            // 
            InputVectorButton2.Location = new Point(77, 251);
            InputVectorButton2.Name = "InputVectorButton2";
            InputVectorButton2.Size = new Size(298, 115);
            InputVectorButton2.TabIndex = 1;
            InputVectorButton2.Text = "Ввод вектора b";
            InputVectorButton2.UseVisualStyleBackColor = true;
            InputVectorButton2.Click += InputVectorButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 143);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 292);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // ResultProductOfVectors
            // 
            ResultProductOfVectors.Location = new Point(236, 492);
            ResultProductOfVectors.Name = "ResultProductOfVectors";
            ResultProductOfVectors.Size = new Size(355, 145);
            ResultProductOfVectors.TabIndex = 4;
            ResultProductOfVectors.Text = "Результат векторного произведения";
            ResultProductOfVectors.UseVisualStyleBackColor = true;
            ResultProductOfVectors.Click += ResultProductOfVectors_Click;
            // 
            // AndreySuchilin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 783);
            Controls.Add(ResultProductOfVectors);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputVectorButton2);
            Controls.Add(InputVectorButton1);
            Name = "AndreySuchilin";
            Text = "Векторное произведение вектора";
            Load += VectorProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InputVectorButton1;
        private Button InputVectorButton2;
        private Label label1;
        private Label label2;
        private Button ResultProductOfVectors;
    }
}