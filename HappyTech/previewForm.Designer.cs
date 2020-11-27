namespace HappyTech
{
    partial class previewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(previewForm));
            this.checklistAppPreview = new System.Windows.Forms.CheckedListBox();
            this.previewBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panelManagement = new System.Windows.Forms.Panel();
            this.lblStage3 = new System.Windows.Forms.Label();
            this.imgStage3 = new System.Windows.Forms.PictureBox();
            this.lblStage2 = new System.Windows.Forms.Label();
            this.imgStage2 = new System.Windows.Forms.PictureBox();
            this.lblStage1 = new System.Windows.Forms.Label();
            this.imgStage1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPreviewList = new System.Windows.Forms.Panel();
            this.lblFeedbackList = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.panelPreviewAction = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            this.btnDash = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.panelSubmit = new System.Windows.Forms.Panel();
            this.lblAppTotalVal = new System.Windows.Forms.Label();
            this.lblAppTotal = new System.Windows.Forms.Label();
            this.lblRecruiterVal = new System.Windows.Forms.Label();
            this.lblRecruiter = new System.Windows.Forms.Label();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.panelManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPreviewList.SuspendLayout();
            this.panelPreviewAction.SuspendLayout();
            this.panelSubmit.SuspendLayout();
            this.SuspendLayout();
            // 
            // checklistAppPreview
            // 
            this.checklistAppPreview.CheckOnClick = true;
            this.checklistAppPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checklistAppPreview.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.checklistAppPreview.FormattingEnabled = true;
            this.checklistAppPreview.Location = new System.Drawing.Point(26, 70);
            this.checklistAppPreview.Name = "checklistAppPreview";
            this.checklistAppPreview.Size = new System.Drawing.Size(553, 424);
            this.checklistAppPreview.TabIndex = 0;
            this.checklistAppPreview.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklistAppPreview_ItemCheck);
            this.checklistAppPreview.SelectedValueChanged += new System.EventHandler(this.checklistAppPreview_SelectedValueChanged);
            // 
            // previewBtn
            // 
            this.previewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.previewBtn.FlatAppearance.BorderSize = 0;
            this.previewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previewBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.previewBtn.ForeColor = System.Drawing.Color.White;
            this.previewBtn.Location = new System.Drawing.Point(21, 109);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(171, 26);
            this.previewBtn.TabIndex = 1;
            this.previewBtn.Text = "Preview";
            this.previewBtn.UseVisualStyleBackColor = false;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(18, 252);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(171, 26);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Cancel";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panelManagement
            // 
            this.panelManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            this.panelManagement.Controls.Add(this.lblStage3);
            this.panelManagement.Controls.Add(this.imgStage3);
            this.panelManagement.Controls.Add(this.lblStage2);
            this.panelManagement.Controls.Add(this.imgStage2);
            this.panelManagement.Controls.Add(this.lblStage1);
            this.panelManagement.Controls.Add(this.imgStage1);
            this.panelManagement.Controls.Add(this.pictureBox1);
            this.panelManagement.Location = new System.Drawing.Point(0, 0);
            this.panelManagement.Name = "panelManagement";
            this.panelManagement.Size = new System.Drawing.Size(100, 564);
            this.panelManagement.TabIndex = 11;
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
            this.imgStage2.Image = global::HappyTech.Properties.Resources.happytech_tick;
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
            this.imgStage1.Image = global::HappyTech.Properties.Resources.happytech_tick;
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
            // panelPreviewList
            // 
            this.panelPreviewList.BackColor = System.Drawing.Color.White;
            this.panelPreviewList.Controls.Add(this.lblFeedbackList);
            this.panelPreviewList.Controls.Add(this.checklistAppPreview);
            this.panelPreviewList.Location = new System.Drawing.Point(123, 25);
            this.panelPreviewList.Name = "panelPreviewList";
            this.panelPreviewList.Size = new System.Drawing.Size(601, 515);
            this.panelPreviewList.TabIndex = 13;
            // 
            // lblFeedbackList
            // 
            this.lblFeedbackList.AutoSize = true;
            this.lblFeedbackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFeedbackList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblFeedbackList.Location = new System.Drawing.Point(22, 14);
            this.lblFeedbackList.Name = "lblFeedbackList";
            this.lblFeedbackList.Size = new System.Drawing.Size(158, 24);
            this.lblFeedbackList.TabIndex = 47;
            this.lblFeedbackList.Text = "Feedback List.";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPreview.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPreview.Location = new System.Drawing.Point(17, 14);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(94, 24);
            this.lblPreview.TabIndex = 6;
            this.lblPreview.Text = "Preview.";
            // 
            // panelPreviewAction
            // 
            this.panelPreviewAction.BackColor = System.Drawing.Color.White;
            this.panelPreviewAction.Controls.Add(this.lblPreview);
            this.panelPreviewAction.Controls.Add(this.lbError);
            this.panelPreviewAction.Controls.Add(this.previewBtn);
            this.panelPreviewAction.Location = new System.Drawing.Point(749, 25);
            this.panelPreviewAction.Name = "panelPreviewAction";
            this.panelPreviewAction.Size = new System.Drawing.Size(208, 154);
            this.panelPreviewAction.TabIndex = 14;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbError.Location = new System.Drawing.Point(18, 70);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(90, 14);
            this.lbError.TabIndex = 46;
            this.lbError.Text = "Error message";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbError.Visible = false;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.Location = new System.Drawing.Point(18, 293);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(171, 26);
            this.btnDash.TabIndex = 45;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Visible = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(71)))));
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendBtn.Location = new System.Drawing.Point(18, 293);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(171, 26);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send All";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // panelSubmit
            // 
            this.panelSubmit.BackColor = System.Drawing.Color.White;
            this.panelSubmit.Controls.Add(this.lblAppTotalVal);
            this.panelSubmit.Controls.Add(this.lblAppTotal);
            this.panelSubmit.Controls.Add(this.lblRecruiterVal);
            this.panelSubmit.Controls.Add(this.lblRecruiter);
            this.panelSubmit.Controls.Add(this.lblSubmit);
            this.panelSubmit.Controls.Add(this.btnDash);
            this.panelSubmit.Controls.Add(this.backBtn);
            this.panelSubmit.Controls.Add(this.sendBtn);
            this.panelSubmit.Location = new System.Drawing.Point(749, 200);
            this.panelSubmit.Name = "panelSubmit";
            this.panelSubmit.Size = new System.Drawing.Size(208, 340);
            this.panelSubmit.TabIndex = 47;
            // 
            // lblAppTotalVal
            // 
            this.lblAppTotalVal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppTotalVal.ForeColor = System.Drawing.Color.Black;
            this.lblAppTotalVal.Location = new System.Drawing.Point(15, 144);
            this.lblAppTotalVal.Name = "lblAppTotalVal";
            this.lblAppTotalVal.Size = new System.Drawing.Size(177, 14);
            this.lblAppTotalVal.TabIndex = 51;
            this.lblAppTotalVal.Text = "[applicant_total]";
            this.lblAppTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppTotal
            // 
            this.lblAppTotal.AutoSize = true;
            this.lblAppTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lblAppTotal.Location = new System.Drawing.Point(15, 120);
            this.lblAppTotal.Name = "lblAppTotal";
            this.lblAppTotal.Size = new System.Drawing.Size(68, 14);
            this.lblAppTotal.TabIndex = 50;
            this.lblAppTotal.Text = "Applicants:";
            // 
            // lblRecruiterVal
            // 
            this.lblRecruiterVal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRecruiterVal.ForeColor = System.Drawing.Color.Black;
            this.lblRecruiterVal.Location = new System.Drawing.Point(15, 84);
            this.lblRecruiterVal.Name = "lblRecruiterVal";
            this.lblRecruiterVal.Size = new System.Drawing.Size(177, 14);
            this.lblRecruiterVal.TabIndex = 49;
            this.lblRecruiterVal.Text = "[recruiter_name]";
            this.lblRecruiterVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecruiter
            // 
            this.lblRecruiter.AutoSize = true;
            this.lblRecruiter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRecruiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lblRecruiter.Location = new System.Drawing.Point(15, 60);
            this.lblRecruiter.Name = "lblRecruiter";
            this.lblRecruiter.Size = new System.Drawing.Size(61, 14);
            this.lblRecruiter.TabIndex = 48;
            this.lblRecruiter.Text = "Recruiter:";
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubmit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSubmit.Location = new System.Drawing.Point(17, 14);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(87, 24);
            this.lblSubmit.TabIndex = 6;
            this.lblSubmit.Text = "Submit.";
            // 
            // previewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.panelSubmit);
            this.Controls.Add(this.panelPreviewAction);
            this.Controls.Add(this.panelPreviewList);
            this.Controls.Add(this.panelManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "previewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.panelManagement.ResumeLayout(false);
            this.panelManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPreviewList.ResumeLayout(false);
            this.panelPreviewList.PerformLayout();
            this.panelPreviewAction.ResumeLayout(false);
            this.panelPreviewAction.PerformLayout();
            this.panelSubmit.ResumeLayout(false);
            this.panelSubmit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checklistAppPreview;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Panel panelManagement;
        private System.Windows.Forms.Label lblStage3;
        private System.Windows.Forms.PictureBox imgStage3;
        private System.Windows.Forms.Label lblStage2;
        private System.Windows.Forms.PictureBox imgStage2;
        private System.Windows.Forms.Label lblStage1;
        private System.Windows.Forms.PictureBox imgStage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPreviewList;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Panel panelPreviewAction;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lblFeedbackList;
        private System.Windows.Forms.Panel panelSubmit;
        private System.Windows.Forms.Label lblSubmit;
        private System.Windows.Forms.Label lblRecruiterVal;
        private System.Windows.Forms.Label lblRecruiter;
        private System.Windows.Forms.Label lblAppTotalVal;
        private System.Windows.Forms.Label lblAppTotal;
    }
}