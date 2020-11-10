namespace HappyTech
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbTemplate = new System.Windows.Forms.Label();
            this.lbCodeList = new System.Windows.Forms.Label();
            this.lbComBox = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelTypeVal = new System.Windows.Forms.Label();
            this.checklistSelectedCodes = new System.Windows.Forms.CheckedListBox();
            this.checklistAllCodes = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checklistAllCodes);
            this.panel1.Controls.Add(this.checklistSelectedCodes);
            this.panel1.Controls.Add(this.labelTypeVal);
            this.panel1.Controls.Add(this.labelType);
            this.panel1.Location = new System.Drawing.Point(26, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 361);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Location = new System.Drawing.Point(235, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 361);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Header";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(0, 23);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(326, 338);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(567, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 361);
            this.panel3.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 338);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Enter your comment here...";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbTemplate
            // 
            this.lbTemplate.AutoSize = true;
            this.lbTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemplate.Location = new System.Drawing.Point(363, 9);
            this.lbTemplate.Name = "lbTemplate";
            this.lbTemplate.Size = new System.Drawing.Size(74, 16);
            this.lbTemplate.TabIndex = 6;
            this.lbTemplate.Text = "Template";
            // 
            // lbCodeList
            // 
            this.lbCodeList.AutoSize = true;
            this.lbCodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeList.Location = new System.Drawing.Point(90, 9);
            this.lbCodeList.Name = "lbCodeList";
            this.lbCodeList.Size = new System.Drawing.Size(73, 16);
            this.lbCodeList.TabIndex = 7;
            this.lbCodeList.Text = "Code List";
            // 
            // lbComBox
            // 
            this.lbComBox.AutoSize = true;
            this.lbComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComBox.Location = new System.Drawing.Point(609, 9);
            this.lbComBox.Name = "lbComBox";
            this.lbComBox.Size = new System.Drawing.Size(102, 16);
            this.lbComBox.TabIndex = 8;
            this.lbComBox.Text = "Comment Box";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(3, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(109, 20);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Feeback type:";
            // 
            // labelTypeVal
            // 
            this.labelTypeVal.AutoSize = true;
            this.labelTypeVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeVal.Location = new System.Drawing.Point(118, 0);
            this.labelTypeVal.Name = "labelTypeVal";
            this.labelTypeVal.Size = new System.Drawing.Size(47, 20);
            this.labelTypeVal.TabIndex = 3;
            this.labelTypeVal.Text = "[type]";
            // 
            // checklistSelectedCodes
            // 
            this.checklistSelectedCodes.FormattingEnabled = true;
            this.checklistSelectedCodes.Location = new System.Drawing.Point(3, 23);
            this.checklistSelectedCodes.Name = "checklistSelectedCodes";
            this.checklistSelectedCodes.Size = new System.Drawing.Size(197, 169);
            this.checklistSelectedCodes.TabIndex = 2;
            this.checklistSelectedCodes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklistSelectedCodes_ItemCheck);
            this.checklistSelectedCodes.SelectedIndexChanged += new System.EventHandler(this.checklistSelectedCodes_SelectedIndexChanged);
            // 
            // checklistAllCodes
            // 
            this.checklistAllCodes.FormattingEnabled = true;
            this.checklistAllCodes.Location = new System.Drawing.Point(3, 204);
            this.checklistAllCodes.Name = "checklistAllCodes";
            this.checklistAllCodes.Size = new System.Drawing.Size(197, 154);
            this.checklistAllCodes.TabIndex = 4;
            this.checklistAllCodes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklistAllCodes_ItemCheck);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbComBox);
            this.Controls.Add(this.lbCodeList);
            this.Controls.Add(this.lbTemplate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbTemplate;
        private System.Windows.Forms.Label lbCodeList;
        private System.Windows.Forms.Label lbComBox;
        private System.Windows.Forms.Label labelTypeVal;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.CheckedListBox checklistAllCodes;
        private System.Windows.Forms.CheckedListBox checklistSelectedCodes;
    }
}