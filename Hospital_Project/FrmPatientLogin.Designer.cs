namespace Hospital_Project
{
    partial class FrmPatientLogin
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
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LnkSignUp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(153, 82);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(142, 31);
            this.MskTC.TabIndex = 0;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(153, 119);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(142, 31);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(204, 156);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(91, 34);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patient Login Panel";
            // 
            // LnkSignUp
            // 
            this.LnkSignUp.AutoSize = true;
            this.LnkSignUp.Location = new System.Drawing.Point(301, 127);
            this.LnkSignUp.Name = "LnkSignUp";
            this.LnkSignUp.Size = new System.Drawing.Size(70, 23);
            this.LnkSignUp.TabIndex = 3;
            this.LnkSignUp.TabStop = true;
            this.LnkSignUp.Text = "Sign Up";
            this.LnkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSignUp_LinkClicked);
            // 
            // FrmPatientLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(425, 210);
            this.Controls.Add(this.LnkSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmPatientLogin";
            this.Text = "Patient Login";
            this.Load += new System.EventHandler(this.FrmPatientLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LnkSignUp;
    }
}