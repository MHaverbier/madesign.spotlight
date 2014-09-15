namespace Spotlight.WinForms
{
    partial class DlgTreffer
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
            this.lblPfad = new System.Windows.Forms.Label();
            this.lblBegriff = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPfad
            // 
            this.lblPfad.AutoSize = true;
            this.lblPfad.Location = new System.Drawing.Point(15, 7);
            this.lblPfad.Name = "lblPfad";
            this.lblPfad.Size = new System.Drawing.Size(39, 13);
            this.lblPfad.TabIndex = 0;
            this.lblPfad.Text = "lblPfad";
            // 
            // lblBegriff
            // 
            this.lblBegriff.AutoSize = true;
            this.lblBegriff.Location = new System.Drawing.Point(15, 29);
            this.lblBegriff.Name = "lblBegriff";
            this.lblBegriff.Size = new System.Drawing.Size(35, 13);
            this.lblBegriff.TabIndex = 1;
            this.lblBegriff.Text = "label2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 45);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 18);
            this.progressBar1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 186);
            this.listBox1.TabIndex = 3;
            // 
            // DlgTreffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblBegriff);
            this.Controls.Add(this.lblPfad);
            this.Name = "DlgTreffer";
            this.Text = "Dateien gefunden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPfad;
        private System.Windows.Forms.Label lblBegriff;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
    }
}