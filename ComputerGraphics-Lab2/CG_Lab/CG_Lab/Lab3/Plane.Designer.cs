namespace PaperPlane

{
    partial class Plane
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelButtons;
        private BufferedPanel panelScene;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
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
            btnReset = new Button();
            btnStart = new Button();
            panelScene = new BufferedPanel();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.White;
            panelButtons.Controls.Add(labelTitle);
            panelButtons.Controls.Add(btnReset);
            panelButtons.Controls.Add(btnStart);
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
            // btnReset
            // 
            btnReset.Location = new Point(30, 145);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 35);
            btnReset.TabIndex = 1;
            btnReset.Text = "Сброс";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(30, 95);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(110, 35);
            btnStart.TabIndex = 0;
            btnStart.Text = "Старт";
            btnStart.UseVisualStyleBackColor = true;
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