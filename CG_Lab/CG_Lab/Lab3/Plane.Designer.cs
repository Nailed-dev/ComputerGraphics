namespace PaperPlane
{
    partial class Plane
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelButtons;
        private BufferedPanel panelScene;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label labelTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelButtons = new Panel();
            labelTitle = new Label();
            ResetButton = new Button();
            StartButton = new Button();
            panelScene = new BufferedPanel();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.White;
            panelButtons.Controls.Add(labelTitle);
            panelButtons.Controls.Add(ResetButton);
            panelButtons.Controls.Add(StartButton);
            panelButtons.Dock = DockStyle.Left;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(170, 600);
            panelButtons.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(100, 23);
            labelTitle.TabIndex = 0;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(30, 145);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(110, 35);
            ResetButton.TabIndex = 1;
            ResetButton.Text = "Сброс";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(30, 95);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(110, 35);
            StartButton.TabIndex = 0;
            StartButton.Text = "Старт";
            StartButton.UseVisualStyleBackColor = true;
            // 
            // panelScene
            // 
            panelScene.BackColor = Color.White;
            panelScene.Dock = DockStyle.Fill;
            panelScene.Location = new Point(170, 0);
            panelScene.Name = "panelScene";
            panelScene.Size = new Size(730, 600);
            panelScene.TabIndex = 1;
            // 
            // Plane
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(panelScene);
            Controls.Add(panelButtons);
            Name = "Plane";
            Text = "Приближение бумажного самолётика";
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}