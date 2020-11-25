namespace HappyTech
{
    partial class addSections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSections));
            this.tagBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.templatesListBox = new System.Windows.Forms.CheckedListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.addCodes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tagSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sectionBox = new System.Windows.Forms.ComboBox();
            this.showDeleteBtn = new System.Windows.Forms.Button();
            this.deleteSection = new System.Windows.Forms.Button();
            this.showEditBtn = new System.Windows.Forms.Button();
            this.editSectionCombo = new System.Windows.Forms.ComboBox();
            this.editSectionTextBox = new System.Windows.Forms.TextBox();
            this.submitEditBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagBox
            // 
            this.tagBox.Location = new System.Drawing.Point(33, 37);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(229, 20);
            this.tagBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter New Section Name";
            // 
            // templatesListBox
            // 
            this.templatesListBox.FormattingEnabled = true;
            this.templatesListBox.Location = new System.Drawing.Point(33, 123);
            this.templatesListBox.Name = "templatesListBox";
            this.templatesListBox.Size = new System.Drawing.Size(331, 169);
            this.templatesListBox.TabIndex = 15;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(135, 351);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addCodes
            // 
            this.addCodes.Location = new System.Drawing.Point(131, 49);
            this.addCodes.Name = "addCodes";
            this.addCodes.Size = new System.Drawing.Size(75, 23);
            this.addCodes.TabIndex = 17;
            this.addCodes.Text = "Add Codes";
            this.addCodes.UseVisualStyleBackColor = true;
            this.addCodes.Click += new System.EventHandler(this.addCodes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "select one or more templates to add this section to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Now click the button below to add some codes to the new section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "vvvvvvvvvvvv";
            // 
            // tagSubmit
            // 
            this.tagSubmit.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.tagSubmit.ForeColor = System.Drawing.Color.White;
            this.tagSubmit.Location = new System.Drawing.Point(135, 311);
            this.tagSubmit.Name = "tagSubmit";
            this.tagSubmit.Size = new System.Drawing.Size(75, 23);
            this.tagSubmit.TabIndex = 7;
            this.tagSubmit.Text = "Submit Tag";
            this.tagSubmit.UseVisualStyleBackColor = true;
            this.tagSubmit.Click += new System.EventHandler(this.tagSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.backBtn);
            this.groupBox1.Controls.Add(this.templatesListBox);
            this.groupBox1.Controls.Add(this.tagBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tagSubmit);
            this.groupBox1.Location = new System.Drawing.Point(98, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 413);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addCodes);
            this.groupBox2.Location = new System.Drawing.Point(558, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 83);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // sectionBox
            // 
            this.sectionBox.FormattingEnabled = true;
            this.sectionBox.Location = new System.Drawing.Point(595, 84);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(121, 21);
            this.sectionBox.TabIndex = 23;
            // 
            // showDeleteBtn
            // 
            this.showDeleteBtn.Location = new System.Drawing.Point(595, 37);
            this.showDeleteBtn.Name = "showDeleteBtn";
            this.showDeleteBtn.Size = new System.Drawing.Size(99, 23);
            this.showDeleteBtn.TabIndex = 24;
            this.showDeleteBtn.Text = "Delete Sections";
            this.showDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // deleteSection
            // 
            this.deleteSection.Location = new System.Drawing.Point(595, 129);
            this.deleteSection.Name = "deleteSection";
            this.deleteSection.Size = new System.Drawing.Size(75, 23);
            this.deleteSection.TabIndex = 25;
            this.deleteSection.Text = "Delete Selected";
            this.deleteSection.UseVisualStyleBackColor = true;
            // 
            // showEditBtn
            // 
            this.showEditBtn.Location = new System.Drawing.Point(558, 212);
            this.showEditBtn.Name = "showEditBtn";
            this.showEditBtn.Size = new System.Drawing.Size(121, 23);
            this.showEditBtn.TabIndex = 26;
            this.showEditBtn.Text = "Edit Section Names";
            this.showEditBtn.UseVisualStyleBackColor = true;
            // 
            // editSectionCombo
            // 
            this.editSectionCombo.FormattingEnabled = true;
            this.editSectionCombo.Location = new System.Drawing.Point(558, 255);
            this.editSectionCombo.Name = "editSectionCombo";
            this.editSectionCombo.Size = new System.Drawing.Size(121, 21);
            this.editSectionCombo.TabIndex = 27;
            // 
            // editSectionTextBox
            // 
            this.editSectionTextBox.Location = new System.Drawing.Point(558, 294);
            this.editSectionTextBox.Name = "editSectionTextBox";
            this.editSectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.editSectionTextBox.TabIndex = 28;
            // 
            // submitEditBtn
            // 
            this.submitEditBtn.Location = new System.Drawing.Point(558, 330);
            this.submitEditBtn.Name = "submitEditBtn";
            this.submitEditBtn.Size = new System.Drawing.Size(99, 23);
            this.submitEditBtn.TabIndex = 29;
            this.submitEditBtn.Text = "Save Changes";
            this.submitEditBtn.UseVisualStyleBackColor = true;
            // 
            // addSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.ClientSize = new System.Drawing.Size(944, 530);
            this.Controls.Add(this.submitEditBtn);
            this.Controls.Add(this.editSectionTextBox);
            this.Controls.Add(this.editSectionCombo);
            this.Controls.Add(this.showEditBtn);
            this.Controls.Add(this.deleteSection);
            this.Controls.Add(this.showDeleteBtn);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addSections";
            this.Text = "HappyTech";
            this.Load += new System.EventHandler(this.addSections_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tagSubmit;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox templatesListBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addCodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox sectionBox;
        private System.Windows.Forms.Button showDeleteBtn;
        private System.Windows.Forms.Button deleteSection;
        private System.Windows.Forms.Button showEditBtn;
        private System.Windows.Forms.ComboBox editSectionCombo;
        private System.Windows.Forms.TextBox editSectionTextBox;
        private System.Windows.Forms.Button submitEditBtn;
    }
}