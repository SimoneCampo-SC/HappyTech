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
            this.database1DataSet = new HappyTech.Database1DataSet();
            this.codeDisplay = new System.Windows.Forms.DataGridView();
            this.codeShortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeParagraphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new HappyTech.Database1DataSet1();
            this.tagTableAdapter = new HappyTech.Database1DataSetTableAdapters.TagTableAdapter();
            this.codesTableAdapter = new HappyTech.Database1DataSet1TableAdapters.CodesTableAdapter();
            this.addTagBtn = new System.Windows.Forms.Button();
            this.addCodeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.selectTagLbl = new System.Windows.Forms.Label();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.tagSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tagSelectBox
            // 
            this.tagSelectBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tagBindingSource, "name", true));
            this.tagSelectBox.DataSource = this.tagBindingSource;
            this.tagSelectBox.DisplayMember = "name";
            this.tagSelectBox.FormattingEnabled = true;
            this.tagSelectBox.Location = new System.Drawing.Point(109, 39);
            this.tagSelectBox.Name = "tagSelectBox";
            this.tagSelectBox.Size = new System.Drawing.Size(133, 21);
            this.tagSelectBox.TabIndex = 0;
            this.tagSelectBox.ValueMember = "name";
            this.tagSelectBox.TextChanged += new System.EventHandler(this.tagSelectBox_SelectedIndexChanged);
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "Tag";
            this.tagBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeDisplay
            // 
            this.codeDisplay.AutoGenerateColumns = false;
            this.codeDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeShortDataGridViewTextBoxColumn,
            this.codeParagraphDataGridViewTextBoxColumn});
            this.codeDisplay.DataSource = this.codesBindingSource;
            this.codeDisplay.Location = new System.Drawing.Point(12, 87);
            this.codeDisplay.Name = "codeDisplay";
            this.codeDisplay.Size = new System.Drawing.Size(712, 219);
            this.codeDisplay.TabIndex = 1;
            this.codeDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.codeDisplay_CellContentClick);
            // 
            // codeShortDataGridViewTextBoxColumn
            // 
            this.codeShortDataGridViewTextBoxColumn.DataPropertyName = "codeShort";
            this.codeShortDataGridViewTextBoxColumn.HeaderText = "codeShort";
            this.codeShortDataGridViewTextBoxColumn.Name = "codeShortDataGridViewTextBoxColumn";
            // 
            // codeParagraphDataGridViewTextBoxColumn
            // 
            this.codeParagraphDataGridViewTextBoxColumn.DataPropertyName = "codeParagraph";
            this.codeParagraphDataGridViewTextBoxColumn.HeaderText = "codeParagraph";
            this.codeParagraphDataGridViewTextBoxColumn.Name = "codeParagraphDataGridViewTextBoxColumn";
            // 
            // codesBindingSource
            // 
            this.codesBindingSource.DataMember = "Codes";
            this.codesBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // codesTableAdapter
            // 
            this.codesTableAdapter.ClearBeforeFill = true;
            // 
            // addTagBtn
            // 
            this.addTagBtn.Location = new System.Drawing.Point(330, 342);
            this.addTagBtn.Name = "addTagBtn";
            this.addTagBtn.Size = new System.Drawing.Size(75, 23);
            this.addTagBtn.TabIndex = 2;
            this.addTagBtn.Text = "Add Tag";
            this.addTagBtn.UseVisualStyleBackColor = true;
            this.addTagBtn.Click += new System.EventHandler(this.addTagBtn_Click);
            // 
            // addCodeBtn
            // 
            this.addCodeBtn.Location = new System.Drawing.Point(167, 342);
            this.addCodeBtn.Name = "addCodeBtn";
            this.addCodeBtn.Size = new System.Drawing.Size(75, 23);
            this.addCodeBtn.TabIndex = 3;
            this.addCodeBtn.Text = "Add Codes";
            this.addCodeBtn.UseVisualStyleBackColor = true;
            this.addCodeBtn.Click += new System.EventHandler(this.addCodeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(697, 405);
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
            this.selectTagLbl.Location = new System.Drawing.Point(109, 20);
            this.selectTagLbl.Name = "selectTagLbl";
            this.selectTagLbl.Size = new System.Drawing.Size(157, 13);
            this.selectTagLbl.TabIndex = 5;
            this.selectTagLbl.Text = "Select the tag to view codes for";
            // 
            // tagBox
            // 
            this.tagBox.Location = new System.Drawing.Point(330, 380);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(229, 20);
            this.tagBox.TabIndex = 6;
            // 
            // tagSubmit
            // 
            this.tagSubmit.Location = new System.Drawing.Point(330, 415);
            this.tagSubmit.Name = "tagSubmit";
            this.tagSubmit.Size = new System.Drawing.Size(75, 23);
            this.tagSubmit.TabIndex = 7;
            this.tagSubmit.Text = "Submit Tag";
            this.tagSubmit.UseVisualStyleBackColor = true;
            this.tagSubmit.Click += new System.EventHandler(this.tagSubmit_Click);
            // 
            // codeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tagSubmit);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.selectTagLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addCodeBtn);
            this.Controls.Add(this.addTagBtn);
            this.Controls.Add(this.codeDisplay);
            this.Controls.Add(this.tagSelectBox);
            this.Name = "codeViewForm";
            this.Text = "codeViewForm";
            this.Load += new System.EventHandler(this.codeViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tagSelectBox;
        private System.Windows.Forms.DataGridView codeDisplay;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private Database1DataSetTableAdapters.TagTableAdapter tagTableAdapter;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource codesBindingSource;
        private Database1DataSet1TableAdapters.CodesTableAdapter codesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeShortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeParagraphDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addTagBtn;
        private System.Windows.Forms.Button addCodeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label selectTagLbl;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.Button tagSubmit;
    }
}