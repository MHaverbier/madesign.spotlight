namespace Spotlight.WinForms
{
    partial class DlgSuchen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPfad = new System.Windows.Forms.TextBox();
            this.txtBegriff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pfad";
            // 
            // txtPfad
            // 
            this.txtPfad.Location = new System.Drawing.Point(59, 10);
            this.txtPfad.Name = "txtPfad";
            this.txtPfad.Size = new System.Drawing.Size(100, 20);
            this.txtPfad.TabIndex = 1;
            this.txtPfad.Text = "..\\..\\";
            // 
            // txtBegriff
            // 
            this.txtBegriff.Location = new System.Drawing.Point(59, 36);
            this.txtBegriff.Name = "txtBegriff";
            this.txtBegriff.Size = new System.Drawing.Size(100, 20);
            this.txtBegriff.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Begriff";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(182, 10);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(75, 47);
            this.btnSuchen.TabIndex = 4;
            this.btnSuchen.Text = "Suchen...";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // DlgSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 69);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.txtBegriff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPfad);
            this.Controls.Add(this.label1);
            this.Name = "DlgSuchen";
            this.Text = "Dateisuche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPfad;
        private System.Windows.Forms.TextBox txtBegriff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuchen;
    }
}

