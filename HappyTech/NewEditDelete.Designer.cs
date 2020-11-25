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
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(15, 68);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(173, 20);
            this.inputBox.TabIndex = 0;
            // 
            // addToExistBox
            // 
            this.addToExistBox.FormattingEnabled = true;
            this.addToExistBox.Location = new System.Drawing.Point(12, 227);
            this.addToExistBox.Name = "addToExistBox";
            this.addToExistBox.Size = new System.Drawing.Size(176, 94);
            this.addToExistBox.TabIndex = 1;
            // 
            // submitNewBtn
            // 
            this.submitNewBtn.Location = new System.Drawing.Point(58, 342);
            this.submitNewBtn.Name = "submitNewBtn";
            this.submitNewBtn.Size = new System.Drawing.Size(75, 23);
            this.submitNewBtn.TabIndex = 2;
            this.submitNewBtn.Text = "submit";
            this.submitNewBtn.UseVisualStyleBackColor = true;
            this.submitNewBtn.Click += new System.EventHandler(this.submitNewBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(54, 407);
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
            this.existingDropDown.Location = new System.Drawing.Point(499, 80);
            this.existingDropDown.Name = "existingDropDown";
            this.existingDropDown.Size = new System.Drawing.Size(121, 21);
            this.existingDropDown.TabIndex = 4;
            this.existingDropDown.SelectedIndexChanged += new System.EventHandler(this.existingDropDown_SelectedIndexChanged);
            // 
            // editBox
            // 
            this.editBox.Location = new System.Drawing.Point(499, 107);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(100, 20);
            this.editBox.TabIndex = 5;
            // 
            // codeParaEditBox
            // 
            this.codeParaEditBox.Location = new System.Drawing.Point(499, 148);
            this.codeParaEditBox.Name = "codeParaEditBox";
            this.codeParaEditBox.Size = new System.Drawing.Size(288, 71);
            this.codeParaEditBox.TabIndex = 6;
            this.codeParaEditBox.Text = "";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(547, 407);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveChangeBtn
            // 
            this.saveChangeBtn.Location = new System.Drawing.Point(691, 407);
            this.saveChangeBtn.Name = "saveChangeBtn";
            this.saveChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.saveChangeBtn.TabIndex = 8;
            this.saveChangeBtn.Text = "Save";
            this.saveChangeBtn.UseVisualStyleBackColor = true;
            this.saveChangeBtn.Click += new System.EventHandler(this.saveChangeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(449, 407);
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
            this.enterInfoLabel.Location = new System.Drawing.Point(12, 38);
            this.enterInfoLabel.Name = "enterInfoLabel";
            this.enterInfoLabel.Size = new System.Drawing.Size(58, 13);
            this.enterInfoLabel.TabIndex = 10;
            this.enterInfoLabel.Text = "Enter new ";
            // 
            // addToExistingLabel
            // 
            this.addToExistingLabel.AutoSize = true;
            this.addToExistingLabel.Location = new System.Drawing.Point(12, 206);
            this.addToExistingLabel.Name = "addToExistingLabel";
            this.addToExistingLabel.Size = new System.Drawing.Size(204, 13);
            this.addToExistingLabel.TabIndex = 11;
            this.addToExistingLabel.Text = "select the pre-existing things to add this to";
            // 
            // editExistingLbl
            // 
            this.editExistingLbl.AutoSize = true;
            this.editExistingLbl.Location = new System.Drawing.Point(496, 48);
            this.editExistingLbl.Name = "editExistingLbl";
            this.editExistingLbl.Size = new System.Drawing.Size(90, 13);
            this.editExistingLbl.TabIndex = 12;
            this.editExistingLbl.Text = "Edit existing items";
            // 
            // selectExisitingLabel
            // 
            this.selectExisitingLabel.AutoSize = true;
            this.selectExisitingLabel.Location = new System.Drawing.Point(640, 87);
            this.selectExisitingLabel.Name = "selectExisitingLabel";
            this.selectExisitingLabel.Size = new System.Drawing.Size(147, 13);
            this.selectExisitingLabel.TabIndex = 13;
            this.selectExisitingLabel.Text = "Select the existing item to edit";
            // 
            // newCodeParaBox
            // 
            this.newCodeParaBox.Location = new System.Drawing.Point(15, 125);
            this.newCodeParaBox.Name = "newCodeParaBox";
            this.newCodeParaBox.Size = new System.Drawing.Size(307, 56);
            this.newCodeParaBox.TabIndex = 14;
            this.newCodeParaBox.Text = "";
            // 
            // codeParaLbl
            // 
            this.codeParaLbl.AutoSize = true;
            this.codeParaLbl.Location = new System.Drawing.Point(161, 100);
            this.codeParaLbl.Name = "codeParaLbl";
            this.codeParaLbl.Size = new System.Drawing.Size(161, 13);
            this.codeParaLbl.TabIndex = 15;
            this.codeParaLbl.Text = "Type the paragraph for this code";
            // 
            // newCodeSection
            // 
            this.newCodeSection.FormattingEnabled = true;
            this.newCodeSection.Location = new System.Drawing.Point(201, 241);
            this.newCodeSection.Name = "newCodeSection";
            this.newCodeSection.Size = new System.Drawing.Size(121, 21);
            this.newCodeSection.TabIndex = 16;
            // 
            // checkBoxForEdit
            // 
            this.checkBoxForEdit.FormattingEnabled = true;
            this.checkBoxForEdit.Location = new System.Drawing.Point(499, 258);
            this.checkBoxForEdit.Name = "checkBoxForEdit";
            this.checkBoxForEdit.Size = new System.Drawing.Size(288, 94);
            this.checkBoxForEdit.TabIndex = 17;
            // 
            // dropDownForEdit
            // 
            this.dropDownForEdit.FormattingEnabled = true;
            this.dropDownForEdit.Location = new System.Drawing.Point(499, 231);
            this.dropDownForEdit.Name = "dropDownForEdit";
            this.dropDownForEdit.Size = new System.Drawing.Size(121, 21);
            this.dropDownForEdit.TabIndex = 18;
            // 
            // NewEditDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "NewEditDelete";
            this.Text = "NewEditDelete";
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
    }
}