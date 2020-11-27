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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(codeViewForm));
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
            this.deleteDbBtn = new System.Windows.Forms.Button();
            this.templateViewBtn = new System.Windows.Forms.Button();
            this.panelManagement = new System.Windows.Forms.Panel();
            this.lblStage3 = new System.Windows.Forms.Label();
            this.imgStage3 = new System.Windows.Forms.PictureBox();
            this.lblStage2 = new System.Windows.Forms.Label();
            this.imgStage2 = new System.Windows.Forms.PictureBox();
            this.lblStage1 = new System.Windows.Forms.Label();
            this.imgStage1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelApplicants = new System.Windows.Forms.Panel();
            this.lblCodeList = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.lblEditTemplates = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lblTempTotalVal = new System.Windows.Forms.Label();
            this.lblTempTotal = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblSectTotalVal = new System.Windows.Forms.Label();
            this.lblSectTotal = new System.Windows.Forms.Label();
            this.lblCodeTotalVal = new System.Windows.Forms.Label();
            this.lblCodeTotal = new System.Windows.Forms.Label();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnAutofill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).BeginInit();
            this.panelManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelApplicants.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagSelectBox
            // 
            this.tagSelectBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tagSelectBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tagSelectBox.DropDownHeight = 200;
            this.tagSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagSelectBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.tagSelectBox.ForeColor = System.Drawing.Color.Black;
            this.tagSelectBox.FormattingEnabled = true;
            this.tagSelectBox.IntegralHeight = false;
            this.tagSelectBox.ItemHeight = 20;
            this.tagSelectBox.Location = new System.Drawing.Point(21, 128);
            this.tagSelectBox.Name = "tagSelectBox";
            this.tagSelectBox.Size = new System.Drawing.Size(174, 26);
            this.tagSelectBox.TabIndex = 0;
            this.tagSelectBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tagSelectBox_DrawItem);
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
            this.codeDisplay.AllowUserToResizeColumns = false;
            this.codeDisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.codeDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.codeDisplay.BackgroundColor = System.Drawing.Color.White;
            this.codeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.codeDisplay.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.codeDisplay.ColumnHeadersHeight = 26;
            this.codeDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            this.codeDisplay.GridColor = System.Drawing.Color.White;
            this.codeDisplay.Location = new System.Drawing.Point(26, 65);
            this.codeDisplay.Name = "codeDisplay";
            this.codeDisplay.ReadOnly = true;
            this.codeDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.codeDisplay.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDisplay.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.codeDisplay.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.codeDisplay.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.codeDisplay.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.codeDisplay.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.codeDisplay.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.codeDisplay.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.codeDisplay.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDisplay.RowTemplate.Height = 26;
            this.codeDisplay.RowTemplate.ReadOnly = true;
            this.codeDisplay.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codeDisplay.Size = new System.Drawing.Size(550, 429);
            this.codeDisplay.TabIndex = 1;
            // 
            // codesBindingSource
            // 
            this.codesBindingSource.DataMember = "Codes";
            // 
            // addTagBtn
            // 
            this.addTagBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.addTagBtn.FlatAppearance.BorderSize = 0;
            this.addTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTagBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.addTagBtn.ForeColor = System.Drawing.Color.White;
            this.addTagBtn.Location = new System.Drawing.Point(170, 34);
            this.addTagBtn.Name = "addTagBtn";
            this.addTagBtn.Size = new System.Drawing.Size(25, 25);
            this.addTagBtn.TabIndex = 2;
            this.addTagBtn.Text = "S";
            this.addTagBtn.UseVisualStyleBackColor = false;
            this.addTagBtn.Visible = false;
            this.addTagBtn.Click += new System.EventHandler(this.addTagBtn_Click);
            // 
            // addCodeBtn
            // 
            this.addCodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.addCodeBtn.FlatAppearance.BorderSize = 0;
            this.addCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCodeBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.addCodeBtn.ForeColor = System.Drawing.Color.White;
            this.addCodeBtn.Location = new System.Drawing.Point(139, 34);
            this.addCodeBtn.Name = "addCodeBtn";
            this.addCodeBtn.Size = new System.Drawing.Size(25, 25);
            this.addCodeBtn.TabIndex = 3;
            this.addCodeBtn.Text = "C";
            this.addCodeBtn.UseVisualStyleBackColor = false;
            this.addCodeBtn.Visible = false;
            this.addCodeBtn.Click += new System.EventHandler(this.addCodeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(21, 340);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(174, 26);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // selectTagLbl
            // 
            this.selectTagLbl.AutoSize = true;
            this.selectTagLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.selectTagLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.selectTagLbl.Location = new System.Drawing.Point(18, 106);
            this.selectTagLbl.Name = "selectTagLbl";
            this.selectTagLbl.Size = new System.Drawing.Size(88, 14);
            this.selectTagLbl.TabIndex = 5;
            this.selectTagLbl.Text = "Select section:";
            // 
            // templateSelectBox
            // 
            this.templateSelectBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.templateSelectBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.templateSelectBox.DropDownHeight = 200;
            this.templateSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.templateSelectBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.templateSelectBox.ForeColor = System.Drawing.Color.Black;
            this.templateSelectBox.FormattingEnabled = true;
            this.templateSelectBox.IntegralHeight = false;
            this.templateSelectBox.ItemHeight = 20;
            this.templateSelectBox.Location = new System.Drawing.Point(21, 72);
            this.templateSelectBox.Name = "templateSelectBox";
            this.templateSelectBox.Size = new System.Drawing.Size(174, 26);
            this.templateSelectBox.TabIndex = 8;
            this.templateSelectBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.templateSelectBox_DrawItem);
            this.templateSelectBox.SelectedIndexChanged += new System.EventHandler(this.templateSelectBox_SelectedIndexChanged);
            // 
            // templateSelectLbl
            // 
            this.templateSelectLbl.AutoSize = true;
            this.templateSelectLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.templateSelectLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.templateSelectLbl.Location = new System.Drawing.Point(18, 50);
            this.templateSelectLbl.Name = "templateSelectLbl";
            this.templateSelectLbl.Size = new System.Drawing.Size(96, 14);
            this.templateSelectLbl.TabIndex = 9;
            this.templateSelectLbl.Text = "Select template:";
            // 
            // deleteDbBtn
            // 
            this.deleteDbBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteDbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDbBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.deleteDbBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteDbBtn.Location = new System.Drawing.Point(438, 7);
            this.deleteDbBtn.Name = "deleteDbBtn";
            this.deleteDbBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteDbBtn.TabIndex = 11;
            this.deleteDbBtn.Text = "Reset";
            this.deleteDbBtn.UseVisualStyleBackColor = true;
            this.deleteDbBtn.Visible = false;
            this.deleteDbBtn.Click += new System.EventHandler(this.deleteDbBtn_Click);
            // 
            // templateViewBtn
            // 
            this.templateViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.templateViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.templateViewBtn.FlatAppearance.BorderSize = 0;
            this.templateViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.templateViewBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.templateViewBtn.ForeColor = System.Drawing.Color.White;
            this.templateViewBtn.Location = new System.Drawing.Point(21, 65);
            this.templateViewBtn.Name = "templateViewBtn";
            this.templateViewBtn.Size = new System.Drawing.Size(174, 26);
            this.templateViewBtn.TabIndex = 10;
            this.templateViewBtn.Text = "Edit Template";
            this.templateViewBtn.UseVisualStyleBackColor = false;
            this.templateViewBtn.Click += new System.EventHandler(this.templateViewBtn_Click);
            // 
            // panelManagement
            // 
            this.panelManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            this.panelManagement.Controls.Add(this.lblStage3);
            this.panelManagement.Controls.Add(this.imgStage3);
            this.panelManagement.Controls.Add(this.lblStage2);
            this.panelManagement.Controls.Add(this.imgStage2);
            this.panelManagement.Controls.Add(this.lblStage1);
            this.panelManagement.Controls.Add(this.imgStage1);
            this.panelManagement.Controls.Add(this.pictureBox1);
            this.panelManagement.Location = new System.Drawing.Point(0, 0);
            this.panelManagement.Name = "panelManagement";
            this.panelManagement.Size = new System.Drawing.Size(100, 564);
            this.panelManagement.TabIndex = 11;
            // 
            // lblStage3
            // 
            this.lblStage3.AutoSize = true;
            this.lblStage3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStage3.ForeColor = System.Drawing.Color.White;
            this.lblStage3.Location = new System.Drawing.Point(24, 370);
            this.lblStage3.Name = "lblStage3";
            this.lblStage3.Size = new System.Drawing.Size(52, 14);
            this.lblStage3.TabIndex = 0;
            this.lblStage3.Text = "Preview";
            // 
            // imgStage3
            // 
            this.imgStage3.Image = global::HappyTech.Properties.Resources.happytech_3;
            this.imgStage3.Location = new System.Drawing.Point(42, 347);
            this.imgStage3.Name = "imgStage3";
            this.imgStage3.Size = new System.Drawing.Size(16, 16);
            this.imgStage3.TabIndex = 42;
            this.imgStage3.TabStop = false;
            // 
            // lblStage2
            // 
            this.lblStage2.AutoSize = true;
            this.lblStage2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStage2.ForeColor = System.Drawing.Color.White;
            this.lblStage2.Location = new System.Drawing.Point(19, 258);
            this.lblStage2.Name = "lblStage2";
            this.lblStage2.Size = new System.Drawing.Size(60, 14);
            this.lblStage2.TabIndex = 0;
            this.lblStage2.Text = "Feedback";
            // 
            // imgStage2
            // 
            this.imgStage2.Image = global::HappyTech.Properties.Resources.happytech_2;
            this.imgStage2.Location = new System.Drawing.Point(42, 235);
            this.imgStage2.Name = "imgStage2";
            this.imgStage2.Size = new System.Drawing.Size(16, 16);
            this.imgStage2.TabIndex = 40;
            this.imgStage2.TabStop = false;
            // 
            // lblStage1
            // 
            this.lblStage1.AutoSize = true;
            this.lblStage1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStage1.ForeColor = System.Drawing.Color.White;
            this.lblStage1.Location = new System.Drawing.Point(17, 146);
            this.lblStage1.Name = "lblStage1";
            this.lblStage1.Size = new System.Drawing.Size(65, 14);
            this.lblStage1.TabIndex = 0;
            this.lblStage1.Text = "Applicants";
            // 
            // imgStage1
            // 
            this.imgStage1.Image = global::HappyTech.Properties.Resources.happytech_1;
            this.imgStage1.Location = new System.Drawing.Point(42, 123);
            this.imgStage1.Name = "imgStage1";
            this.imgStage1.Size = new System.Drawing.Size(16, 16);
            this.imgStage1.TabIndex = 37;
            this.imgStage1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyTech.Properties.Resources.happytech_logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // panelApplicants
            // 
            this.panelApplicants.BackColor = System.Drawing.Color.White;
            this.panelApplicants.Controls.Add(this.btnAutofill);
            this.panelApplicants.Controls.Add(this.btnDebug);
            this.panelApplicants.Controls.Add(this.deleteDbBtn);
            this.panelApplicants.Controls.Add(this.lblCodeList);
            this.panelApplicants.Controls.Add(this.codeDisplay);
            this.panelApplicants.Location = new System.Drawing.Point(126, 25);
            this.panelApplicants.Name = "panelApplicants";
            this.panelApplicants.Size = new System.Drawing.Size(601, 515);
            this.panelApplicants.TabIndex = 15;
            // 
            // lblCodeList
            // 
            this.lblCodeList.AutoSize = true;
            this.lblCodeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodeList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCodeList.Location = new System.Drawing.Point(22, 14);
            this.lblCodeList.Name = "lblCodeList";
            this.lblCodeList.Size = new System.Drawing.Size(112, 24);
            this.lblCodeList.TabIndex = 6;
            this.lblCodeList.Text = "Code List.";
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.White;
            this.panelActions.Controls.Add(this.lblEditTemplates);
            this.panelActions.Controls.Add(this.templateViewBtn);
            this.panelActions.Controls.Add(this.addCodeBtn);
            this.panelActions.Controls.Add(this.addTagBtn);
            this.panelActions.Location = new System.Drawing.Point(747, 25);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(211, 109);
            this.panelActions.TabIndex = 16;
            // 
            // lblEditTemplates
            // 
            this.lblEditTemplates.AutoSize = true;
            this.lblEditTemplates.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEditTemplates.Location = new System.Drawing.Point(17, 14);
            this.lblEditTemplates.Name = "lblEditTemplates";
            this.lblEditTemplates.Size = new System.Drawing.Size(55, 24);
            this.lblEditTemplates.TabIndex = 1;
            this.lblEditTemplates.Text = "Edit.";
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.Controls.Add(this.lblCodeTotalVal);
            this.panelDetails.Controls.Add(this.lblCodeTotal);
            this.panelDetails.Controls.Add(this.selectTagLbl);
            this.panelDetails.Controls.Add(this.tagSelectBox);
            this.panelDetails.Controls.Add(this.templateSelectLbl);
            this.panelDetails.Controls.Add(this.lblSectTotalVal);
            this.panelDetails.Controls.Add(this.lblSectTotal);
            this.panelDetails.Controls.Add(this.templateSelectBox);
            this.panelDetails.Controls.Add(this.lblTempTotalVal);
            this.panelDetails.Controls.Add(this.backBtn);
            this.panelDetails.Controls.Add(this.lblTempTotal);
            this.panelDetails.Controls.Add(this.lblDetails);
            this.panelDetails.Location = new System.Drawing.Point(747, 153);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(211, 387);
            this.panelDetails.TabIndex = 49;
            // 
            // lblTempTotalVal
            // 
            this.lblTempTotalVal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTempTotalVal.ForeColor = System.Drawing.Color.Black;
            this.lblTempTotalVal.Location = new System.Drawing.Point(18, 189);
            this.lblTempTotalVal.Name = "lblTempTotalVal";
            this.lblTempTotalVal.Size = new System.Drawing.Size(177, 14);
            this.lblTempTotalVal.TabIndex = 51;
            this.lblTempTotalVal.Text = "[template_total]";
            this.lblTempTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTempTotal
            // 
            this.lblTempTotal.AutoSize = true;
            this.lblTempTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTempTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lblTempTotal.Location = new System.Drawing.Point(18, 165);
            this.lblTempTotal.Name = "lblTempTotal";
            this.lblTempTotal.Size = new System.Drawing.Size(68, 14);
            this.lblTempTotal.TabIndex = 50;
            this.lblTempTotal.Text = "Templates:";
            this.lblTempTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetails.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDetails.Location = new System.Drawing.Point(17, 14);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(84, 24);
            this.lblDetails.TabIndex = 6;
            this.lblDetails.Text = "Details.";
            // 
            // lblSectTotalVal
            // 
            this.lblSectTotalVal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSectTotalVal.ForeColor = System.Drawing.Color.Black;
            this.lblSectTotalVal.Location = new System.Drawing.Point(18, 249);
            this.lblSectTotalVal.Name = "lblSectTotalVal";
            this.lblSectTotalVal.Size = new System.Drawing.Size(177, 14);
            this.lblSectTotalVal.TabIndex = 53;
            this.lblSectTotalVal.Text = "[section_total]";
            this.lblSectTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSectTotal
            // 
            this.lblSectTotal.AutoSize = true;
            this.lblSectTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSectTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lblSectTotal.Location = new System.Drawing.Point(18, 225);
            this.lblSectTotal.Name = "lblSectTotal";
            this.lblSectTotal.Size = new System.Drawing.Size(58, 14);
            this.lblSectTotal.TabIndex = 52;
            this.lblSectTotal.Text = "Sections:";
            this.lblSectTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodeTotalVal
            // 
            this.lblCodeTotalVal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCodeTotalVal.ForeColor = System.Drawing.Color.Black;
            this.lblCodeTotalVal.Location = new System.Drawing.Point(18, 310);
            this.lblCodeTotalVal.Name = "lblCodeTotalVal";
            this.lblCodeTotalVal.Size = new System.Drawing.Size(177, 14);
            this.lblCodeTotalVal.TabIndex = 55;
            this.lblCodeTotalVal.Text = "[code_total]";
            this.lblCodeTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodeTotal
            // 
            this.lblCodeTotal.AutoSize = true;
            this.lblCodeTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCodeTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lblCodeTotal.Location = new System.Drawing.Point(18, 286);
            this.lblCodeTotal.Name = "lblCodeTotal";
            this.lblCodeTotal.Size = new System.Drawing.Size(46, 14);
            this.lblCodeTotal.TabIndex = 54;
            this.lblCodeTotal.Text = "Codes:";
            this.lblCodeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDebug
            // 
            this.btnDebug.BackColor = System.Drawing.Color.White;
            this.btnDebug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDebug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebug.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDebug.Location = new System.Drawing.Point(519, 7);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 12;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnAutofill
            // 
            this.btnAutofill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAutofill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutofill.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAutofill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAutofill.Location = new System.Drawing.Point(357, 7);
            this.btnAutofill.Name = "btnAutofill";
            this.btnAutofill.Size = new System.Drawing.Size(75, 23);
            this.btnAutofill.TabIndex = 13;
            this.btnAutofill.Text = "Autofill";
            this.btnAutofill.UseVisualStyleBackColor = true;
            this.btnAutofill.Visible = false;
            this.btnAutofill.Click += new System.EventHandler(this.btnAutofill_Click);
            // 
            // codeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelApplicants);
            this.Controls.Add(this.panelManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "codeViewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).EndInit();
            this.panelManagement.ResumeLayout(false);
            this.panelManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelApplicants.ResumeLayout(false);
            this.panelApplicants.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button templateViewBtn;
        private System.Windows.Forms.Button deleteDbBtn;
        private System.Windows.Forms.Panel panelManagement;
        private System.Windows.Forms.Label lblStage3;
        private System.Windows.Forms.PictureBox imgStage3;
        private System.Windows.Forms.Label lblStage2;
        private System.Windows.Forms.PictureBox imgStage2;
        private System.Windows.Forms.Label lblStage1;
        private System.Windows.Forms.PictureBox imgStage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelApplicants;
        private System.Windows.Forms.Label lblCodeList;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Label lblEditTemplates;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label lblTempTotalVal;
        private System.Windows.Forms.Label lblTempTotal;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblCodeTotalVal;
        private System.Windows.Forms.Label lblCodeTotal;
        private System.Windows.Forms.Label lblSectTotalVal;
        private System.Windows.Forms.Label lblSectTotal;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnAutofill;
    }
}