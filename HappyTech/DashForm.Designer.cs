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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashForm));
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbHello = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUploadDoc = new System.Windows.Forms.Label();
            this.lbDocType = new System.Windows.Forms.Label();
            this.tbAName = new System.Windows.Forms.TextBox();
            this.lbAName = new System.Windows.Forms.Label();
            this.lbAJob = new System.Windows.Forms.Label();
            this.lbAEmail = new System.Windows.Forms.Label();
            this.tbAJob = new System.Windows.Forms.TextBox();
            this.tbAEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.tempTypeBox = new System.Windows.Forms.ListBox();
            this.panelManagement = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStage3 = new System.Windows.Forms.Label();
            this.imgStage3 = new System.Windows.Forms.PictureBox();
            this.lblStage2 = new System.Windows.Forms.Label();
            this.imgStage2 = new System.Windows.Forms.PictureBox();
            this.lblStage1 = new System.Windows.Forms.Label();
            this.imgStage1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLogout = new System.Windows.Forms.Button();
            this.codeViewBtn = new System.Windows.Forms.Button();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lbJobReq = new System.Windows.Forms.Label();
            this.lbEmailReq = new System.Windows.Forms.Label();
            this.lbFullNameReq = new System.Windows.Forms.Label();
            this.panelTemplate = new System.Windows.Forms.Panel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelTemplate.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.ForeColor = System.Drawing.Color.White;
            this.btConfirm.Location = new System.Drawing.Point(26, 371);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(206, 26);
            this.btConfirm.TabIndex = 4;
            this.btConfirm.Text = "Add";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbHello.Location = new System.Drawing.Point(116, 25);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(110, 24);
            this.lbHello.TabIndex = 0;
            this.lbHello.Text = "Welcome,";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(220, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(125, 24);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "[username]";
            // 
            // lbUploadDoc
            // 
            this.lbUploadDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUploadDoc.AutoSize = true;
            this.lbUploadDoc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUploadDoc.Location = new System.Drawing.Point(21, 14);
            this.lbUploadDoc.Name = "lbUploadDoc";
            this.lbUploadDoc.Size = new System.Drawing.Size(142, 24);
            this.lbUploadDoc.TabIndex = 0;
            this.lbUploadDoc.Text = "Enter details.";
            // 
            // lbDocType
            // 
            this.lbDocType.AutoSize = true;
            this.lbDocType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocType.Location = new System.Drawing.Point(20, 14);
            this.lbDocType.Name = "lbDocType";
            this.lbDocType.Size = new System.Drawing.Size(171, 24);
            this.lbDocType.TabIndex = 0;
            this.lbDocType.Text = "Select template.";
            // 
            // tbAName
            // 
            this.tbAName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAName.Font = new System.Drawing.Font("Arial", 8.25F);
            this.tbAName.ForeColor = System.Drawing.Color.Black;
            this.tbAName.Location = new System.Drawing.Point(25, 117);
            this.tbAName.Name = "tbAName";
            this.tbAName.Size = new System.Drawing.Size(210, 20);
            this.tbAName.TabIndex = 0;
            // 
            // lbAName
            // 
            this.lbAName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAName.AutoSize = true;
            this.lbAName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbAName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lbAName.Location = new System.Drawing.Point(22, 90);
            this.lbAName.Name = "lbAName";
            this.lbAName.Size = new System.Drawing.Size(60, 14);
            this.lbAName.TabIndex = 0;
            this.lbAName.Text = "Full Name";
            // 
            // lbAJob
            // 
            this.lbAJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAJob.AutoSize = true;
            this.lbAJob.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbAJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lbAJob.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAJob.Location = new System.Drawing.Point(22, 239);
            this.lbAJob.Name = "lbAJob";
            this.lbAJob.Size = new System.Drawing.Size(75, 14);
            this.lbAJob.TabIndex = 0;
            this.lbAJob.Text = "Job Position";
            // 
            // lbAEmail
            // 
            this.lbAEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAEmail.AutoSize = true;
            this.lbAEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbAEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lbAEmail.Location = new System.Drawing.Point(22, 166);
            this.lbAEmail.Name = "lbAEmail";
            this.lbAEmail.Size = new System.Drawing.Size(36, 14);
            this.lbAEmail.TabIndex = 0;
            this.lbAEmail.Text = "Email";
            // 
            // tbAJob
            // 
            this.tbAJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAJob.Font = new System.Drawing.Font("Arial", 8.25F);
            this.tbAJob.ForeColor = System.Drawing.Color.Black;
            this.tbAJob.Location = new System.Drawing.Point(25, 267);
            this.tbAJob.Name = "tbAJob";
            this.tbAJob.Size = new System.Drawing.Size(210, 20);
            this.tbAJob.TabIndex = 2;
            // 
            // tbAEmail
            // 
            this.tbAEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAEmail.Font = new System.Drawing.Font("Arial", 8.25F);
            this.tbAEmail.ForeColor = System.Drawing.Color.Black;
            this.tbAEmail.Location = new System.Drawing.Point(25, 193);
            this.tbAEmail.Name = "tbAEmail";
            this.tbAEmail.Size = new System.Drawing.Size(210, 20);
            this.tbAEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(840, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dashboard";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbError.Location = new System.Drawing.Point(23, 322);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(136, 14);
            this.lbError.TabIndex = 0;
            this.lbError.Text = "Missing required fields";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbError.Visible = false;
            // 
            // btBack
            // 
            this.btBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Location = new System.Drawing.Point(26, 339);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(206, 26);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Cancel";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Visible = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // tempTypeBox
            // 
            this.tempTypeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempTypeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tempTypeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tempTypeBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.tempTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.tempTypeBox.FormattingEnabled = true;
            this.tempTypeBox.ItemHeight = 32;
            this.tempTypeBox.Location = new System.Drawing.Point(24, 87);
            this.tempTypeBox.Name = "tempTypeBox";
            this.tempTypeBox.Size = new System.Drawing.Size(214, 298);
            this.tempTypeBox.TabIndex = 3;
            this.tempTypeBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tempTypeBox_DrawItem);
            // 
            // panelManagement
            // 
            this.panelManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            this.panelManagement.Controls.Add(this.label3);
            this.panelManagement.Controls.Add(this.lblStage3);
            this.panelManagement.Controls.Add(this.imgStage3);
            this.panelManagement.Controls.Add(this.lblStage2);
            this.panelManagement.Controls.Add(this.imgStage2);
            this.panelManagement.Controls.Add(this.lblStage1);
            this.panelManagement.Controls.Add(this.imgStage1);
            this.panelManagement.Controls.Add(this.pictureBox1);
            this.panelManagement.Controls.Add(this.btLogout);
            this.panelManagement.Controls.Add(this.codeViewBtn);
            this.panelManagement.Location = new System.Drawing.Point(0, 0);
            this.panelManagement.Name = "panelManagement";
            this.panelManagement.Size = new System.Drawing.Size(100, 564);
            this.panelManagement.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(10, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 2);
            this.label3.TabIndex = 37;
            // 
            // lblStage3
            // 
            this.lblStage3.AutoSize = true;
            this.lblStage3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStage3.ForeColor = System.Drawing.Color.White;
            this.lblStage3.Location = new System.Drawing.Point(24, 370);
            this.lblStage3.Name = "lblStage3";
            this.lblStage3.Size = new System.Drawing.Size(52, 14);
            this.lblStage3.TabIndex = 0;
            this.lblStage3.Text = "Preview";
            // 
            // imgStage3
            // 
            this.imgStage3.Image = global::HappyTech.Properties.Resources.happytech_3;
            this.imgStage3.Location = new System.Drawing.Point(42, 347);
            this.imgStage3.Name = "imgStage3";
            this.imgStage3.Size = new System.Drawing.Size(16, 16);
            this.imgStage3.TabIndex = 42;
            this.imgStage3.TabStop = false;
            // 
            // lblStage2
            // 
            this.lblStage2.AutoSize = true;
            this.lblStage2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStage2.ForeColor = System.Drawing.Color.White;
            this.lblStage2.Location = new System.Drawing.Point(19, 258);
            this.lblStage2.Name = "lblStage2";
            this.lblStage2.Size = new System.Drawing.Size(60, 14);
            this.lblStage2.TabIndex = 0;
            this.lblStage2.Text = "Feedback";
            // 
            // imgStage2
            // 
            this.imgStage2.Image = global::HappyTech.Properties.Resources.happytech_2;
            this.imgStage2.Location = new System.Drawing.Point(42, 235);
            this.imgStage2.Name = "imgStage2";
            this.imgStage2.Size = new System.Drawing.Size(16, 16);
            this.imgStage2.TabIndex = 40;
            this.imgStage2.TabStop = false;
            // 
            // lblStage1
            // 
            this.lblStage1.AutoSize = true;
            this.lblStage1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStage1.ForeColor = System.Drawing.Color.White;
            this.lblStage1.Location = new System.Drawing.Point(17, 146);
            this.lblStage1.Name = "lblStage1";
            this.lblStage1.Size = new System.Drawing.Size(65, 14);
            this.lblStage1.TabIndex = 0;
            this.lblStage1.Text = "Applicants";
            // 
            // imgStage1
            // 
            this.imgStage1.Image = global::HappyTech.Properties.Resources.happytech_1;
            this.imgStage1.Location = new System.Drawing.Point(42, 123);
            this.imgStage1.Name = "imgStage1";
            this.imgStage1.Size = new System.Drawing.Size(16, 16);
            this.imgStage1.TabIndex = 37;
            this.imgStage1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyTech.Properties.Resources.happytech_logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            this.btLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Image = global::HappyTech.Properties.Resources.happytech_logout;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(10, 522);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(80, 32);
            this.btLogout.TabIndex = 7;
            this.btLogout.Text = "Logout";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // codeViewBtn
            // 
            this.codeViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            this.codeViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.codeViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.codeViewBtn.FlatAppearance.BorderSize = 0;
            this.codeViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeViewBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.codeViewBtn.ForeColor = System.Drawing.Color.White;
            this.codeViewBtn.Image = global::HappyTech.Properties.Resources.happytech_edit;
            this.codeViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.codeViewBtn.Location = new System.Drawing.Point(10, 482);
            this.codeViewBtn.Name = "codeViewBtn";
            this.codeViewBtn.Size = new System.Drawing.Size(80, 32);
            this.codeViewBtn.TabIndex = 6;
            this.codeViewBtn.Text = "Editor";
            this.codeViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.codeViewBtn.UseVisualStyleBackColor = false;
            this.codeViewBtn.Click += new System.EventHandler(this.codeViewBtn_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.Controls.Add(this.lbJobReq);
            this.panelDetails.Controls.Add(this.lbEmailReq);
            this.panelDetails.Controls.Add(this.lbFullNameReq);
            this.panelDetails.Controls.Add(this.lbAName);
            this.panelDetails.Controls.Add(this.lbUploadDoc);
            this.panelDetails.Controls.Add(this.tbAJob);
            this.panelDetails.Controls.Add(this.lbAJob);
            this.panelDetails.Controls.Add(this.tbAName);
            this.panelDetails.Controls.Add(this.lbAEmail);
            this.panelDetails.Controls.Add(this.tbAEmail);
            this.panelDetails.Location = new System.Drawing.Point(120, 98);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(260, 418);
            this.panelDetails.TabIndex = 0;
            // 
            // lbJobReq
            // 
            this.lbJobReq.AutoSize = true;
            this.lbJobReq.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbJobReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbJobReq.Location = new System.Drawing.Point(93, 239);
            this.lbJobReq.Name = "lbJobReq";
            this.lbJobReq.Size = new System.Drawing.Size(11, 14);
            this.lbJobReq.TabIndex = 0;
            this.lbJobReq.Text = "*";
            // 
            // lbEmailReq
            // 
            this.lbEmailReq.AutoSize = true;
            this.lbEmailReq.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbEmailReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbEmailReq.Location = new System.Drawing.Point(54, 166);
            this.lbEmailReq.Name = "lbEmailReq";
            this.lbEmailReq.Size = new System.Drawing.Size(11, 14);
            this.lbEmailReq.TabIndex = 0;
            this.lbEmailReq.Text = "*";
            // 
            // lbFullNameReq
            // 
            this.lbFullNameReq.AutoSize = true;
            this.lbFullNameReq.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbFullNameReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbFullNameReq.Location = new System.Drawing.Point(78, 90);
            this.lbFullNameReq.Name = "lbFullNameReq";
            this.lbFullNameReq.Size = new System.Drawing.Size(11, 14);
            this.lbFullNameReq.TabIndex = 0;
            this.lbFullNameReq.Text = "*";
            // 
            // panelTemplate
            // 
            this.panelTemplate.BackColor = System.Drawing.Color.White;
            this.panelTemplate.Controls.Add(this.tempTypeBox);
            this.panelTemplate.Controls.Add(this.lbDocType);
            this.panelTemplate.Location = new System.Drawing.Point(412, 98);
            this.panelTemplate.Name = "panelTemplate";
            this.panelTemplate.Size = new System.Drawing.Size(260, 418);
            this.panelTemplate.TabIndex = 0;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.White;
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.btConfirm);
            this.panelAdd.Controls.Add(this.btBack);
            this.panelAdd.Controls.Add(this.lbError);
            this.panelAdd.Location = new System.Drawing.Point(701, 98);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(260, 418);
            this.panelAdd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add applicant.";
            // 
            // DashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelTemplate);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.lbHello);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.panelManagement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "DashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.panelManagement.ResumeLayout(false);
            this.panelManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelTemplate.ResumeLayout(false);
            this.panelTemplate.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUploadDoc;
        private System.Windows.Forms.Label lbDocType;
        private System.Windows.Forms.TextBox tbAName;
        private System.Windows.Forms.Label lbAName;
        private System.Windows.Forms.Label lbAJob;
        private System.Windows.Forms.Label lbAEmail;
        private System.Windows.Forms.TextBox tbAJob;
        private System.Windows.Forms.TextBox tbAEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button codeViewBtn;
        private System.Windows.Forms.ListBox tempTypeBox;
        private System.Windows.Forms.Panel panelManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelTemplate;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStage1;
        private System.Windows.Forms.PictureBox imgStage1;
        private System.Windows.Forms.Label lblStage3;
        private System.Windows.Forms.PictureBox imgStage3;
        private System.Windows.Forms.Label lblStage2;
        private System.Windows.Forms.PictureBox imgStage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFullNameReq;
        private System.Windows.Forms.Label lbEmailReq;
        private System.Windows.Forms.Label lbJobReq;
    }
}