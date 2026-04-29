namespace Lab3_SailboatSeagull
{
    partial class Boat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            btnStart = new Button();
            btnReset = new Button();
            lblInfo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(6, 7, 6, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 115);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(0, 0);
            btnStart.Margin = new Padding(6, 7, 6, 7);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 53);
            btnStart.TabIndex = 1;
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(0, 0);
            btnReset.Margin = new Padding(6, 7, 6, 7);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 53);
            btnReset.TabIndex = 2;
            btnReset.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(0, 0);
            lblInfo.Margin = new Padding(6, 0, 6, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(200, 53);
            lblInfo.TabIndex = 3;
            // 
            // Boat
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 1085);
            Controls.Add(pictureBox1);
            Controls.Add(btnStart);
            Controls.Add(btnReset);
            Controls.Add(lblInfo);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Boat";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer timer1;
    }
}
