namespace BonusProject1
{
    partial class frmÖğrenci
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
            this.txtOGRAd = new System.Windows.Forms.TextBox();
            this.txtOGRId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOGRsoyad = new System.Windows.Forms.TextBox();
            this.cmbKulüp = new System.Windows.Forms.ComboBox();
            this.radioButtonKız = new System.Windows.Forms.RadioButton();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOGRAd
            // 
            this.txtOGRAd.Location = new System.Drawing.Point(87, 44);
            this.txtOGRAd.Name = "txtOGRAd";
            this.txtOGRAd.Size = new System.Drawing.Size(228, 20);
            this.txtOGRAd.TabIndex = 29;
            // 
            // txtOGRId
            // 
            this.txtOGRId.Enabled = false;
            this.txtOGRId.Location = new System.Drawing.Point(87, 9);
            this.txtOGRId.Name = "txtOGRId";
            this.txtOGRId.Size = new System.Drawing.Size(228, 20);
            this.txtOGRId.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = " Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Öğrenci ID:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(233, 56);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(227, 40);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(233, 12);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(227, 40);
            this.btnGüncelle.TabIndex = 24;
            this.btnGüncelle.Text = "Güncelle ";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(3, 56);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(227, 40);
            this.BtnEkle.TabIndex = 23;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(280, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Öğrenci İşlemleri Paneli";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(3, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(227, 40);
            this.btnListele.TabIndex = 21;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 197);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kulübü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Soyad:";
            // 
            // txtOGRsoyad
            // 
            this.txtOGRsoyad.Location = new System.Drawing.Point(87, 80);
            this.txtOGRsoyad.Name = "txtOGRsoyad";
            this.txtOGRsoyad.Size = new System.Drawing.Size(228, 20);
            this.txtOGRsoyad.TabIndex = 32;
            // 
            // cmbKulüp
            // 
            this.cmbKulüp.FormattingEnabled = true;
            this.cmbKulüp.Location = new System.Drawing.Point(87, 117);
            this.cmbKulüp.Name = "cmbKulüp";
            this.cmbKulüp.Size = new System.Drawing.Size(228, 21);
            this.cmbKulüp.TabIndex = 33;
            // 
            // radioButtonKız
            // 
            this.radioButtonKız.AutoSize = true;
            this.radioButtonKız.Location = new System.Drawing.Point(89, 152);
            this.radioButtonKız.Name = "radioButtonKız";
            this.radioButtonKız.Size = new System.Drawing.Size(39, 17);
            this.radioButtonKız.TabIndex = 34;
            this.radioButtonKız.TabStop = true;
            this.radioButtonKız.Text = "Kız";
            this.radioButtonKız.UseVisualStyleBackColor = true;
            this.radioButtonKız.CheckedChanged += new System.EventHandler(this.radioButtonKız_CheckedChanged);
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(134, 152);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(53, 17);
            this.radioButtonErkek.TabIndex = 35;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            this.radioButtonErkek.CheckedChanged += new System.EventHandler(this.radioButtonErkek_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cinsiyet:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radioButtonErkek);
            this.panel1.Controls.Add(this.radioButtonKız);
            this.panel1.Controls.Add(this.cmbKulüp);
            this.panel1.Controls.Add(this.txtOGRsoyad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtOGRAd);
            this.panel1.Controls.Add(this.txtOGRId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(465, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 178);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.btnAra);
            this.panel2.Controls.Add(this.txtAra);
            this.panel2.Controls.Add(this.btnListele);
            this.panel2.Controls.Add(this.btnGüncelle);
            this.panel2.Controls.Add(this.BtnEkle);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Location = new System.Drawing.Point(2, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 177);
            this.panel2.TabIndex = 38;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(10, 117);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(243, 20);
            this.txtAra.TabIndex = 29;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(272, 106);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(158, 40);
            this.btnAra.TabIndex = 30;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmÖğrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmÖğrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmÖğrenci";
            this.Load += new System.EventHandler(this.frmÖğrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOGRAd;
        private System.Windows.Forms.TextBox txtOGRId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOGRsoyad;
        private System.Windows.Forms.ComboBox cmbKulüp;
        private System.Windows.Forms.RadioButton radioButtonKız;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
    }
}