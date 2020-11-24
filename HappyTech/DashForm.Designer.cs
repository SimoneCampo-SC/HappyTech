namespace HappyTech
{
    partial class DashForm
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
            this.btLogout = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbHello = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUploadDoc = new System.Windows.Forms.Label();
            this.lbDocType = new System.Windows.Forms.Label();
            this.tbAName = new System.Windows.Forms.TextBox();
            this.lbAName = new System.Windows.Forms.Label();
            this.lbAJob = new System.Windows.Forms.Label();
            this.lbAEmail = new System.Windows.Forms.Label();
            this.tbAJob = new System.Windows.Forms.TextBox();
            this.tbAEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.codeViewBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tempTypeBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Location = new System.Drawing.Point(858, 19);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(104, 32);
            this.btLogout.TabIndex = 0;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.ForeColor = System.Drawing.Color.White;
            this.btConfirm.Location = new System.Drawing.Point(70, 299);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(169, 32);
            this.btConfirm.TabIndex = 1;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.Location = new System.Drawing.Point(6, 29);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(97, 22);
            this.lbHello.TabIndex = 6;
            this.lbHello.Text = "Welcome,";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(97, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(108, 23);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "[username]";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // lbUploadDoc
            // 
            this.lbUploadDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUploadDoc.AutoSize = true;
            this.lbUploadDoc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUploadDoc.Location = new System.Drawing.Point(49, 22);
            this.lbUploadDoc.Name = "lbUploadDoc";
            this.lbUploadDoc.Size = new System.Drawing.Size(179, 24);
            this.lbUploadDoc.TabIndex = 11;
            this.lbUploadDoc.Text = "Applicant Details";
            // 
            // lbDocType
            // 
            this.lbDocType.AutoSize = true;
            this.lbDocType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocType.Location = new System.Drawing.Point(66, 22);
            this.lbDocType.Name = "lbDocType";
            this.lbDocType.Size = new System.Drawing.Size(154, 24);
            this.lbDocType.TabIndex = 15;
            this.lbDocType.Text = "Template Type";
            // 
            // tbAName
            // 
            this.tbAName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAName.Location = new System.Drawing.Point(45, 112);
            this.tbAName.Name = "tbAName";
            this.tbAName.Size = new System.Drawing.Size(212, 20);
            this.tbAName.TabIndex = 16;
            // 
            // lbAName
            // 
            this.lbAName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAName.AutoSize = true;
            this.lbAName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lbAName.Location = new System.Drawing.Point(42, 94);
            this.lbAName.Name = "lbAName";
            this.lbAName.Size = new System.Drawing.Size(67, 15);
            this.lbAName.TabIndex = 17;
            this.lbAName.Text = "Full Name*";
            // 
            // lbAJob
            // 
            this.lbAJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAJob.AutoSize = true;
            this.lbAJob.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lbAJob.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAJob.Location = new System.Drawing.Point(42, 232);
            this.lbAJob.Name = "lbAJob";
            this.lbAJob.Size = new System.Drawing.Size(82, 15);
            this.lbAJob.TabIndex = 18;
            this.lbAJob.Text = "Job Position*";
            // 
            // lbAEmail
            // 
            this.lbAEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAEmail.AutoSize = true;
            this.lbAEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lbAEmail.Location = new System.Drawing.Point(42, 161);
            this.lbAEmail.Name = "lbAEmail";
            this.lbAEmail.Size = new System.Drawing.Size(43, 15);
            this.lbAEmail.TabIndex = 19;
            this.lbAEmail.Text = "Email*";
            // 
            // tbAJob
            // 
            this.tbAJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAJob.Location = new System.Drawing.Point(45, 250);
            this.tbAJob.Name = "tbAJob";
            this.tbAJob.Size = new System.Drawing.Size(212, 20);
            this.tbAJob.TabIndex = 20;
            // 
            // tbAEmail
            // 
            this.tbAEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAEmail.Location = new System.Drawing.Point(45, 180);
            this.tbAEmail.Name = "tbAEmail";
            this.tbAEmail.Size = new System.Drawing.Size(212, 20);
            this.tbAEmail.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "HAPPY-TECH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dashboard";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbError.Location = new System.Drawing.Point(401, 16);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(196, 16);
            this.lbError.TabIndex = 26;
            this.lbError.Text = "All the fields must be inserted";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbError.Visible = false;
            // 
            // btBack
            // 
            this.btBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Location = new System.Drawing.Point(69, 299);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(150, 32);
            this.btBack.TabIndex = 27;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Visible = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // codeViewBtn
            // 
            this.codeViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.codeViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeViewBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeViewBtn.ForeColor = System.Drawing.Color.White;
            this.codeViewBtn.Location = new System.Drawing.Point(753, 19);
            this.codeViewBtn.Name = "codeViewBtn";
            this.codeViewBtn.Size = new System.Drawing.Size(99, 32);
            this.codeViewBtn.TabIndex = 28;
            this.codeViewBtn.Text = "Editor";
            this.codeViewBtn.UseVisualStyleBackColor = false;
            this.codeViewBtn.Click += new System.EventHandler(this.codeViewBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lbUploadDoc);
            this.groupBox1.Controls.Add(this.lbAName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btBack);
            this.groupBox1.Controls.Add(this.tbAName);
            this.groupBox1.Controls.Add(this.lbAJob);
            this.groupBox1.Controls.Add(this.lbAEmail);
            this.groupBox1.Controls.Add(this.tbAJob);
            this.groupBox1.Controls.Add(this.tbAEmail);
            this.groupBox1.Location = new System.Drawing.Point(128, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 380);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tempTypeBox);
            this.groupBox2.Controls.Add(this.lbDocType);
            this.groupBox2.Controls.Add(this.btConfirm);
            this.groupBox2.Location = new System.Drawing.Point(577, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 380);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // tempTypeBox
            // 
            this.tempTypeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempTypeBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tempTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.tempTypeBox.FormattingEnabled = true;
            this.tempTypeBox.ItemHeight = 16;
            this.tempTypeBox.Location = new System.Drawing.Point(53, 80);
            this.tempTypeBox.Name = "tempTypeBox";
            this.tempTypeBox.Size = new System.Drawing.Size(197, 194);
            this.tempTypeBox.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbHello);
            this.groupBox3.Controls.Add(this.codeViewBtn);
            this.groupBox3.Controls.Add(this.btLogout);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(-2, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(984, 64);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbError);
            this.groupBox4.Location = new System.Drawing.Point(-2, 501);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(984, 70);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            // 
            // DashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "DashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUploadDoc;
        private System.Windows.Forms.Label lbDocType;
        private System.Windows.Forms.TextBox tbAName;
        private System.Windows.Forms.Label lbAName;
        private System.Windows.Forms.Label lbAJob;
        private System.Windows.Forms.Label lbAEmail;
        private System.Windows.Forms.TextBox tbAJob;
        private System.Windows.Forms.TextBox tbAEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button codeViewBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox tempTypeBox;
    }
}