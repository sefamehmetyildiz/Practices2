namespace Hospital_Project
{
    partial class FrmBranchPanel
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBranchName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBranchID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnDelete.Location = new System.Drawing.Point(205, 86);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(73, 47);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAdd.Location = new System.Drawing.Point(129, 86);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(73, 47);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 160);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnUpdate.Location = new System.Drawing.Point(129, 139);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(149, 33);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "BranchName:";
            // 
            // TxtBranchName
            // 
            this.TxtBranchName.Location = new System.Drawing.Point(129, 49);
            this.TxtBranchName.Name = "TxtBranchName";
            this.TxtBranchName.Size = new System.Drawing.Size(149, 31);
            this.TxtBranchName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "BranchID:";
            // 
            // TxtBranchID
            // 
            this.TxtBranchID.Location = new System.Drawing.Point(129, 12);
            this.TxtBranchID.Name = "TxtBranchID";
            this.TxtBranchID.Size = new System.Drawing.Size(149, 31);
            this.TxtBranchID.TabIndex = 0;
            // 
            // FrmBranchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 184);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBranchName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBranchID);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmBranchPanel";
            this.Text = "Branch Panel";
            this.Load += new System.EventHandler(this.FrmBranchPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBranchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBranchID;
    }
}