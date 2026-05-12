
namespace cosmos
{
    partial class Cosmos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelSpace;
        private System.Windows.Forms.Button btnStart;

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
            panelButtons = new Panel();
            btnStart = new Button();
            panelSpace = new Panel();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.White;
            panelButtons.Controls.Add(btnStart);
            panelButtons.Dock = DockStyle.Left;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(160, 600);
            panelButtons.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(25, 30);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(110, 35);
            btnStart.TabIndex = 0;
            btnStart.Text = "Старт";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // panelSpace
            // 
            panelSpace.BackColor = Color.Black;
            panelSpace.Dock = DockStyle.Fill;
            panelSpace.Location = new Point(160, 0);
            panelSpace.Name = "panelSpace";
            panelSpace.Size = new Size(740, 600);
            panelSpace.TabIndex = 1;
            // 
            // Cosmos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(panelSpace);
            Controls.Add(panelButtons);
            Name = "Cosmos";
            Text = "S";
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}