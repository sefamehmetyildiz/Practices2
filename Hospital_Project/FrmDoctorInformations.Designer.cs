namespace Hospital_Project
{
    partial class FrmDoctorInformations
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RchComplaint = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAnnouncements = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Informations";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(149, 93);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(76, 23);
            this.LblNameSurname.TabIndex = 17;
            this.LblNameSurname.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name Surname:";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(149, 41);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 15;
            this.LblTC.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RchComplaint);
            this.groupBox2.Location = new System.Drawing.Point(11, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointments Informations";
            // 
            // RchComplaint
            // 
            this.RchComplaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RchComplaint.Location = new System.Drawing.Point(3, 27);
            this.RchComplaint.Name = "RchComplaint";
            this.RchComplaint.Size = new System.Drawing.Size(294, 131);
            this.RchComplaint.TabIndex = 0;
            this.RchComplaint.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(317, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 421);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointments List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnExit);
            this.groupBox4.Controls.Add(this.BtnAnnouncements);
            this.groupBox4.Controls.Add(this.BtnUpdate);
            this.groupBox4.Location = new System.Drawing.Point(11, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 115);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fast Access";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(10, 72);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(280, 36);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAnnouncements
            // 
            this.BtnAnnouncements.Font = new System.Drawing.Font("Corbel", 11F);
            this.BtnAnnouncements.Location = new System.Drawing.Point(152, 30);
            this.BtnAnnouncements.Name = "BtnAnnouncements";
            this.BtnAnnouncements.Size = new System.Drawing.Size(138, 36);
            this.BtnAnnouncements.TabIndex = 1;
            this.BtnAnnouncements.Text = "Announcements";
            this.BtnAnnouncements.UseVisualStyleBackColor = true;
            this.BtnAnnouncements.Click += new System.EventHandler(this.BtnAnnouncements_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(10, 30);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(138, 36);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "Update Information";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FrmDoctorInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1112, 444);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorInformations";
            this.Text = "Doctor Informatinos";
            this.Load += new System.EventHandler(this.FrmDoctorInformations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RchComplaint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAnnouncements;
        private System.Windows.Forms.Button BtnUpdate;
    }
}