namespace CG_Lab.Lab1
{
    partial class InputValue
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
            ButtonOK = new Button();
            SuspendLayout();
            // 
            // ButtonOK
            // 
            ButtonOK.DialogResult = DialogResult.OK;
            ButtonOK.Dock = DockStyle.Bottom;
            ButtonOK.Location = new Point(0, 506);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new Size(879, 46);
            ButtonOK.TabIndex = 0;
            ButtonOK.Text = "OK";
            ButtonOK.UseVisualStyleBackColor = true;
            // 
            // InputValue
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 552);
            Controls.Add(ButtonOK);
            MaximizeBox = false;
            Name = "InputValue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputValue";
            Load += InputValue_Load;
            ResumeLayout(false);
        }

        #endregion

        public Button ButtonOK;
    }
}