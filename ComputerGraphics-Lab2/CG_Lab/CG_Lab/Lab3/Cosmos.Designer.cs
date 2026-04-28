
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
            this.components = new System.ComponentModel.Container();

            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelSpace = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();

            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.White;
            this.panelButtons.Controls.Add(this.btnStart);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(160, 600);
            this.panelButtons.TabIndex = 0;

            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;

            // 
            // panelSpace
            // 
            this.panelSpace.BackColor = System.Drawing.Color.Black;
            this.panelSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSpace.Location = new System.Drawing.Point(160, 0);
            this.panelSpace.Name = "panelSpace";
            this.panelSpace.Size = new System.Drawing.Size(740, 600);
            this.panelSpace.TabIndex = 1;

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelSpace);
            this.Controls.Add(this.panelButtons);
            this.Name = "Form1";
            this.Text = "Космические корабли";

            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}