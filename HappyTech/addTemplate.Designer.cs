namespace HappyTech
{
    partial class addTemplate
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
            this.label1 = new System.Windows.Forms.Label();
            this.templateBox = new System.Windows.Forms.TextBox();
            this.sectionsListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addSectionPreExist = new System.Windows.Forms.Button();
            this.preExistTempBox = new System.Windows.Forms.ComboBox();
            this.preExistLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.updateTemplate = new System.Windows.Forms.Button();
            this.templateSubmitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter New Template Name";
            // 
            // templateBox
            // 
            this.templateBox.Location = new System.Drawing.Point(19, 58);
            this.templateBox.Name = "templateBox";
            this.templateBox.Size = new System.Drawing.Size(183, 20);
            this.templateBox.TabIndex = 11;
            // 
            // sectionsListBox
            // 
            this.sectionsListBox.FormattingEnabled = true;
            this.sectionsListBox.Location = new System.Drawing.Point(31, 113);
            this.sectionsListBox.Name = "sectionsListBox";
            this.sectionsListBox.Size = new System.Drawing.Size(311, 169);
            this.sectionsListBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select The Pre-Existing Sections";
            // 
            // addSectionPreExist
            // 
            this.addSectionPreExist.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.addSectionPreExist.ForeColor = System.Drawing.Color.White;
            this.addSectionPreExist.Location = new System.Drawing.Point(116, 19);
            this.addSectionPreExist.Name = "addSectionPreExist";
            this.addSectionPreExist.Size = new System.Drawing.Size(133, 38);
            this.addSectionPreExist.TabIndex = 16;
            this.addSectionPreExist.Text = "Choose new or existing template";
            this.addSectionPreExist.UseVisualStyleBackColor = true;
            this.addSectionPreExist.Click += new System.EventHandler(this.addSectionPreExist_Click);
            // 
            // preExistTempBox
            // 
            this.preExistTempBox.FormattingEnabled = true;
            this.preExistTempBox.Location = new System.Drawing.Point(27, 58);
            this.preExistTempBox.Name = "preExistTempBox";
            this.preExistTempBox.Size = new System.Drawing.Size(161, 21);
            this.preExistTempBox.TabIndex = 17;
            this.preExistTempBox.SelectedIndexChanged += new System.EventHandler(this.preExistTempBox_SelectedIndexChanged);
            // 
            // preExistLbl
            // 
            this.preExistLbl.AutoSize = true;
            this.preExistLbl.Location = new System.Drawing.Point(24, 21);
            this.preExistLbl.Name = "preExistLbl";
            this.preExistLbl.Size = new System.Drawing.Size(118, 13);
            this.preExistLbl.TabIndex = 18;
            this.preExistLbl.Text = "Select existing template";
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(181, 10);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(86, 39);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateTemplate
            // 
            this.updateTemplate.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.updateTemplate.ForeColor = System.Drawing.Color.White;
            this.updateTemplate.Location = new System.Drawing.Point(315, 10);
            this.updateTemplate.Name = "updateTemplate";
            this.updateTemplate.Size = new System.Drawing.Size(114, 39);
            this.updateTemplate.TabIndex = 20;
            this.updateTemplate.Text = "update template";
            this.updateTemplate.UseVisualStyleBackColor = true;
            this.updateTemplate.Click += new System.EventHandler(this.updateTemplate_Click);
            // 
            // templateSubmitBtn
            // 
            this.templateSubmitBtn.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.templateSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.templateSubmitBtn.Location = new System.Drawing.Point(18, 10);
            this.templateSubmitBtn.Name = "templateSubmitBtn";
            this.templateSubmitBtn.Size = new System.Drawing.Size(100, 39);
            this.templateSubmitBtn.TabIndex = 13;
            this.templateSubmitBtn.Text = "submit template";
            this.templateSubmitBtn.UseVisualStyleBackColor = true;
            this.templateSubmitBtn.Click += new System.EventHandler(this.templateSubmitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.templateBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 121);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.addSectionPreExist);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sectionsListBox);
            this.groupBox2.Location = new System.Drawing.Point(267, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 318);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateTemplate);
            this.groupBox3.Controls.Add(this.backBtn);
            this.groupBox3.Controls.Add(this.templateSubmitBtn);
            this.groupBox3.Location = new System.Drawing.Point(219, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 55);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.preExistLbl);
            this.groupBox4.Controls.Add(this.preExistTempBox);
            this.groupBox4.Location = new System.Drawing.Point(659, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 98);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // addTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.ClientSize = new System.Drawing.Size(908, 497);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "addTemplate";
            this.Text = "addTemplate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button templateSubmitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox templateBox;
        private System.Windows.Forms.CheckedListBox sectionsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addSectionPreExist;
        private System.Windows.Forms.ComboBox preExistTempBox;
        private System.Windows.Forms.Label preExistLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button updateTemplate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}