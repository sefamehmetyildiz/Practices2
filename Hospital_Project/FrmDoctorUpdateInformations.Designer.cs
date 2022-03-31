namespace Hospital_Project
{
    partial class FrmDoctorUpdateInformations
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
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Surname:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(110, 66);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(142, 31);
            this.TxtSurname.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(110, 29);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(142, 31);
            this.TxtName.TabIndex = 27;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(110, 103);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(142, 31);
            this.MskTC.TabIndex = 26;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(110, 177);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(142, 31);
            this.TxtPassword.TabIndex = 31;
            // 
            // CmbBranch
            // 
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Location = new System.Drawing.Point(110, 140);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(142, 31);
            this.CmbBranch.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Branch:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnUpdate.Location = new System.Drawing.Point(110, 214);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(142, 33);
            this.BtnUpdate.TabIndex = 35;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FrmDoctorUpdateInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(297, 274);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbBranch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorUpdateInformations";
            this.Text = "Doctor Update Informations";
            this.Load += new System.EventHandler(this.FrmDoctorUpdateInformations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.ComboBox CmbBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUpdate;
    }
}