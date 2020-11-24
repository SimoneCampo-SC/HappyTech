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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter New Template Name";
            // 
            // templateBox
            // 
            this.templateBox.Location = new System.Drawing.Point(50, 65);
            this.templateBox.Name = "templateBox";
            this.templateBox.Size = new System.Drawing.Size(183, 20);
            this.templateBox.TabIndex = 11;
            // 
            // sectionsListBox
            // 
            this.sectionsListBox.FormattingEnabled = true;
            this.sectionsListBox.Location = new System.Drawing.Point(199, 141);
            this.sectionsListBox.Name = "sectionsListBox";
            this.sectionsListBox.Size = new System.Drawing.Size(377, 169);
            this.sectionsListBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select The Pre-Existing Sections";
            // 
            // addSectionPreExist
            // 
            this.addSectionPreExist.Location = new System.Drawing.Point(338, 47);
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
            this.preExistTempBox.Location = new System.Drawing.Point(579, 64);
            this.preExistTempBox.Name = "preExistTempBox";
            this.preExistTempBox.Size = new System.Drawing.Size(161, 21);
            this.preExistTempBox.TabIndex = 17;
            this.preExistTempBox.SelectedIndexChanged += new System.EventHandler(this.preExistTempBox_SelectedIndexChanged);
            // 
            // preExistLbl
            // 
            this.preExistLbl.AutoSize = true;
            this.preExistLbl.Location = new System.Drawing.Point(576, 36);
            this.preExistLbl.Name = "preExistLbl";
            this.preExistLbl.Size = new System.Drawing.Size(118, 13);
            this.preExistLbl.TabIndex = 18;
            this.preExistLbl.Text = "Select existing template";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(354, 397);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateTemplate
            // 
            this.updateTemplate.Location = new System.Drawing.Point(473, 363);
            this.updateTemplate.Name = "updateTemplate";
            this.updateTemplate.Size = new System.Drawing.Size(103, 23);
            this.updateTemplate.TabIndex = 20;
            this.updateTemplate.Text = "update template";
            this.updateTemplate.UseVisualStyleBackColor = true;
            this.updateTemplate.Click += new System.EventHandler(this.updateTemplate_Click);
            // 
            // templateSubmitBtn
            // 
            this.templateSubmitBtn.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.templateSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.templateSubmitBtn.Location = new System.Drawing.Point(199, 363);
            this.templateSubmitBtn.Name = "templateSubmitBtn";
            this.templateSubmitBtn.Size = new System.Drawing.Size(107, 23);
            this.templateSubmitBtn.TabIndex = 13;
            this.templateSubmitBtn.Text = "submit template";
            this.templateSubmitBtn.UseVisualStyleBackColor = true;
            this.templateSubmitBtn.Click += new System.EventHandler(this.templateSubmitBtn_Click);
            // 
            // addTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateTemplate);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.preExistLbl);
            this.Controls.Add(this.preExistTempBox);
            this.Controls.Add(this.addSectionPreExist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sectionsListBox);
            this.Controls.Add(this.templateSubmitBtn);
            this.Controls.Add(this.templateBox);
            this.Controls.Add(this.label1);
            this.Name = "addTemplate";
            this.Text = "addTemplate";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}