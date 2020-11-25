namespace HappyTech
{
    partial class previewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(previewForm));
            this.checklistAppPreview = new System.Windows.Forms.CheckedListBox();
            this.previewBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checklistAppPreview
            // 
            this.checklistAppPreview.FormattingEnabled = true;
            this.checklistAppPreview.Location = new System.Drawing.Point(50, 66);
            this.checklistAppPreview.Name = "checklistAppPreview";
            this.checklistAppPreview.Size = new System.Drawing.Size(553, 289);
            this.checklistAppPreview.TabIndex = 0;
            this.checklistAppPreview.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklistAppPreview_ItemCheck);
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(665, 66);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(98, 40);
            this.previewBtn.TabIndex = 1;
            this.previewBtn.Text = "Preview selected";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(676, 342);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(87, 34);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Cancel";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(676, 382);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(87, 34);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send All";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // previewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.checklistAppPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "previewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.Load += new System.EventHandler(this.previewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checklistAppPreview;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button sendBtn;
    }
}