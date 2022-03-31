namespace Hospital_Project
{
    partial class FrmSecretaryInformations
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
            this.BtnCreateAnnouncement = new System.Windows.Forms.Button();
            this.RchAnnouncement = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ChkStatus = new System.Windows.Forms.CheckBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.MskTime = new System.Windows.Forms.MaskedTextBox();
            this.MskDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnAppointmentList = new System.Windows.Forms.Button();
            this.BtnBranchPanel = new System.Windows.Forms.Button();
            this.BtnDoctorPanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Informations";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(148, 94);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(76, 23);
            this.LblNameSurname.TabIndex = 17;
            this.LblNameSurname.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name Surname:";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(148, 42);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 15;
            this.LblTC.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCreateAnnouncement);
            this.groupBox2.Controls.Add(this.RchAnnouncement);
            this.groupBox2.Location = new System.Drawing.Point(11, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcement";
            // 
            // BtnCreateAnnouncement
            // 
            this.BtnCreateAnnouncement.Location = new System.Drawing.Point(6, 201);
            this.BtnCreateAnnouncement.Name = "BtnCreateAnnouncement";
            this.BtnCreateAnnouncement.Size = new System.Drawing.Size(273, 34);
            this.BtnCreateAnnouncement.TabIndex = 1;
            this.BtnCreateAnnouncement.Text = "Create";
            this.BtnCreateAnnouncement.UseVisualStyleBackColor = true;
            this.BtnCreateAnnouncement.Click += new System.EventHandler(this.BtnCreateAnnouncement_Click);
            // 
            // RchAnnouncement
            // 
            this.RchAnnouncement.Location = new System.Drawing.Point(6, 30);
            this.RchAnnouncement.Name = "RchAnnouncement";
            this.RchAnnouncement.Size = new System.Drawing.Size(273, 165);
            this.RchAnnouncement.TabIndex = 0;
            this.RchAnnouncement.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Controls.Add(this.ChkStatus);
            this.groupBox3.Controls.Add(this.MskTC);
            this.groupBox3.Controls.Add(this.CmbDoctor);
            this.groupBox3.Controls.Add(this.CmbBranch);
            this.groupBox3.Controls.Add(this.MskTime);
            this.groupBox3.Controls.Add(this.MskDate);
            this.groupBox3.Controls.Add(this.TxtID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(302, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 399);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Panel";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(96, 317);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(173, 55);
            this.BtnSave.TabIndex = 32;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.Location = new System.Drawing.Point(145, 284);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(80, 27);
            this.ChkStatus.TabIndex = 31;
            this.ChkStatus.Text = "Status";
            this.ChkStatus.UseVisualStyleBackColor = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(100, 247);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(169, 31);
            this.MskTC.TabIndex = 30;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(100, 210);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(169, 31);
            this.CmbDoctor.TabIndex = 29;
            // 
            // CmbBranch
            // 
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Location = new System.Drawing.Point(100, 173);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(169, 31);
            this.CmbBranch.TabIndex = 28;
            this.CmbBranch.SelectedIndexChanged += new System.EventHandler(this.CmbBranch_SelectedIndexChanged);
            // 
            // MskTime
            // 
            this.MskTime.Location = new System.Drawing.Point(100, 136);
            this.MskTime.Mask = "00:00";
            this.MskTime.Name = "MskTime";
            this.MskTime.Size = new System.Drawing.Size(169, 31);
            this.MskTime.TabIndex = 27;
            this.MskTime.ValidatingType = typeof(System.DateTime);
            // 
            // MskDate
            // 
            this.MskDate.Location = new System.Drawing.Point(100, 101);
            this.MskDate.Mask = "00/00/0000";
            this.MskDate.Name = "MskDate";
            this.MskDate.Size = new System.Drawing.Size(169, 31);
            this.MskDate.TabIndex = 26;
            this.MskDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(100, 65);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(169, 31);
            this.TxtID.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "DOCTOR:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "BRANCH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "TIME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "DATE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(583, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 209);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branchs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(583, 223);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 291);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 261);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.BtnAppointmentList);
            this.groupBox6.Controls.Add(this.BtnBranchPanel);
            this.groupBox6.Controls.Add(this.BtnDoctorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 421);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(565, 89);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fast Access";
            // 
            // BtnAppointmentList
            // 
            this.BtnAppointmentList.Location = new System.Drawing.Point(259, 30);
            this.BtnAppointmentList.Name = "BtnAppointmentList";
            this.BtnAppointmentList.Size = new System.Drawing.Size(156, 40);
            this.BtnAppointmentList.TabIndex = 2;
            this.BtnAppointmentList.Text = "Appointment List";
            this.BtnAppointmentList.UseVisualStyleBackColor = true;
            this.BtnAppointmentList.Click += new System.EventHandler(this.BtnAppointmentList_Click);
            // 
            // BtnBranchPanel
            // 
            this.BtnBranchPanel.Location = new System.Drawing.Point(131, 30);
            this.BtnBranchPanel.Name = "BtnBranchPanel";
            this.BtnBranchPanel.Size = new System.Drawing.Size(125, 40);
            this.BtnBranchPanel.TabIndex = 1;
            this.BtnBranchPanel.Text = "Branch Panel";
            this.BtnBranchPanel.UseVisualStyleBackColor = true;
            this.BtnBranchPanel.Click += new System.EventHandler(this.BtnBranchPanel_Click);
            // 
            // BtnDoctorPanel
            // 
            this.BtnDoctorPanel.Location = new System.Drawing.Point(3, 30);
            this.BtnDoctorPanel.Name = "BtnDoctorPanel";
            this.BtnDoctorPanel.Size = new System.Drawing.Size(125, 40);
            this.BtnDoctorPanel.TabIndex = 0;
            this.BtnDoctorPanel.Text = "Doctor Panel";
            this.BtnDoctorPanel.UseVisualStyleBackColor = true;
            this.BtnDoctorPanel.Click += new System.EventHandler(this.BtnDoctorPanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Announcements";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSecretaryInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(947, 520);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSecretaryInformations";
            this.Text = "Secretary Informations";
            this.Load += new System.EventHandler(this.FrmSecretaryInformations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCreateAnnouncement;
        private System.Windows.Forms.RichTextBox RchAnnouncement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox MskDate;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox ChkStatus;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.ComboBox CmbBranch;
        private System.Windows.Forms.MaskedTextBox MskTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnAppointmentList;
        private System.Windows.Forms.Button BtnBranchPanel;
        private System.Windows.Forms.Button BtnDoctorPanel;
        private System.Windows.Forms.Button button1;
    }
}