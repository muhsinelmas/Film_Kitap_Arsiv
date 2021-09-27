namespace Film_Arsiv
{
    partial class FrmAnaSayfa
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
            this.Btn_Film_Kaydet = new System.Windows.Forms.Button();
            this.Btn_Kitap_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Film_Kaydet
            // 
            this.Btn_Film_Kaydet.Location = new System.Drawing.Point(75, 70);
            this.Btn_Film_Kaydet.Name = "Btn_Film_Kaydet";
            this.Btn_Film_Kaydet.Size = new System.Drawing.Size(139, 71);
            this.Btn_Film_Kaydet.TabIndex = 0;
            this.Btn_Film_Kaydet.Text = "Film Kaydet";
            this.Btn_Film_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Film_Kaydet.Click += new System.EventHandler(this.Btn_Film_Kaydet_Click);
            // 
            // Btn_Kitap_Kaydet
            // 
            this.Btn_Kitap_Kaydet.Location = new System.Drawing.Point(220, 70);
            this.Btn_Kitap_Kaydet.Name = "Btn_Kitap_Kaydet";
            this.Btn_Kitap_Kaydet.Size = new System.Drawing.Size(139, 71);
            this.Btn_Kitap_Kaydet.TabIndex = 1;
            this.Btn_Kitap_Kaydet.Text = "Kitap Kaydet";
            this.Btn_Kitap_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Kitap_Kaydet.Click += new System.EventHandler(this.Btn_Kitap_Kaydet_Click);
            // 
            // Frm_Ana_Sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.Btn_Kitap_Kaydet);
            this.Controls.Add(this.Btn_Film_Kaydet);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Ana_Sayfa_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Film_Kaydet;
        private System.Windows.Forms.Button Btn_Kitap_Kaydet;
    }
}