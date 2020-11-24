namespace HappyTech
{
    partial class codeViewForm
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
            this.tagSelectBox = new System.Windows.Forms.ComboBox();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDisplay = new System.Windows.Forms.DataGridView();
            this.codesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addTagBtn = new System.Windows.Forms.Button();
            this.addCodeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.selectTagLbl = new System.Windows.Forms.Label();
            this.templateSelectBox = new System.Windows.Forms.ComboBox();
            this.templateSelectLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.templateViewBtn = new System.Windows.Forms.Button();
            this.templateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.templateSubmitBtn = new System.Windows.Forms.Button();
            this.tempGroupBox = new System.Windows.Forms.GroupBox();
            this.successfulTempLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tempGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagSelectBox
            // 
            this.tagSelectBox.FormattingEnabled = true;
            this.tagSelectBox.Location = new System.Drawing.Point(189, 54);
            this.tagSelectBox.Name = "tagSelectBox";
            this.tagSelectBox.Size = new System.Drawing.Size(133, 21);
            this.tagSelectBox.TabIndex = 0;
            this.tagSelectBox.SelectedIndexChanged += new System.EventHandler(this.tagSelectBox_SelectedIndexChanged);
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "Tag";
            // 
            // codeDisplay
            // 
            this.codeDisplay.AllowUserToAddRows = false;
            this.codeDisplay.AllowUserToDeleteRows = false;
            this.codeDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeDisplay.Location = new System.Drawing.Point(29, 96);
            this.codeDisplay.Name = "codeDisplay";
            this.codeDisplay.ReadOnly = true;
            this.codeDisplay.Size = new System.Drawing.Size(712, 186);
            this.codeDisplay.TabIndex = 1;
            // 
            // codesBindingSource
            // 
            this.codesBindingSource.DataMember = "Codes";
            // 
            // addTagBtn
            // 
            this.addTagBtn.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.addTagBtn.ForeColor = System.Drawing.Color.White;
            this.addTagBtn.Location = new System.Drawing.Point(252, 317);
            this.addTagBtn.Name = "addTagBtn";
            this.addTagBtn.Size = new System.Drawing.Size(94, 40);
            this.addTagBtn.TabIndex = 2;
            this.addTagBtn.Text = "Add Section";
            this.addTagBtn.UseVisualStyleBackColor = true;
            this.addTagBtn.Click += new System.EventHandler(this.addTagBtn_Click);
            // 
            // addCodeBtn
            // 
            this.addCodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.addCodeBtn.ForeColor = System.Drawing.Color.White;
            this.addCodeBtn.Location = new System.Drawing.Point(29, 317);
            this.addCodeBtn.Name = "addCodeBtn";
            this.addCodeBtn.Size = new System.Drawing.Size(99, 40);
            this.addCodeBtn.TabIndex = 3;
            this.addCodeBtn.Text = "Add Codes";
            this.addCodeBtn.UseVisualStyleBackColor = false;
            this.addCodeBtn.Click += new System.EventHandler(this.addCodeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(666, 326);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // selectTagLbl
            // 
            this.selectTagLbl.AutoSize = true;
            this.selectTagLbl.Location = new System.Drawing.Point(26, 54);
            this.selectTagLbl.Name = "selectTagLbl";
            this.selectTagLbl.Size = new System.Drawing.Size(157, 13);
            this.selectTagLbl.TabIndex = 5;
            this.selectTagLbl.Text = "Select the tag to view codes for";
            // 
            // templateSelectBox
            // 
            this.templateSelectBox.FormattingEnabled = true;
            this.templateSelectBox.Location = new System.Drawing.Point(189, 9);
            this.templateSelectBox.Name = "templateSelectBox";
            this.templateSelectBox.Size = new System.Drawing.Size(133, 21);
            this.templateSelectBox.TabIndex = 8;
            this.templateSelectBox.SelectedIndexChanged += new System.EventHandler(this.templateSelectBox_SelectedIndexChanged);
            // 
            // templateSelectLbl
            // 
            this.templateSelectLbl.AutoSize = true;
            this.templateSelectLbl.Location = new System.Drawing.Point(11, 12);
            this.templateSelectLbl.Name = "templateSelectLbl";
            this.templateSelectLbl.Size = new System.Drawing.Size(172, 13);
            this.templateSelectLbl.TabIndex = 9;
            this.templateSelectLbl.Text = "select template to view sections for";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.templateViewBtn);
            this.groupBox1.Controls.Add(this.templateSelectLbl);
            this.groupBox1.Controls.Add(this.addTagBtn);
            this.groupBox1.Controls.Add(this.templateSelectBox);
            this.groupBox1.Controls.Add(this.backBtn);
            this.groupBox1.Controls.Add(this.selectTagLbl);
            this.groupBox1.Controls.Add(this.addCodeBtn);
            this.groupBox1.Controls.Add(this.codeDisplay);
            this.groupBox1.Controls.Add(this.tagSelectBox);
            this.groupBox1.Location = new System.Drawing.Point(116, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 373);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // templateViewBtn
            // 
            this.templateViewBtn.Location = new System.Drawing.Point(143, 317);
            this.templateViewBtn.Name = "templateViewBtn";
            this.templateViewBtn.Size = new System.Drawing.Size(89, 40);
            this.templateViewBtn.TabIndex = 10;
            this.templateViewBtn.Text = "Add Templates";
            this.templateViewBtn.UseVisualStyleBackColor = true;
            this.templateViewBtn.Click += new System.EventHandler(this.templateViewBtn_Click);
            // 
            // templateBox
            // 
            this.templateBox.Location = new System.Drawing.Point(21, 57);
            this.templateBox.Name = "templateBox";
            this.templateBox.Size = new System.Drawing.Size(183, 20);
            this.templateBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Template Name";
            // 
            // templateSubmitBtn
            // 
            this.templateSubmitBtn.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.templateSubmitBtn.ForeColor = System.Drawing.Color.White;
            this.templateSubmitBtn.Location = new System.Drawing.Point(24, 105);
            this.templateSubmitBtn.Name = "templateSubmitBtn";
            this.templateSubmitBtn.Size = new System.Drawing.Size(107, 23);
            this.templateSubmitBtn.TabIndex = 13;
            this.templateSubmitBtn.Text = "submit template";
            this.templateSubmitBtn.UseVisualStyleBackColor = true;
            this.templateSubmitBtn.Click += new System.EventHandler(this.templateSubmitBtn_Click);
            // 
            // tempGroupBox
            // 
            this.tempGroupBox.Controls.Add(this.templateSubmitBtn);
            this.tempGroupBox.Controls.Add(this.label1);
            this.tempGroupBox.Controls.Add(this.templateBox);
            this.tempGroupBox.Location = new System.Drawing.Point(116, 404);
            this.tempGroupBox.Name = "tempGroupBox";
            this.tempGroupBox.Size = new System.Drawing.Size(273, 146);
            this.tempGroupBox.TabIndex = 17;
            this.tempGroupBox.TabStop = false;
            // 
            // successfulTempLbl
            // 
            this.successfulTempLbl.AutoSize = true;
            this.successfulTempLbl.Location = new System.Drawing.Point(405, 420);
            this.successfulTempLbl.Name = "successfulTempLbl";
            this.successfulTempLbl.Size = new System.Drawing.Size(452, 13);
            this.successfulTempLbl.TabIndex = 18;
            this.successfulTempLbl.Text = "Template created successfully! Add some  sections to this Template and then add s" +
    "ome codes";
            // 
            // codeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.successfulTempLbl);
            this.Controls.Add(this.tempGroupBox);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "codeViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "codeViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tempGroupBox.ResumeLayout(false);
            this.tempGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tagSelectBox;
        private System.Windows.Forms.DataGridView codeDisplay;
       // private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tagBindingSource;
       // private Database1DataSetTableAdapters.TagTableAdapter tagTableAdapter;
       // private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource codesBindingSource;
       // private Database1DataSet1TableAdapters.CodesTableAdapter codesTableAdapter;
        private System.Windows.Forms.Button addTagBtn;
        private System.Windows.Forms.Button addCodeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label selectTagLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeShortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeParagraphDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox templateSelectBox;
        private System.Windows.Forms.Label templateSelectLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button templateViewBtn;
        private System.Windows.Forms.TextBox templateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button templateSubmitBtn;
        private System.Windows.Forms.GroupBox tempGroupBox;
        private System.Windows.Forms.Label successfulTempLbl;
    }
}