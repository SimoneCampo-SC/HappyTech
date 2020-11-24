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
            this.tagSubmit = new System.Windows.Forms.Button();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.templatesListBox = new System.Windows.Forms.CheckedListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.addCodes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tagSubmit
            // 
            this.tagSubmit.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.tagSubmit.ForeColor = System.Drawing.Color.White;
            this.tagSubmit.Location = new System.Drawing.Point(233, 348);
            this.tagSubmit.Name = "tagSubmit";
            this.tagSubmit.Size = new System.Drawing.Size(75, 23);
            this.tagSubmit.TabIndex = 7;
            this.tagSubmit.Text = "Submit Tag";
            this.tagSubmit.UseVisualStyleBackColor = true;
            this.tagSubmit.Click += new System.EventHandler(this.tagSubmit_Click);
            // 
            // tagBox
            // 
            this.tagBox.Location = new System.Drawing.Point(131, 74);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(229, 20);
            this.tagBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter New Section Name";
            // 
            // templatesListBox
            // 
            this.templatesListBox.FormattingEnabled = true;
            this.templatesListBox.Location = new System.Drawing.Point(131, 160);
            this.templatesListBox.Name = "templatesListBox";
            this.templatesListBox.Size = new System.Drawing.Size(331, 169);
            this.templatesListBox.TabIndex = 15;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(233, 388);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addCodes
            // 
            this.addCodes.Location = new System.Drawing.Point(689, 478);
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
            this.label1.Location = new System.Drawing.Point(128, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "select one or more templates to add this section to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Now click the button below to add some codes to the new section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "vvvvvvvvvvvv";
            // 
            // addSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCodes);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.templatesListBox);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tagSubmit);
            this.Name = "addSections";
            this.Text = "addSections";
            this.Load += new System.EventHandler(this.addSections_Load);
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
    }
}