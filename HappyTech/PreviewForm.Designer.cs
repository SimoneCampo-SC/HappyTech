namespace HappyTech
{
    partial class PreviewForm
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
            this.btnPreview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checklistAppPreview = new System.Windows.Forms.CheckedListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(673, 33);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(96, 35);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Preview Email";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checklistAppPreview);
            this.panel1.Location = new System.Drawing.Point(37, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 390);
            this.panel1.TabIndex = 1;
            // 
            // checklistAppPreview
            // 
            this.checklistAppPreview.FormattingEnabled = true;
            this.checklistAppPreview.Location = new System.Drawing.Point(3, 4);
            this.checklistAppPreview.Name = "checklistAppPreview";
            this.checklistAppPreview.Size = new System.Drawing.Size(594, 379);
            this.checklistAppPreview.TabIndex = 0;
            this.checklistAppPreview.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklistAppPreview_ItemCheck);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(673, 338);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(673, 379);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(96, 35);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send All";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPreview);
            this.Name = "PreviewForm";
            this.Text = "PreviewForm";
            this.Load += new System.EventHandler(this.PreviewForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checklistAppPreview;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSend;
    }
}