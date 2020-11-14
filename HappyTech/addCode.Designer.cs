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
            this.codeParaBox = new System.Windows.Forms.RichTextBox();
            this.codeShortBox = new System.Windows.Forms.TextBox();
            this.codeShortLbl = new System.Windows.Forms.Label();
            this.codeParaLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.tagBox = new System.Windows.Forms.ComboBox();
            this.tagLbl = new System.Windows.Forms.Label();
            this.database1DataSet2 = new HappyTech.Database1DataSet2();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagTableAdapter = new HappyTech.Database1DataSet2TableAdapters.TagTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codeParaBox
            // 
            this.codeParaBox.Location = new System.Drawing.Point(23, 215);
            this.codeParaBox.Name = "codeParaBox";
            this.codeParaBox.Size = new System.Drawing.Size(468, 96);
            this.codeParaBox.TabIndex = 0;
            this.codeParaBox.Text = "";
            // 
            // codeShortBox
            // 
            this.codeShortBox.Location = new System.Drawing.Point(23, 128);
            this.codeShortBox.Name = "codeShortBox";
            this.codeShortBox.Size = new System.Drawing.Size(237, 20);
            this.codeShortBox.TabIndex = 1;
            // 
            // codeShortLbl
            // 
            this.codeShortLbl.AutoSize = true;
            this.codeShortLbl.Location = new System.Drawing.Point(23, 109);
            this.codeShortLbl.Name = "codeShortLbl";
            this.codeShortLbl.Size = new System.Drawing.Size(88, 13);
            this.codeShortLbl.TabIndex = 2;
            this.codeShortLbl.Text = "Enter Short Code";
            // 
            // codeParaLbl
            // 
            this.codeParaLbl.AutoSize = true;
            this.codeParaLbl.Location = new System.Drawing.Point(23, 187);
            this.codeParaLbl.Name = "codeParaLbl";
            this.codeParaLbl.Size = new System.Drawing.Size(144, 13);
            this.codeParaLbl.TabIndex = 3;
            this.codeParaLbl.Text = "Enter Paragraph of feedback";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(304, 396);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(26, 342);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // tagBox
            // 
            this.tagBox.DataSource = this.tagBindingSource;
            this.tagBox.DisplayMember = "name";
            this.tagBox.FormattingEnabled = true;
            this.tagBox.Location = new System.Drawing.Point(26, 51);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(121, 21);
            this.tagBox.TabIndex = 6;
            this.tagBox.ValueMember = "name";
            this.tagBox.TextChanged += new System.EventHandler(this.selectTag);
            //this.tagBox.Click += new System.EventHandler(this.addCode_Load);
            // 
            // tagLbl
            // 
            this.tagLbl.AutoSize = true;
            this.tagLbl.Location = new System.Drawing.Point(26, 32);
            this.tagLbl.Name = "tagLbl";
            this.tagLbl.Size = new System.Drawing.Size(170, 13);
            this.tagLbl.TabIndex = 7;
            this.tagLbl.Text = "select the tag to enter the code for";
            // 
            // database1DataSet2
            // 
           // this.database1DataSet2.DataSetName = "Database1DataSet2";
           // this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tagBindingSource
            // 
           // this.tagBindingSource.DataMember = "Tag";
           // this.tagBindingSource.DataSource = this.database1DataSet2;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // addCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tagLbl);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.codeParaLbl);
            this.Controls.Add(this.codeShortLbl);
            this.Controls.Add(this.codeShortBox);
            this.Controls.Add(this.codeParaBox);
            this.Name = "addCode";
            this.Text = "addCode";
            this.Load += new System.EventHandler(this.addCode_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
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
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private Database1DataSet2TableAdapters.TagTableAdapter tagTableAdapter;
    }
}