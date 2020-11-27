namespace HappyTech
{
    partial class NewEditDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEditDelete));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.addToExistBox = new System.Windows.Forms.CheckedListBox();
            this.submitNewBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.existingDropDown = new System.Windows.Forms.ComboBox();
            this.editBox = new System.Windows.Forms.TextBox();
            this.codeParaEditBox = new System.Windows.Forms.RichTextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveChangeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.enterInfoLabel = new System.Windows.Forms.Label();
            this.addToExistingLabel = new System.Windows.Forms.Label();
            this.editExistingLbl = new System.Windows.Forms.Label();
            this.selectExisitingLabel = new System.Windows.Forms.Label();
            this.newCodeParaBox = new System.Windows.Forms.RichTextBox();
            this.codeParaLbl = new System.Windows.Forms.Label();
            this.newCodeSection = new System.Windows.Forms.ComboBox();
            this.checkBoxForEdit = new System.Windows.Forms.CheckedListBox();
            this.dropDownForEdit = new System.Windows.Forms.ComboBox();
            this.panelManagement = new System.Windows.Forms.Panel();
            this.lblStage3 = new System.Windows.Forms.Label();
            this.imgStage3 = new System.Windows.Forms.PictureBox();
            this.lblStage2 = new System.Windows.Forms.Label();
            this.imgStage2 = new System.Windows.Forms.PictureBox();
            this.lblStage1 = new System.Windows.Forms.Label();
            this.imgStage1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(161, 71);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(173, 20);
            this.inputBox.TabIndex = 0;
            // 
            // addToExistBox
            // 
            this.addToExistBox.FormattingEnabled = true;
            this.addToExistBox.Location = new System.Drawing.Point(158, 230);
            this.addToExistBox.Name = "addToExistBox";
            this.addToExistBox.Size = new System.Drawing.Size(176, 94);
            this.addToExistBox.TabIndex = 1;
            // 
            // submitNewBtn
            // 
            this.submitNewBtn.Location = new System.Drawing.Point(204, 345);
            this.submitNewBtn.Name = "submitNewBtn";
            this.submitNewBtn.Size = new System.Drawing.Size(75, 23);
            this.submitNewBtn.TabIndex = 2;
            this.submitNewBtn.Text = "submit";
            this.submitNewBtn.UseVisualStyleBackColor = true;
            this.submitNewBtn.Click += new System.EventHandler(this.submitNewBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(200, 410);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // existingDropDown
            // 
            this.existingDropDown.FormattingEnabled = true;
            this.existingDropDown.Location = new System.Drawing.Point(645, 83);
            this.existingDropDown.Name = "existingDropDown";
            this.existingDropDown.Size = new System.Drawing.Size(121, 21);
            this.existingDropDown.TabIndex = 4;
            this.existingDropDown.SelectedIndexChanged += new System.EventHandler(this.existingDropDown_SelectedIndexChanged);
            // 
            // editBox
            // 
            this.editBox.Location = new System.Drawing.Point(645, 110);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(100, 20);
            this.editBox.TabIndex = 5;
            // 
            // codeParaEditBox
            // 
            this.codeParaEditBox.Location = new System.Drawing.Point(645, 151);
            this.codeParaEditBox.Name = "codeParaEditBox";
            this.codeParaEditBox.Size = new System.Drawing.Size(288, 71);
            this.codeParaEditBox.TabIndex = 6;
            this.codeParaEditBox.Text = "";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(693, 410);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveChangeBtn
            // 
            this.saveChangeBtn.Location = new System.Drawing.Point(837, 410);
            this.saveChangeBtn.Name = "saveChangeBtn";
            this.saveChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.saveChangeBtn.TabIndex = 8;
            this.saveChangeBtn.Text = "Save";
            this.saveChangeBtn.UseVisualStyleBackColor = true;
            this.saveChangeBtn.Click += new System.EventHandler(this.saveChangeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(595, 410);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // enterInfoLabel
            // 
            this.enterInfoLabel.AutoSize = true;
            this.enterInfoLabel.Location = new System.Drawing.Point(158, 41);
            this.enterInfoLabel.Name = "enterInfoLabel";
            this.enterInfoLabel.Size = new System.Drawing.Size(58, 13);
            this.enterInfoLabel.TabIndex = 10;
            this.enterInfoLabel.Text = "Enter new ";
            // 
            // addToExistingLabel
            // 
            this.addToExistingLabel.AutoSize = true;
            this.addToExistingLabel.Location = new System.Drawing.Point(158, 209);
            this.addToExistingLabel.Name = "addToExistingLabel";
            this.addToExistingLabel.Size = new System.Drawing.Size(204, 13);
            this.addToExistingLabel.TabIndex = 11;
            this.addToExistingLabel.Text = "select the pre-existing things to add this to";
            // 
            // editExistingLbl
            // 
            this.editExistingLbl.AutoSize = true;
            this.editExistingLbl.Location = new System.Drawing.Point(642, 51);
            this.editExistingLbl.Name = "editExistingLbl";
            this.editExistingLbl.Size = new System.Drawing.Size(90, 13);
            this.editExistingLbl.TabIndex = 12;
            this.editExistingLbl.Text = "Edit existing items";
            // 
            // selectExisitingLabel
            // 
            this.selectExisitingLabel.AutoSize = true;
            this.selectExisitingLabel.Location = new System.Drawing.Point(786, 90);
            this.selectExisitingLabel.Name = "selectExisitingLabel";
            this.selectExisitingLabel.Size = new System.Drawing.Size(147, 13);
            this.selectExisitingLabel.TabIndex = 13;
            this.selectExisitingLabel.Text = "Select the existing item to edit";
            // 
            // newCodeParaBox
            // 
            this.newCodeParaBox.Location = new System.Drawing.Point(161, 128);
            this.newCodeParaBox.Name = "newCodeParaBox";
            this.newCodeParaBox.Size = new System.Drawing.Size(307, 56);
            this.newCodeParaBox.TabIndex = 14;
            this.newCodeParaBox.Text = "";
            // 
            // codeParaLbl
            // 
            this.codeParaLbl.AutoSize = true;
            this.codeParaLbl.Location = new System.Drawing.Point(307, 103);
            this.codeParaLbl.Name = "codeParaLbl";
            this.codeParaLbl.Size = new System.Drawing.Size(161, 13);
            this.codeParaLbl.TabIndex = 15;
            this.codeParaLbl.Text = "Type the paragraph for this code";
            // 
            // newCodeSection
            // 
            this.newCodeSection.FormattingEnabled = true;
            this.newCodeSection.Location = new System.Drawing.Point(347, 244);
            this.newCodeSection.Name = "newCodeSection";
            this.newCodeSection.Size = new System.Drawing.Size(121, 21);
            this.newCodeSection.TabIndex = 16;
            // 
            // checkBoxForEdit
            // 
            this.checkBoxForEdit.FormattingEnabled = true;
            this.checkBoxForEdit.Location = new System.Drawing.Point(645, 261);
            this.checkBoxForEdit.Name = "checkBoxForEdit";
            this.checkBoxForEdit.Size = new System.Drawing.Size(288, 94);
            this.checkBoxForEdit.TabIndex = 17;
            // 
            // dropDownForEdit
            // 
            this.dropDownForEdit.FormattingEnabled = true;
            this.dropDownForEdit.Location = new System.Drawing.Point(645, 234);
            this.dropDownForEdit.Name = "dropDownForEdit";
            this.dropDownForEdit.Size = new System.Drawing.Size(121, 21);
            this.dropDownForEdit.TabIndex = 18;
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
            this.panelManagement.TabIndex = 19;
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
            // NewEditDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.panelManagement);
            this.Controls.Add(this.dropDownForEdit);
            this.Controls.Add(this.checkBoxForEdit);
            this.Controls.Add(this.newCodeSection);
            this.Controls.Add(this.codeParaLbl);
            this.Controls.Add(this.newCodeParaBox);
            this.Controls.Add(this.selectExisitingLabel);
            this.Controls.Add(this.editExistingLbl);
            this.Controls.Add(this.addToExistingLabel);
            this.Controls.Add(this.enterInfoLabel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveChangeBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.codeParaEditBox);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.existingDropDown);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitNewBtn);
            this.Controls.Add(this.addToExistBox);
            this.Controls.Add(this.inputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "NewEditDelete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.panelManagement.ResumeLayout(false);
            this.panelManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.CheckedListBox addToExistBox;
        private System.Windows.Forms.Button submitNewBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox existingDropDown;
        private System.Windows.Forms.TextBox editBox;
        private System.Windows.Forms.RichTextBox codeParaEditBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveChangeBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label enterInfoLabel;
        private System.Windows.Forms.Label addToExistingLabel;
        private System.Windows.Forms.Label editExistingLbl;
        private System.Windows.Forms.Label selectExisitingLabel;
        private System.Windows.Forms.RichTextBox newCodeParaBox;
        private System.Windows.Forms.Label codeParaLbl;
        private System.Windows.Forms.ComboBox newCodeSection;
        private System.Windows.Forms.CheckedListBox checkBoxForEdit;
        private System.Windows.Forms.ComboBox dropDownForEdit;
        private System.Windows.Forms.Panel panelManagement;
        private System.Windows.Forms.Label lblStage3;
        private System.Windows.Forms.PictureBox imgStage3;
        private System.Windows.Forms.Label lblStage2;
        private System.Windows.Forms.PictureBox imgStage2;
        private System.Windows.Forms.Label lblStage1;
        private System.Windows.Forms.PictureBox imgStage1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}