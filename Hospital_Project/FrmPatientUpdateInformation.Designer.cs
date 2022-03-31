namespace Hospital_Project
{
    partial class FrmPatientUpdateInformation
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnUpdate.Location = new System.Drawing.Point(114, 253);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(169, 33);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.CmbGender.Location = new System.Drawing.Point(114, 216);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(169, 31);
            this.CmbGender.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Phone:";
            // 
            // MskPhone
            // 
            this.MskPhone.Location = new System.Drawing.Point(114, 142);
            this.MskPhone.Mask = "(999) 000-0000";
            this.MskPhone.Name = "MskPhone";
            this.MskPhone.Size = new System.Drawing.Size(169, 31);
            this.MskPhone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(114, 179);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(169, 31);
            this.TxtPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Surname:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(114, 68);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(169, 31);
            this.TxtSurname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(114, 31);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(169, 31);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gender:";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(114, 105);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(169, 31);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "TC:";
            // 
            // FrmPatientUpdateInformation
            // 
            this.AcceptButton = this.BtnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(295, 302);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmPatientUpdateInformation";
            this.Text = "Update Information";
            this.Load += new System.EventHandler(this.FrmPatientUpdateInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
    }
}