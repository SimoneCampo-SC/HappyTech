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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbSuccess = new System.Windows.Forms.Label();
            this.lbApplicantNo = new System.Windows.Forms.Label();
            this.btNewApp = new System.Windows.Forms.Button();
            this.btStartFeed = new System.Windows.Forms.Button();
            this.dgvApplicant = new System.Windows.Forms.DataGridView();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicant)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSuccess.Location = new System.Drawing.Point(141, 254);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(267, 18);
            this.lbSuccess.TabIndex = 0;
            this.lbSuccess.Text = "Applicant details successfully added.";
            // 
            // lbApplicantNo
            // 
            this.lbApplicantNo.AutoSize = true;
            this.lbApplicantNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicantNo.Location = new System.Drawing.Point(6, 29);
            this.lbApplicantNo.Name = "lbApplicantNo";
            this.lbApplicantNo.Size = new System.Drawing.Size(172, 19);
            this.lbApplicantNo.TabIndex = 1;
            this.lbApplicantNo.Text = "Number of applicants";
            // 
            // btNewApp
            // 
            this.btNewApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btNewApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewApp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewApp.ForeColor = System.Drawing.Color.White;
            this.btNewApp.Location = new System.Drawing.Point(185, 340);
            this.btNewApp.Name = "btNewApp";
            this.btNewApp.Size = new System.Drawing.Size(192, 25);
            this.btNewApp.TabIndex = 2;
            this.btNewApp.Text = "Add";
            this.btNewApp.UseVisualStyleBackColor = false;
            this.btNewApp.Click += new System.EventHandler(this.btNewApp_Click);
            // 
            // btStartFeed
            // 
            this.btStartFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btStartFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartFeed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartFeed.ForeColor = System.Drawing.Color.White;
            this.btStartFeed.Location = new System.Drawing.Point(185, 371);
            this.btStartFeed.Name = "btStartFeed";
            this.btStartFeed.Size = new System.Drawing.Size(192, 25);
            this.btStartFeed.TabIndex = 3;
            this.btStartFeed.Text = "Start Feedback";
            this.btStartFeed.UseVisualStyleBackColor = false;
            this.btStartFeed.Click += new System.EventHandler(this.btStartFeed_Click);
            // 
            // dgvApplicant
            // 
            this.dgvApplicant.AllowUserToAddRows = false;
            this.dgvApplicant.AllowUserToDeleteRows = false;
            this.dgvApplicant.AllowUserToResizeColumns = false;
            this.dgvApplicant.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvApplicant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvApplicant.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvApplicant.BackgroundColor = System.Drawing.Color.Plum;
            this.dgvApplicant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvApplicant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvApplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicant.Location = new System.Drawing.Point(103, 71);
            this.dgvApplicant.Name = "dgvApplicant";
            this.dgvApplicant.ReadOnly = true;
            this.dgvApplicant.Size = new System.Drawing.Size(358, 150);
            this.dgvApplicant.TabIndex = 4;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(185, 309);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(192, 25);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvApplicant);
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btNewApp);
            this.groupBox1.Controls.Add(this.btStartFeed);
            this.groupBox1.Controls.Add(this.lbSuccess);
            this.groupBox1.Controls.Add(this.lbApplicantNo);
            this.groupBox1.Location = new System.Drawing.Point(151, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 415);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // ConfApplDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "ConfApplDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicant)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSuccess;
        private System.Windows.Forms.Label lbApplicantNo;
        private System.Windows.Forms.Button btNewApp;
        private System.Windows.Forms.Button btStartFeed;
        private System.Windows.Forms.DataGridView dgvApplicant;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}