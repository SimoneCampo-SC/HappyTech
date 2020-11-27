namespace HappyTech
{
    partial class ConfApplDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfApplDetailsForm));
            this.lbSuccess = new System.Windows.Forms.Label();
            this.lbApplicantNo = new System.Windows.Forms.Label();
            this.btNewApp = new System.Windows.Forms.Button();
            this.btStartFeed = new System.Windows.Forms.Button();
            this.dgvApplicant = new System.Windows.Forms.DataGridView();
            this.btCancel = new System.Windows.Forms.Button();
            this.panelManagement = new System.Windows.Forms.Panel();
            this.lblStage3 = new System.Windows.Forms.Label();
            this.imgStage3 = new System.Windows.Forms.PictureBox();
            this.lblStage2 = new System.Windows.Forms.Label();
            this.imgStage2 = new System.Windows.Forms.PictureBox();
            this.lblStage1 = new System.Windows.Forms.Label();
            this.imgStage1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelApplicants = new System.Windows.Forms.Panel();
            this.lblApplicants = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.panelSubmit = new System.Windows.Forms.Panel();
            this.lblAppTotalVal = new System.Windows.Forms.Label();
            this.lblAppTotal = new System.Windows.Forms.Label();
            this.lblRecruiterVal = new System.Windows.Forms.Label();
            this.lblRecruiter = new System.Windows.Forms.Label();
            this.lblBeginFeedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicant)).BeginInit();
            this.panelManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelApplicants.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelSubmit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSuccess
            // 
            this.lbSuccess.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSuccess.Location = new System.Drawing.Point(18, 65);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(170, 17);
            this.lbSuccess.TabIndex = 0;
            this.lbSuccess.Text = "Applicant successfully added";
            // 
            // lbApplicantNo
            // 
            this.lbApplicantNo.AutoSize = true;
            this.lbApplicantNo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbApplicantNo.Location = new System.Drawing.Point(17, 14);
            this.lbApplicantNo.Name = "lbApplicantNo";
            this.lbApplicantNo.Size = new System.Drawing.Size(167, 24);
            this.lbApplicantNo.TabIndex = 1;
            this.lbApplicantNo.Text = "Add applicants.";
            // 
            // btNewApp
            // 
            this.btNewApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btNewApp.FlatAppearance.BorderSize = 0;
            this.btNewApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewApp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btNewApp.ForeColor = System.Drawing.Color.White;
            this.btNewApp.Image = global::HappyTech.Properties.Resources.happytech_add1;
            this.btNewApp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNewApp.Location = new System.Drawing.Point(18, 115);
            this.btNewApp.Name = "btNewApp";
            this.btNewApp.Size = new System.Drawing.Size(174, 26);
            this.btNewApp.TabIndex = 2;
            this.btNewApp.Text = "Add";
            this.btNewApp.UseVisualStyleBackColor = false;
            this.btNewApp.Click += new System.EventHandler(this.btNewApp_Click);
            // 
            // btStartFeed
            // 
            this.btStartFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(71)))));
            this.btStartFeed.FlatAppearance.BorderSize = 0;
            this.btStartFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartFeed.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btStartFeed.ForeColor = System.Drawing.Color.White;
            this.btStartFeed.Location = new System.Drawing.Point(18, 293);
            this.btStartFeed.Name = "btStartFeed";
            this.btStartFeed.Size = new System.Drawing.Size(174, 26);
            this.btStartFeed.TabIndex = 3;
            this.btStartFeed.Text = "Begin";
            this.btStartFeed.UseVisualStyleBackColor = false;
            this.btStartFeed.Click += new System.EventHandler(this.btStartFeed_Click);
            // 
            // dgvApplicant
            // 
            this.dgvApplicant.AllowUserToAddRows = false;
            this.dgvApplicant.AllowUserToDeleteRows = false;
            this.dgvApplicant.AllowUserToResizeColumns = false;
            this.dgvApplicant.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicant.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplicant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvApplicant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicant.ColumnHeadersHeight = 26;
            this.dgvApplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicant.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApplicant.GridColor = System.Drawing.Color.White;
            this.dgvApplicant.Location = new System.Drawing.Point(26, 65);
            this.dgvApplicant.Name = "dgvApplicant";
            this.dgvApplicant.ReadOnly = true;
            this.dgvApplicant.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvApplicant.RowHeadersVisible = false;
            this.dgvApplicant.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvApplicant.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvApplicant.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.dgvApplicant.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvApplicant.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvApplicant.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvApplicant.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicant.RowTemplate.Height = 26;
            this.dgvApplicant.RowTemplate.ReadOnly = true;
            this.dgvApplicant.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplicant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicant.Size = new System.Drawing.Size(548, 421);
            this.dgvApplicant.TabIndex = 4;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(18, 252);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(174, 26);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Abort";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
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
            this.panelManagement.TabIndex = 8;
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
            // panelApplicants
            // 
            this.panelApplicants.BackColor = System.Drawing.Color.White;
            this.panelApplicants.Controls.Add(this.dgvApplicant);
            this.panelApplicants.Controls.Add(this.lblApplicants);
            this.panelApplicants.Location = new System.Drawing.Point(122, 25);
            this.panelApplicants.Name = "panelApplicants";
            this.panelApplicants.Size = new System.Drawing.Size(601, 515);
            this.panelApplicants.TabIndex = 14;
            // 
            // lblApplicants
            // 
            this.lblApplicants.AutoSize = true;
            this.lblApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApplicants.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblApplicants.Location = new System.Drawing.Point(22, 14);
            this.lblApplicants.Name = "lblApplicants";
            this.lblApplicants.Size = new System.Drawing.Size(154, 24);
            this.lblApplicants.TabIndex = 6;
            this.lblApplicants.Text = "Applicant List.";
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.White;
            this.panelActions.Controls.Add(this.lbApplicantNo);
            this.panelActions.Controls.Add(this.btNewApp);
            this.panelActions.Controls.Add(this.lbSuccess);
            this.panelActions.Location = new System.Drawing.Point(750, 25);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(211, 159);
            this.panelActions.TabIndex = 15;
            // 
            // panelSubmit
            // 
            this.panelSubmit.BackColor = System.Drawing.Color.White;
            this.panelSubmit.Controls.Add(this.lblAppTotalVal);
            this.panelSubmit.Controls.Add(this.btStartFeed);
            this.panelSubmit.Controls.Add(this.btCancel);
            this.panelSubmit.Controls.Add(this.lblAppTotal);
            this.panelSubmit.Controls.Add(this.lblRecruiterVal);
            this.panelSubmit.Controls.Add(this.lblRecruiter);
            this.panelSubmit.Controls.Add(this.lblBeginFeedback);
            this.panelSubmit.Location = new System.Drawing.Point(750, 200);
            this.panelSubmit.Name = "panelSubmit";
            this.panelSubmit.Size = new System.Drawing.Size(211, 340);
            this.panelSubmit.TabIndex = 48;
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
            // lblBeginFeedback
            // 
            this.lblBeginFeedback.AutoSize = true;
            this.lblBeginFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBeginFeedback.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBeginFeedback.Location = new System.Drawing.Point(17, 14);
            this.lblBeginFeedback.Name = "lblBeginFeedback";
            this.lblBeginFeedback.Size = new System.Drawing.Size(173, 24);
            this.lblBeginFeedback.TabIndex = 6;
            this.lblBeginFeedback.Text = "Begin feedback.";
            // 
            // ConfApplDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.panelSubmit);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelApplicants);
            this.Controls.Add(this.panelManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "ConfApplDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicant)).EndInit();
            this.panelManagement.ResumeLayout(false);
            this.panelManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelApplicants.ResumeLayout(false);
            this.panelApplicants.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.panelSubmit.ResumeLayout(false);
            this.panelSubmit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSuccess;
        private System.Windows.Forms.Label lbApplicantNo;
        private System.Windows.Forms.Button btNewApp;
        private System.Windows.Forms.Button btStartFeed;
        private System.Windows.Forms.DataGridView dgvApplicant;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel panelManagement;
        private System.Windows.Forms.Label lblStage3;
        private System.Windows.Forms.PictureBox imgStage3;
        private System.Windows.Forms.Label lblStage2;
        private System.Windows.Forms.PictureBox imgStage2;
        private System.Windows.Forms.Label lblStage1;
        private System.Windows.Forms.PictureBox imgStage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelApplicants;
        private System.Windows.Forms.Label lblApplicants;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelSubmit;
        private System.Windows.Forms.Label lblAppTotalVal;
        private System.Windows.Forms.Label lblAppTotal;
        private System.Windows.Forms.Label lblRecruiterVal;
        private System.Windows.Forms.Label lblRecruiter;
        private System.Windows.Forms.Label lblBeginFeedback;
    }
}