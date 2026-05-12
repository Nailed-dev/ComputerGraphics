namespace CG_Lab.Lab3
{
    partial class Lab3Choice
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
            panel1 = new Panel();
            BoatButton = new Button();
            PlaneButton = new Button();
            BicycleButton = new Button();
            CosmosButton = new Button();
            MainLabButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BoatButton);
            panel1.Controls.Add(PlaneButton);
            panel1.Controls.Add(BicycleButton);
            panel1.Controls.Add(CosmosButton);
            panel1.Controls.Add(MainLabButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 759);
            panel1.TabIndex = 0;
            // 
            // BoatButton
            // 
            BoatButton.Location = new Point(787, 428);
            BoatButton.Name = "BoatButton";
            BoatButton.Size = new Size(376, 110);
            BoatButton.TabIndex = 5;
            BoatButton.Text = "Лодка";
            BoatButton.UseVisualStyleBackColor = true;
            BoatButton.Click += BoatButton_Click;
            // 
            // PlaneButton
            // 
            PlaneButton.Location = new Point(119, 428);
            PlaneButton.Name = "PlaneButton";
            PlaneButton.Size = new Size(376, 110);
            PlaneButton.TabIndex = 4;
            PlaneButton.Text = "Самолетик";
            PlaneButton.UseVisualStyleBackColor = true;
            PlaneButton.Click += PlaneButton_Click;
            // 
            // BicycleButton
            // 
            BicycleButton.Location = new Point(787, 223);
            BicycleButton.Name = "BicycleButton";
            BicycleButton.Size = new Size(376, 110);
            BicycleButton.TabIndex = 3;
            BicycleButton.Text = "Велосипед";
            BicycleButton.UseVisualStyleBackColor = true;
            BicycleButton.Click += BicycleButton_Click;
            // 
            // CosmosButton
            // 
            CosmosButton.Location = new Point(119, 223);
            CosmosButton.Name = "CosmosButton";
            CosmosButton.Size = new Size(376, 110);
            CosmosButton.TabIndex = 1;
            CosmosButton.Text = "Космический корабль";
            CosmosButton.UseVisualStyleBackColor = true;
            CosmosButton.Click += CosmosButton_Click;
            // 
            // MainLabButton
            // 
            MainLabButton.Location = new Point(414, 50);
            MainLabButton.Name = "MainLabButton";
            MainLabButton.Size = new Size(376, 110);
            MainLabButton.TabIndex = 0;
            MainLabButton.Text = "Основная лабараторная работа";
            MainLabButton.UseVisualStyleBackColor = true;
            MainLabButton.Click += MainLabButton_Click;
            // 
            // Lab3Choice
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 759);
            Controls.Add(panel1);
            Name = "Lab3Choice";
            Text = "Lab3Choice";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button MainLabButton;
        private Button CosmosButton;
        private Button BicycleButton;
        private Button PlaneButton;
        private Button BoatButton;
    }
}