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
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbTemplate = new System.Windows.Forms.Label();
            this.lbCodeList = new System.Windows.Forms.Label();
            this.lbComBox = new System.Windows.Forms.Label();
            this.lbApplicants = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(381, 491);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(618, 491);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 448);
            this.panel1.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(3, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(259, 441);
            this.listBox.TabIndex = 0;
            this.listBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBox_ItemCheck);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbHeader);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Location = new System.Drawing.Point(316, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 448);
            this.panel2.TabIndex = 4;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(3, 1);
            this.lbHeader.MaximumSize = new System.Drawing.Size(278, 0);
            this.lbHeader.MinimumSize = new System.Drawing.Size(278, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(278, 15);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Header";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(0, 28);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(423, 420);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(742, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 448);
            this.panel3.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 448);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Enter your comment here...";
            // 
            // lbTemplate
            // 
            this.lbTemplate.AutoSize = true;
            this.lbTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemplate.Location = new System.Drawing.Point(459, 9);
            this.lbTemplate.Name = "lbTemplate";
            this.lbTemplate.Size = new System.Drawing.Size(74, 16);
            this.lbTemplate.TabIndex = 6;
            this.lbTemplate.Text = "Template";
            // 
            // lbCodeList
            // 
            this.lbCodeList.AutoSize = true;
            this.lbCodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeList.Location = new System.Drawing.Point(121, 9);
            this.lbCodeList.Name = "lbCodeList";
            this.lbCodeList.Size = new System.Drawing.Size(73, 16);
            this.lbCodeList.TabIndex = 7;
            this.lbCodeList.Text = "Code List";
            // 
            // lbComBox
            // 
            this.lbComBox.AutoSize = true;
            this.lbComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComBox.Location = new System.Drawing.Point(768, 9);
            this.lbComBox.Name = "lbComBox";
            this.lbComBox.Size = new System.Drawing.Size(102, 16);
            this.lbComBox.TabIndex = 8;
            this.lbComBox.Text = "Comment Box";
            // 
            // lbApplicants
            // 
            this.lbApplicants.AutoSize = true;
            this.lbApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicants.Location = new System.Drawing.Point(59, 491);
            this.lbApplicants.Name = "lbApplicants";
            this.lbApplicants.Size = new System.Drawing.Size(118, 16);
            this.lbApplicants.TabIndex = 9;
            this.lbApplicants.Text = "Applicant x out of y";
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.lbApplicants);
            this.Controls.Add(this.lbComBox);
            this.Controls.Add(this.lbCodeList);
            this.Controls.Add(this.lbTemplate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbTemplate;
        private System.Windows.Forms.Label lbCodeList;
        private System.Windows.Forms.Label lbComBox;
        private System.Windows.Forms.Label lbApplicants;
        private System.Windows.Forms.CheckedListBox listBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}