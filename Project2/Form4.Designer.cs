namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.Text1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.AcceptsReturn = true;
            this.Text1.BackColor = System.Drawing.SystemColors.Window;
            this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text1.Location = new System.Drawing.Point(0, 1);
            this.Text1.MaxLength = 0;
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Text1.Size = new System.Drawing.Size(649, 433);
            this.Text1.TabIndex = 1;
            this.Text1.WordWrap = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 435);
            this.Controls.Add(this.Text1);
            this.Location = new System.Drawing.Point(392, 248);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decrypted Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Text1;
    }
}