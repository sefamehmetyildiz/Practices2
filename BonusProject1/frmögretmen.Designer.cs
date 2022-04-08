namespace BonusProject1
{
    partial class frmögretmen
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
            this.btnDersİşlemleri = new System.Windows.Forms.Button();
            this.BtnKulüp = new System.Windows.Forms.Button();
            this.BtnSınav = new System.Windows.Forms.Button();
            this.BtnÖğretmen = new System.Windows.Forms.Button();
            this.BtnÖğrenci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDersİşlemleri
            // 
            this.btnDersİşlemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDersİşlemleri.Location = new System.Drawing.Point(3, 12);
            this.btnDersİşlemleri.Name = "btnDersİşlemleri";
            this.btnDersİşlemleri.Size = new System.Drawing.Size(196, 41);
            this.btnDersİşlemleri.TabIndex = 0;
            this.btnDersİşlemleri.Text = "Ders İşlemleri";
            this.btnDersİşlemleri.UseVisualStyleBackColor = true;
            this.btnDersİşlemleri.Click += new System.EventHandler(this.btnDersİşlemleri_Click);
            // 
            // BtnKulüp
            // 
            this.BtnKulüp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKulüp.Location = new System.Drawing.Point(3, 59);
            this.BtnKulüp.Name = "BtnKulüp";
            this.BtnKulüp.Size = new System.Drawing.Size(196, 41);
            this.BtnKulüp.TabIndex = 1;
            this.BtnKulüp.Text = "Kulüp İşlemleri";
            this.BtnKulüp.UseVisualStyleBackColor = true;
            this.BtnKulüp.Click += new System.EventHandler(this.BtnKulüp_Click);
            // 
            // BtnSınav
            // 
            this.BtnSınav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSınav.Location = new System.Drawing.Point(3, 106);
            this.BtnSınav.Name = "BtnSınav";
            this.BtnSınav.Size = new System.Drawing.Size(196, 41);
            this.BtnSınav.TabIndex = 2;
            this.BtnSınav.Text = "Sınav Notları";
            this.BtnSınav.UseVisualStyleBackColor = true;
            this.BtnSınav.Click += new System.EventHandler(this.BtnSınav_Click);
            // 
            // BtnÖğretmen
            // 
            this.BtnÖğretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnÖğretmen.Location = new System.Drawing.Point(3, 153);
            this.BtnÖğretmen.Name = "BtnÖğretmen";
            this.BtnÖğretmen.Size = new System.Drawing.Size(196, 41);
            this.BtnÖğretmen.TabIndex = 3;
            this.BtnÖğretmen.Text = "Öğretmenler ";
            this.BtnÖğretmen.UseVisualStyleBackColor = true;
            // 
            // BtnÖğrenci
            // 
            this.BtnÖğrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnÖğrenci.Location = new System.Drawing.Point(3, 200);
            this.BtnÖğrenci.Name = "BtnÖğrenci";
            this.BtnÖğrenci.Size = new System.Drawing.Size(196, 41);
            this.BtnÖğrenci.TabIndex = 4;
            this.BtnÖğrenci.Text = "Öğrenci İşleri";
            this.BtnÖğrenci.UseVisualStyleBackColor = true;
            this.BtnÖğrenci.Click += new System.EventHandler(this.BtnÖğrenci_Click);
            // 
            // frmögretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(200, 248);
            this.Controls.Add(this.BtnÖğrenci);
            this.Controls.Add(this.BtnÖğretmen);
            this.Controls.Add(this.BtnSınav);
            this.Controls.Add(this.BtnKulüp);
            this.Controls.Add(this.btnDersİşlemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmögretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmögretmen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDersİşlemleri;
        private System.Windows.Forms.Button BtnKulüp;
        private System.Windows.Forms.Button BtnSınav;
        private System.Windows.Forms.Button BtnÖğretmen;
        private System.Windows.Forms.Button BtnÖğrenci;
    }
}