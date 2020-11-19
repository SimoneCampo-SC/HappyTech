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
            this.lbSuccess = new System.Windows.Forms.Label();
            this.lbApplicantNo = new System.Windows.Forms.Label();
            this.btNewApp = new System.Windows.Forms.Button();
            this.btStartFeed = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuccess.Location = new System.Drawing.Point(293, 198);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(229, 16);
            this.lbSuccess.TabIndex = 0;
            this.lbSuccess.Text = "Applicant details successfully added.";
            // 
            // lbApplicantNo
            // 
            this.lbApplicantNo.AutoSize = true;
            this.lbApplicantNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicantNo.Location = new System.Drawing.Point(351, 233);
            this.lbApplicantNo.Name = "lbApplicantNo";
            this.lbApplicantNo.Size = new System.Drawing.Size(45, 16);
            this.lbApplicantNo.TabIndex = 1;
            this.lbApplicantNo.Text = "label2";
            // 
            // btNewApp
            // 
            this.btNewApp.Location = new System.Drawing.Point(354, 278);
            this.btNewApp.Name = "btNewApp";
            this.btNewApp.Size = new System.Drawing.Size(103, 23);
            this.btNewApp.TabIndex = 2;
            this.btNewApp.Text = "Add";
            this.btNewApp.UseVisualStyleBackColor = true;
            this.btNewApp.Click += new System.EventHandler(this.btNewApp_Click);
            // 
            // btStartFeed
            // 
            this.btStartFeed.Location = new System.Drawing.Point(354, 321);
            this.btStartFeed.Name = "btStartFeed";
            this.btStartFeed.Size = new System.Drawing.Size(103, 23);
            this.btStartFeed.TabIndex = 3;
            this.btStartFeed.Text = "Next";
            this.btStartFeed.UseVisualStyleBackColor = true;
            this.btStartFeed.Click += new System.EventHandler(this.btStartFeed_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfApplDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btStartFeed);
            this.Controls.Add(this.btNewApp);
            this.Controls.Add(this.lbApplicantNo);
            this.Controls.Add(this.lbSuccess);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "ConfApplDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSuccess;
        private System.Windows.Forms.Label lbApplicantNo;
        private System.Windows.Forms.Button btNewApp;
        private System.Windows.Forms.Button btStartFeed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}