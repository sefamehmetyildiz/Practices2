namespace Quiz_Program
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblFalse = new System.Windows.Forms.Label();
            this.lblTrue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 5);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(507, 188);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(264, 201);
            this.BtnB.Margin = new System.Windows.Forms.Padding(4);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(229, 68);
            this.BtnB.TabIndex = 1;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(30, 277);
            this.BtnC.Margin = new System.Windows.Forms.Padding(4);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(229, 68);
            this.BtnC.TabIndex = 2;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(30, 201);
            this.BtnA.Margin = new System.Windows.Forms.Padding(4);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(229, 68);
            this.BtnA.TabIndex = 3;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(264, 277);
            this.BtnD.Margin = new System.Windows.Forms.Padding(4);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(231, 68);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(539, 157);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(205, 66);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "START";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(606, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "TRUE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(606, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "FALSE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(569, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUESTION:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestion.Location = new System.Drawing.Point(667, 10);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(36, 42);
            this.lblQuestion.TabIndex = 9;
            this.lblQuestion.Text = "0";
            // 
            // lblFalse
            // 
            this.lblFalse.AutoSize = true;
            this.lblFalse.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFalse.Location = new System.Drawing.Point(667, 102);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(36, 42);
            this.lblFalse.TabIndex = 10;
            this.lblFalse.Text = "0";
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrue.Location = new System.Drawing.Point(667, 54);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(36, 42);
            this.lblTrue.TabIndex = 11;
            this.lblTrue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(638, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(774, 355);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTrue);
            this.Controls.Add(this.lblFalse);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblFalse;
        private System.Windows.Forms.Label lblTrue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

