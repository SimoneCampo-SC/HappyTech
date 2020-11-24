namespace HappyTech
{
    partial class addCode
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
            this.components = new System.ComponentModel.Container();
            this.sectionBox = new System.Windows.Forms.ComboBox();
            this.sectionLbl = new System.Windows.Forms.Label();
            this.codeShortBx = new System.Windows.Forms.TextBox();
            this.codeShortLb = new System.Windows.Forms.Label();
            this.codeParaBx = new System.Windows.Forms.RichTextBox();
            this.codeParaLb = new System.Windows.Forms.Label();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sectionBox
            // 
            this.sectionBox.FormattingEnabled = true;
            this.sectionBox.Location = new System.Drawing.Point(121, 156);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(154, 21);
            this.sectionBox.TabIndex = 0;
            // 
            // sectionLbl
            // 
            this.sectionLbl.AutoSize = true;
            this.sectionLbl.Location = new System.Drawing.Point(118, 126);
            this.sectionLbl.Name = "sectionLbl";
            this.sectionLbl.Size = new System.Drawing.Size(179, 13);
            this.sectionLbl.TabIndex = 1;
            this.sectionLbl.Text = "select section to attach new code to";
            // 
            // codeShortBx
            // 
            this.codeShortBx.Location = new System.Drawing.Point(118, 80);
            this.codeShortBx.Name = "codeShortBx";
            this.codeShortBx.Size = new System.Drawing.Size(100, 20);
            this.codeShortBx.TabIndex = 2;
            // 
            // codeShortLb
            // 
            this.codeShortLb.AutoSize = true;
            this.codeShortLb.Location = new System.Drawing.Point(118, 61);
            this.codeShortLb.Name = "codeShortLb";
            this.codeShortLb.Size = new System.Drawing.Size(103, 13);
            this.codeShortLb.TabIndex = 3;
            this.codeShortLb.Text = "Enter the short code";
            this.codeShortLb.Click += new System.EventHandler(this.label1_Click);
            // 
            // codeParaBx
            // 
            this.codeParaBx.Location = new System.Drawing.Point(121, 221);
            this.codeParaBx.Name = "codeParaBx";
            this.codeParaBx.Size = new System.Drawing.Size(367, 96);
            this.codeParaBx.TabIndex = 4;
            this.codeParaBx.Text = "";
            // 
            // codeParaLb
            // 
            this.codeParaLb.AutoSize = true;
            this.codeParaLb.Location = new System.Drawing.Point(124, 202);
            this.codeParaLb.Name = "codeParaLb";
            this.codeParaLb.Size = new System.Drawing.Size(364, 13);
            this.codeParaLb.TabIndex = 5;
            this.codeParaLb.Text = "Enter the paragraph of feedback to be produced when this code is selected";
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(300, 342);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 6;
            this.buttonSub.Text = "submit";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(300, 389);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(75, 23);
            this.buttonback.TabIndex = 7;
            this.buttonback.Text = "back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "Section";
            // 
            // addCode
            // 
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.codeParaLb);
            this.Controls.Add(this.codeParaBx);
            this.Controls.Add(this.codeShortLb);
            this.Controls.Add(this.codeShortBx);
            this.Controls.Add(this.sectionLbl);
            this.Controls.Add(this.sectionBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "addCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.addCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox codeParaBox;
        private System.Windows.Forms.TextBox codeShortBox;
        private System.Windows.Forms.Label codeShortLbl;
        private System.Windows.Forms.Label codeParaLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ComboBox tagBox;
        private System.Windows.Forms.Label tagLbl;
        //private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource tagBindingSource;
       // private Database1DataSet2TableAdapters.TagTableAdapter tagTableAdapter;
        private System.Windows.Forms.ComboBox sectionBox;
        //private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource sectionBindingSource;
       // private Database1DataSet3TableAdapters.SectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.Label sectionLbl;
        private System.Windows.Forms.TextBox codeShortBx;
        private System.Windows.Forms.Label codeShortLb;
        private System.Windows.Forms.RichTextBox codeParaBx;
        private System.Windows.Forms.Label codeParaLb;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonback;
    }
}