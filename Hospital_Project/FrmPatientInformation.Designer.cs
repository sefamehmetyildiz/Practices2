namespace Hospital_Project
{
    partial class FrmPatientInformation
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
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LnkUpdate = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnMaAppointment = new System.Windows.Forms.Button();
            this.RchComplaint = new System.Windows.Forms.RichTextBox();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Information";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(148, 101);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(76, 23);
            this.LblNameSurname.TabIndex = 13;
            this.LblNameSurname.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name Surname:";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(148, 49);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 11;
            this.LblTC.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LnkUpdate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BtnMaAppointment);
            this.groupBox2.Controls.Add(this.RchComplaint);
            this.groupBox2.Controls.Add(this.CmbDoctor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CmbBranch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Panel";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(108, 28);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(171, 31);
            this.TxtID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            // 
            // LnkUpdate
            // 
            this.LnkUpdate.AutoSize = true;
            this.LnkUpdate.Location = new System.Drawing.Point(90, 284);
            this.LnkUpdate.Name = "LnkUpdate";
            this.LnkUpdate.Size = new System.Drawing.Size(202, 23);
            this.LnkUpdate.TabIndex = 18;
            this.LnkUpdate.TabStop = true;
            this.LnkUpdate.Text = "Update My Informations";
            this.LnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUpdate_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Complaint:";
            // 
            // BtnMaAppointment
            // 
            this.BtnMaAppointment.Location = new System.Drawing.Point(108, 231);
            this.BtnMaAppointment.Name = "BtnMaAppointment";
            this.BtnMaAppointment.Size = new System.Drawing.Size(171, 54);
            this.BtnMaAppointment.TabIndex = 16;
            this.BtnMaAppointment.Text = "Make An Appointment";
            this.BtnMaAppointment.UseVisualStyleBackColor = true;
            this.BtnMaAppointment.Click += new System.EventHandler(this.BtnMaAppointment_Click);
            // 
            // RchComplaint
            // 
            this.RchComplaint.Location = new System.Drawing.Point(108, 132);
            this.RchComplaint.Name = "RchComplaint";
            this.RchComplaint.Size = new System.Drawing.Size(171, 93);
            this.RchComplaint.TabIndex = 15;
            this.RchComplaint.Text = "";
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(108, 97);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(171, 31);
            this.CmbDoctor.TabIndex = 14;
            this.CmbDoctor.SelectedIndexChanged += new System.EventHandler(this.CmbDoctor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Doctor:";
            // 
            // CmbBranch
            // 
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Location = new System.Drawing.Point(108, 63);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(171, 31);
            this.CmbBranch.TabIndex = 12;
            this.CmbBranch.SelectedIndexChanged += new System.EventHandler(this.CmbBranch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Branch:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(316, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 243);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(316, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(479, 247);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Appointments";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(473, 217);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // FrmPatientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(807, 510);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmPatientInformation";
            this.Text = "Patient Information";
            this.Load += new System.EventHandler(this.FrmPatientInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LnkUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnMaAppointment;
        private System.Windows.Forms.RichTextBox RchComplaint;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbBranch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
    }
}