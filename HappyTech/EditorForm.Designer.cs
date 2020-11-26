namespace HappyTech
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbTemplate = new System.Windows.Forms.Label();
            this.lbCodeList = new System.Windows.Forms.Label();
            this.lbComBox = new System.Windows.Forms.Label();
            this.lbApplicants = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.listBox = new System.Windows.Forms.CheckedListBox();
            this.panelManagement = new System.Windows.Forms.Panel();
            this.lblStage3 = new System.Windows.Forms.Label();
            this.lblStage2 = new System.Windows.Forms.Label();
            this.lblStage1 = new System.Windows.Forms.Label();
            this.panelCodes = new System.Windows.Forms.Panel();
            this.panelTemplate = new System.Windows.Forms.Panel();
            this.panelComments = new System.Windows.Forms.Panel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.lblAppTempVal = new System.Windows.Forms.Label();
            this.lblAppTemp = new System.Windows.Forms.Label();
            this.lblAppJobVal = new System.Windows.Forms.Label();
            this.lblAppEmailVal = new System.Windows.Forms.Label();
            this.lblAppNameVal = new System.Windows.Forms.Label();
            this.lblRecruiterVal = new System.Windows.Forms.Label();
            this.lblAppJob = new System.Windows.Forms.Label();
            this.lblAppEmail = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblRecruiter = new System.Windows.Forms.Label();
            this.lbDetails = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.imgStage3 = new System.Windows.Forms.PictureBox();
            this.imgStage2 = new System.Windows.Forms.PictureBox();
            this.imgStage1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelManagement.SuspendLayout();
            this.panelCodes.SuspendLayout();
            this.panelTemplate.SuspendLayout();
            this.panelComments.SuspendLayout();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.richTextBox2.Location = new System.Drawing.Point(17, 67);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(439, 242);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.richTextBox1.Location = new System.Drawing.Point(17, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(439, 100);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lbTemplate
            // 
            this.lbTemplate.AutoSize = true;
            this.lbTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTemplate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbTemplate.Location = new System.Drawing.Point(13, 13);
            this.lbTemplate.Name = "lbTemplate";
            this.lbTemplate.Size = new System.Drawing.Size(107, 24);
            this.lbTemplate.TabIndex = 6;
            this.lbTemplate.Text = "Template.";
            // 
            // lbCodeList
            // 
            this.lbCodeList.AutoSize = true;
            this.lbCodeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCodeList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbCodeList.Location = new System.Drawing.Point(14, 13);
            this.lbCodeList.Name = "lbCodeList";
            this.lbCodeList.Size = new System.Drawing.Size(81, 24);
            this.lbCodeList.TabIndex = 7;
            this.lbCodeList.Text = "Codes.";
            // 
            // lbComBox
            // 
            this.lbComBox.AutoSize = true;
            this.lbComBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbComBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbComBox.Location = new System.Drawing.Point(17, 21);
            this.lbComBox.Name = "lbComBox";
            this.lbComBox.Size = new System.Drawing.Size(126, 24);
            this.lbComBox.TabIndex = 8;
            this.lbComBox.Text = "Comments.";
            // 
            // lbApplicants
            // 
            this.lbApplicants.AutoSize = true;
            this.lbApplicants.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbApplicants.ForeColor = System.Drawing.Color.Black;
            this.lbApplicants.Location = new System.Drawing.Point(15, 70);
            this.lbApplicants.Name = "lbApplicants";
            this.lbApplicants.Size = new System.Drawing.Size(90, 14);
            this.lbApplicants.TabIndex = 9;
            this.lbApplicants.Text = "Applicant x of y";
            // 
            // listBox
            // 
            this.listBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.listBox.ForeColor = System.Drawing.Color.Black;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(18, 67);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(94, 439);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedValueChanged += new System.EventHandler(this.listBox_SelectedValueChanged);
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
            this.panelManagement.TabIndex = 10;
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
            // panelCodes
            // 
            this.panelCodes.BackColor = System.Drawing.Color.White;
            this.panelCodes.Controls.Add(this.lbCodeList);
            this.panelCodes.Controls.Add(this.listBox);
            this.panelCodes.Location = new System.Drawing.Point(115, 12);
            this.panelCodes.Name = "panelCodes";
            this.panelCodes.Size = new System.Drawing.Size(130, 539);
            this.panelCodes.TabIndex = 11;
            // 
            // panelTemplate
            // 
            this.panelTemplate.BackColor = System.Drawing.Color.White;
            this.panelTemplate.Controls.Add(this.lbTemplate);
            this.panelTemplate.Controls.Add(this.richTextBox2);
            this.panelTemplate.Location = new System.Drawing.Point(262, 12);
            this.panelTemplate.Name = "panelTemplate";
            this.panelTemplate.Size = new System.Drawing.Size(474, 338);
            this.panelTemplate.TabIndex = 12;
            // 
            // panelComments
            // 
            this.panelComments.BackColor = System.Drawing.Color.White;
            this.panelComments.Controls.Add(this.lbComBox);
            this.panelComments.Controls.Add(this.richTextBox1);
            this.panelComments.Location = new System.Drawing.Point(262, 370);
            this.panelComments.Name = "panelComments";
            this.panelComments.Size = new System.Drawing.Size(474, 181);
            this.panelComments.TabIndex = 13;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.White;
            this.panelAdd.Controls.Add(this.lblAppTempVal);
            this.panelAdd.Controls.Add(this.lblAppTemp);
            this.panelAdd.Controls.Add(this.lblAppJobVal);
            this.panelAdd.Controls.Add(this.lblAppEmailVal);
            this.panelAdd.Controls.Add(this.lblAppNameVal);
            this.panelAdd.Controls.Add(this.lblRecruiterVal);
            this.panelAdd.Controls.Add(this.lbApplicants);
            this.panelAdd.Controls.Add(this.lblAppJob);
            this.panelAdd.Controls.Add(this.btNext);
            this.panelAdd.Controls.Add(this.btBack);
            this.panelAdd.Controls.Add(this.lblAppEmail);
            this.panelAdd.Controls.Add(this.lblAppName);
            this.panelAdd.Controls.Add(this.lblRecruiter);
            this.panelAdd.Controls.Add(this.lbDetails);
            this.panelAdd.Location = new System.Drawing.Point(754, 11);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(216, 540);
            this.panelAdd.TabIndex = 14;
            // 
            // lblAppTempVal
            // 
            this.lblAppTempVal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppTempVal.ForeColor = System.Drawing.Color.Black;
            this.lblAppTempVal.Location = new System.Drawing.Point(15, 419);
            this.lblAppTempVal.Name = "lblAppTempVal";
            this.lblAppTempVal.Size = new System.Drawing.Size(186, 14);
            this.lblAppTempVal.TabIndex = 53;
            this.lblAppTempVal.Text = "[applicant_temp]";
            this.lblAppTempVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppTemp
            // 
            this.lblAppTemp.AutoSize = true;
            this.lblAppTemp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lblAppTemp.Location = new System.Drawing.Point(15, 395);
            this.lblAppTemp.Name = "lblAppTemp";
            this.lblAppTemp.Size = new System.Drawing.Size(61, 14);
            this.lblAppTemp.TabIndex = 52;
            this.lblAppTemp.Text = "Template:";
            // 
            // lblAppJobVal
            // 
            this.lblAppJobVal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppJobVal.ForeColor = System.Drawing.Color.Black;
            this.lblAppJobVal.Location = new System.Drawing.Point(15, 349);
            this.lblAppJobVal.Name = "lblAppJobVal";
            this.lblAppJobVal.Size = new System.Drawing.Size(186, 14);
            this.lblAppJobVal.TabIndex = 50;
            this.lblAppJobVal.Text = "[applicant_job]";
            this.lblAppJobVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppEmailVal
            // 
            this.lblAppEmailVal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppEmailVal.ForeColor = System.Drawing.Color.Black;
            this.lblAppEmailVal.Location = new System.Drawing.Point(15, 277);
            this.lblAppEmailVal.Name = "lblAppEmailVal";
            this.lblAppEmailVal.Size = new System.Drawing.Size(186, 14);
            this.lblAppEmailVal.TabIndex = 49;
            this.lblAppEmailVal.Text = "[applicant_email]";
            this.lblAppEmailVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppNameVal
            // 
            this.lblAppNameVal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppNameVal.ForeColor = System.Drawing.Color.Black;
            this.lblAppNameVal.Location = new System.Drawing.Point(15, 205);
            this.lblAppNameVal.Name = "lblAppNameVal";
            this.lblAppNameVal.Size = new System.Drawing.Size(186, 14);
            this.lblAppNameVal.TabIndex = 48;
            this.lblAppNameVal.Text = "[applicant_name]";
            this.lblAppNameVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecruiterVal
            // 
            this.lblRecruiterVal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRecruiterVal.ForeColor = System.Drawing.Color.Black;
            this.lblRecruiterVal.Location = new System.Drawing.Point(15, 136);
            this.lblRecruiterVal.Name = "lblRecruiterVal";
            this.lblRecruiterVal.Size = new System.Drawing.Size(186, 14);
            this.lblRecruiterVal.TabIndex = 47;
            this.lblRecruiterVal.Text = "[recruiter_name]";
            this.lblRecruiterVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppJob
            // 
            this.lblAppJob.AutoSize = true;
            this.lblAppJob.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lblAppJob.Location = new System.Drawing.Point(15, 325);
            this.lblAppJob.Name = "lblAppJob";
            this.lblAppJob.Size = new System.Drawing.Size(55, 14);
            this.lblAppJob.TabIndex = 9;
            this.lblAppJob.Text = "Position:";
            // 
            // lblAppEmail
            // 
            this.lblAppEmail.AutoSize = true;
            this.lblAppEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lblAppEmail.Location = new System.Drawing.Point(15, 253);
            this.lblAppEmail.Name = "lblAppEmail";
            this.lblAppEmail.Size = new System.Drawing.Size(39, 14);
            this.lblAppEmail.TabIndex = 8;
            this.lblAppEmail.Text = "Email:";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lblAppName.Location = new System.Drawing.Point(15, 181);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(61, 14);
            this.lblAppName.TabIndex = 7;
            this.lblAppName.Text = "Applicant:";
            // 
            // lblRecruiter
            // 
            this.lblRecruiter.AutoSize = true;
            this.lblRecruiter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRecruiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lblRecruiter.Location = new System.Drawing.Point(15, 112);
            this.lblRecruiter.Name = "lblRecruiter";
            this.lblRecruiter.Size = new System.Drawing.Size(61, 14);
            this.lblRecruiter.TabIndex = 6;
            this.lblRecruiter.Text = "Recruiter:";
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetails.ForeColor = System.Drawing.Color.Black;
            this.lbDetails.Location = new System.Drawing.Point(14, 14);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(84, 24);
            this.lbDetails.TabIndex = 0;
            this.lbDetails.Text = "Details.";
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btNext.FlatAppearance.BorderSize = 0;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btNext.ForeColor = System.Drawing.Color.White;
            this.btNext.Image = global::HappyTech.Properties.Resources.happytech_next;
            this.btNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNext.Location = new System.Drawing.Point(18, 501);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(183, 26);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext2_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Image = global::HappyTech.Properties.Resources.happytech_back;
            this.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBack.Location = new System.Drawing.Point(18, 460);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(183, 26);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
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
            // imgStage2
            // 
            this.imgStage2.Image = global::HappyTech.Properties.Resources.happytech_2;
            this.imgStage2.Location = new System.Drawing.Point(42, 235);
            this.imgStage2.Name = "imgStage2";
            this.imgStage2.Size = new System.Drawing.Size(16, 16);
            this.imgStage2.TabIndex = 40;
            this.imgStage2.TabStop = false;
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
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelComments);
            this.Controls.Add(this.panelTemplate);
            this.Controls.Add(this.panelCodes);
            this.Controls.Add(this.panelManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "EditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
          
            this.panelManagement.ResumeLayout(false);
            this.panelManagement.PerformLayout();
            this.panelCodes.ResumeLayout(false);
            this.panelCodes.PerformLayout();
            this.panelTemplate.ResumeLayout(false);
            this.panelTemplate.PerformLayout();
            this.panelComments.ResumeLayout(false);
            this.panelComments.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbTemplate;
        private System.Windows.Forms.Label lbCodeList;
        private System.Windows.Forms.Label lbComBox;
        private System.Windows.Forms.Label lbApplicants;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckedListBox listBox;
        private System.Windows.Forms.Panel panelManagement;
        private System.Windows.Forms.Label lblStage3;
        private System.Windows.Forms.PictureBox imgStage3;
        private System.Windows.Forms.Label lblStage2;
        private System.Windows.Forms.PictureBox imgStage2;
        private System.Windows.Forms.Label lblStage1;
        private System.Windows.Forms.PictureBox imgStage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCodes;
        private System.Windows.Forms.Panel panelTemplate;
        private System.Windows.Forms.Panel panelComments;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label lblAppTempVal;
        private System.Windows.Forms.Label lblAppTemp;
        private System.Windows.Forms.Label lblAppJobVal;
        private System.Windows.Forms.Label lblAppEmailVal;
        private System.Windows.Forms.Label lblAppNameVal;
        private System.Windows.Forms.Label lblRecruiterVal;
        private System.Windows.Forms.Label lblAppJob;
        private System.Windows.Forms.Label lblAppEmail;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblRecruiter;
        private System.Windows.Forms.Label lbDetails;
    }
}