namespace HappyTech
{
    partial class CodeViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeViewForm));
            this.ComboBox_SelectSection = new System.Windows.Forms.ComboBox();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGrid_CodeList = new System.Windows.Forms.DataGridView();
            this.codesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Button_Back = new System.Windows.Forms.Button();
            this.Label_SelectSection = new System.Windows.Forms.Label();
            this.ComboBox_SelectTemplate = new System.Windows.Forms.ComboBox();
            this.Label_SelectTemplate = new System.Windows.Forms.Label();
            this.Button_EditTemplate = new System.Windows.Forms.Button();
            this.Panel_Management = new System.Windows.Forms.Panel();
            this.Label_ManagementStage3 = new System.Windows.Forms.Label();
            this.PictureBox_ManagementStage3 = new System.Windows.Forms.PictureBox();
            this.Label_ManagementStage2 = new System.Windows.Forms.Label();
            this.PictureBox_ManagementStage2 = new System.Windows.Forms.PictureBox();
            this.Label_ManagementStage1 = new System.Windows.Forms.Label();
            this.PictureBox_ManagementStage1 = new System.Windows.Forms.PictureBox();
            this.PictureBox_ManagementLogo = new System.Windows.Forms.PictureBox();
            this.Panel_CodeList = new System.Windows.Forms.Panel();
            this.Label_CodeListTitle = new System.Windows.Forms.Label();
            this.Panel_Edit = new System.Windows.Forms.Panel();
            this.Label_EditTitle = new System.Windows.Forms.Label();
            this.Panel_Details = new System.Windows.Forms.Panel();
            this.Label_CodesTotal = new System.Windows.Forms.Label();
            this.Label_Codes = new System.Windows.Forms.Label();
            this.Label_SectionsTotal = new System.Windows.Forms.Label();
            this.Label_Sections = new System.Windows.Forms.Label();
            this.Label_TemplatesTotal = new System.Windows.Forms.Label();
            this.Label_Templates = new System.Windows.Forms.Label();
            this.Label_DetailsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_CodeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).BeginInit();
            this.Panel_Management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementLogo)).BeginInit();
            this.Panel_CodeList.SuspendLayout();
            this.Panel_Edit.SuspendLayout();
            this.Panel_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBox_SelectSection
            // 
            this.ComboBox_SelectSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBox_SelectSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox_SelectSection.DropDownHeight = 200;
            this.ComboBox_SelectSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_SelectSection.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SelectSection.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_SelectSection.FormattingEnabled = true;
            this.ComboBox_SelectSection.IntegralHeight = false;
            this.ComboBox_SelectSection.ItemHeight = 20;
            this.ComboBox_SelectSection.Location = new System.Drawing.Point(21, 128);
            this.ComboBox_SelectSection.Name = "ComboBox_SelectSection";
            this.ComboBox_SelectSection.Size = new System.Drawing.Size(174, 26);
            this.ComboBox_SelectSection.TabIndex = 0;
            this.ComboBox_SelectSection.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_SelectSection_DrawItem);
            this.ComboBox_SelectSection.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectSection_SelectedIndexChanged);
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "Tag";
            // 
            // DataGrid_CodeList
            // 
            this.DataGrid_CodeList.AllowUserToAddRows = false;
            this.DataGrid_CodeList.AllowUserToDeleteRows = false;
            this.DataGrid_CodeList.AllowUserToResizeColumns = false;
            this.DataGrid_CodeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_CodeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_CodeList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid_CodeList.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_CodeList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid_CodeList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_CodeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_CodeList.ColumnHeadersHeight = 26;
            this.DataGrid_CodeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_CodeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_CodeList.GridColor = System.Drawing.Color.White;
            this.DataGrid_CodeList.Location = new System.Drawing.Point(26, 65);
            this.DataGrid_CodeList.Name = "DataGrid_CodeList";
            this.DataGrid_CodeList.ReadOnly = true;
            this.DataGrid_CodeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_CodeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid_CodeList.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_CodeList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid_CodeList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataGrid_CodeList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_CodeList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.DataGrid_CodeList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGrid_CodeList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.DataGrid_CodeList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGrid_CodeList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_CodeList.RowTemplate.Height = 26;
            this.DataGrid_CodeList.RowTemplate.ReadOnly = true;
            this.DataGrid_CodeList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_CodeList.Size = new System.Drawing.Size(550, 429);
            this.DataGrid_CodeList.TabIndex = 1;
            // 
            // codesBindingSource
            // 
            this.codesBindingSource.DataMember = "Codes";
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.Button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Back.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Button_Back.FlatAppearance.BorderSize = 0;
            this.Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Back.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Button_Back.ForeColor = System.Drawing.Color.White;
            this.Button_Back.Location = new System.Drawing.Point(21, 340);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(174, 26);
            this.Button_Back.TabIndex = 4;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Label_SelectSection
            // 
            this.Label_SelectSection.AutoSize = true;
            this.Label_SelectSection.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_SelectSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_SelectSection.Location = new System.Drawing.Point(18, 106);
            this.Label_SelectSection.Name = "Label_SelectSection";
            this.Label_SelectSection.Size = new System.Drawing.Size(88, 14);
            this.Label_SelectSection.TabIndex = 5;
            this.Label_SelectSection.Text = "Select section:";
            // 
            // ComboBox_SelectTemplate
            // 
            this.ComboBox_SelectTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBox_SelectTemplate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox_SelectTemplate.DropDownHeight = 200;
            this.ComboBox_SelectTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_SelectTemplate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.ComboBox_SelectTemplate.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_SelectTemplate.FormattingEnabled = true;
            this.ComboBox_SelectTemplate.IntegralHeight = false;
            this.ComboBox_SelectTemplate.ItemHeight = 20;
            this.ComboBox_SelectTemplate.Location = new System.Drawing.Point(21, 72);
            this.ComboBox_SelectTemplate.Name = "ComboBox_SelectTemplate";
            this.ComboBox_SelectTemplate.Size = new System.Drawing.Size(174, 26);
            this.ComboBox_SelectTemplate.TabIndex = 8;
            this.ComboBox_SelectTemplate.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_SelectTemplate_DrawItem);
            this.ComboBox_SelectTemplate.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectTemplate_SelectedIndexChanged);
            // 
            // Label_SelectTemplate
            // 
            this.Label_SelectTemplate.AutoSize = true;
            this.Label_SelectTemplate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_SelectTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_SelectTemplate.Location = new System.Drawing.Point(18, 50);
            this.Label_SelectTemplate.Name = "Label_SelectTemplate";
            this.Label_SelectTemplate.Size = new System.Drawing.Size(96, 14);
            this.Label_SelectTemplate.TabIndex = 9;
            this.Label_SelectTemplate.Text = "Select template:";
            // 
            // Button_EditTemplate
            // 
            this.Button_EditTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.Button_EditTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_EditTemplate.FlatAppearance.BorderSize = 0;
            this.Button_EditTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_EditTemplate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Button_EditTemplate.ForeColor = System.Drawing.Color.White;
            this.Button_EditTemplate.Location = new System.Drawing.Point(21, 65);
            this.Button_EditTemplate.Name = "Button_EditTemplate";
            this.Button_EditTemplate.Size = new System.Drawing.Size(174, 26);
            this.Button_EditTemplate.TabIndex = 10;
            this.Button_EditTemplate.Text = "Edit Template";
            this.Button_EditTemplate.UseVisualStyleBackColor = false;
            this.Button_EditTemplate.Click += new System.EventHandler(this.Button_EditTemplate_Click);
            // 
            // Panel_Management
            // 
            this.Panel_Management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            this.Panel_Management.Controls.Add(this.Label_ManagementStage3);
            this.Panel_Management.Controls.Add(this.PictureBox_ManagementStage3);
            this.Panel_Management.Controls.Add(this.Label_ManagementStage2);
            this.Panel_Management.Controls.Add(this.PictureBox_ManagementStage2);
            this.Panel_Management.Controls.Add(this.Label_ManagementStage1);
            this.Panel_Management.Controls.Add(this.PictureBox_ManagementStage1);
            this.Panel_Management.Controls.Add(this.PictureBox_ManagementLogo);
            this.Panel_Management.Location = new System.Drawing.Point(0, 0);
            this.Panel_Management.Name = "Panel_Management";
            this.Panel_Management.Size = new System.Drawing.Size(100, 564);
            this.Panel_Management.TabIndex = 11;
            // 
            // Label_ManagementStage3
            // 
            this.Label_ManagementStage3.AutoSize = true;
            this.Label_ManagementStage3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ManagementStage3.ForeColor = System.Drawing.Color.White;
            this.Label_ManagementStage3.Location = new System.Drawing.Point(24, 370);
            this.Label_ManagementStage3.Name = "Label_ManagementStage3";
            this.Label_ManagementStage3.Size = new System.Drawing.Size(52, 14);
            this.Label_ManagementStage3.TabIndex = 0;
            this.Label_ManagementStage3.Text = "Preview";
            // 
            // PictureBox_ManagementStage3
            // 
            this.PictureBox_ManagementStage3.Image = global::HappyTech.Properties.Resources.happytech_3;
            this.PictureBox_ManagementStage3.Location = new System.Drawing.Point(42, 347);
            this.PictureBox_ManagementStage3.Name = "PictureBox_ManagementStage3";
            this.PictureBox_ManagementStage3.Size = new System.Drawing.Size(16, 16);
            this.PictureBox_ManagementStage3.TabIndex = 42;
            this.PictureBox_ManagementStage3.TabStop = false;
            // 
            // Label_ManagementStage2
            // 
            this.Label_ManagementStage2.AutoSize = true;
            this.Label_ManagementStage2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ManagementStage2.ForeColor = System.Drawing.Color.White;
            this.Label_ManagementStage2.Location = new System.Drawing.Point(19, 258);
            this.Label_ManagementStage2.Name = "Label_ManagementStage2";
            this.Label_ManagementStage2.Size = new System.Drawing.Size(60, 14);
            this.Label_ManagementStage2.TabIndex = 0;
            this.Label_ManagementStage2.Text = "Feedback";
            // 
            // PictureBox_ManagementStage2
            // 
            this.PictureBox_ManagementStage2.Image = global::HappyTech.Properties.Resources.happytech_2;
            this.PictureBox_ManagementStage2.Location = new System.Drawing.Point(42, 235);
            this.PictureBox_ManagementStage2.Name = "PictureBox_ManagementStage2";
            this.PictureBox_ManagementStage2.Size = new System.Drawing.Size(16, 16);
            this.PictureBox_ManagementStage2.TabIndex = 40;
            this.PictureBox_ManagementStage2.TabStop = false;
            // 
            // Label_ManagementStage1
            // 
            this.Label_ManagementStage1.AutoSize = true;
            this.Label_ManagementStage1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ManagementStage1.ForeColor = System.Drawing.Color.White;
            this.Label_ManagementStage1.Location = new System.Drawing.Point(17, 146);
            this.Label_ManagementStage1.Name = "Label_ManagementStage1";
            this.Label_ManagementStage1.Size = new System.Drawing.Size(65, 14);
            this.Label_ManagementStage1.TabIndex = 0;
            this.Label_ManagementStage1.Text = "Applicants";
            // 
            // PictureBox_ManagementStage1
            // 
            this.PictureBox_ManagementStage1.Image = global::HappyTech.Properties.Resources.happytech_1;
            this.PictureBox_ManagementStage1.Location = new System.Drawing.Point(42, 123);
            this.PictureBox_ManagementStage1.Name = "PictureBox_ManagementStage1";
            this.PictureBox_ManagementStage1.Size = new System.Drawing.Size(16, 16);
            this.PictureBox_ManagementStage1.TabIndex = 37;
            this.PictureBox_ManagementStage1.TabStop = false;
            // 
            // PictureBox_ManagementLogo
            // 
            this.PictureBox_ManagementLogo.Image = global::HappyTech.Properties.Resources.happytech_logo_small;
            this.PictureBox_ManagementLogo.Location = new System.Drawing.Point(25, 25);
            this.PictureBox_ManagementLogo.Name = "PictureBox_ManagementLogo";
            this.PictureBox_ManagementLogo.Size = new System.Drawing.Size(45, 38);
            this.PictureBox_ManagementLogo.TabIndex = 34;
            this.PictureBox_ManagementLogo.TabStop = false;
            // 
            // Panel_CodeList
            // 
            this.Panel_CodeList.BackColor = System.Drawing.Color.White;
            this.Panel_CodeList.Controls.Add(this.Label_CodeListTitle);
            this.Panel_CodeList.Controls.Add(this.DataGrid_CodeList);
            this.Panel_CodeList.Location = new System.Drawing.Point(126, 25);
            this.Panel_CodeList.Name = "Panel_CodeList";
            this.Panel_CodeList.Size = new System.Drawing.Size(601, 515);
            this.Panel_CodeList.TabIndex = 15;
            // 
            // Label_CodeListTitle
            // 
            this.Label_CodeListTitle.AutoSize = true;
            this.Label_CodeListTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_CodeListTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label_CodeListTitle.Location = new System.Drawing.Point(22, 14);
            this.Label_CodeListTitle.Name = "Label_CodeListTitle";
            this.Label_CodeListTitle.Size = new System.Drawing.Size(112, 24);
            this.Label_CodeListTitle.TabIndex = 6;
            this.Label_CodeListTitle.Text = "Code List.";
            // 
            // Panel_Edit
            // 
            this.Panel_Edit.BackColor = System.Drawing.Color.White;
            this.Panel_Edit.Controls.Add(this.Label_EditTitle);
            this.Panel_Edit.Controls.Add(this.Button_EditTemplate);
            this.Panel_Edit.Location = new System.Drawing.Point(747, 25);
            this.Panel_Edit.Name = "Panel_Edit";
            this.Panel_Edit.Size = new System.Drawing.Size(211, 109);
            this.Panel_Edit.TabIndex = 16;
            // 
            // Label_EditTitle
            // 
            this.Label_EditTitle.AutoSize = true;
            this.Label_EditTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label_EditTitle.Location = new System.Drawing.Point(17, 14);
            this.Label_EditTitle.Name = "Label_EditTitle";
            this.Label_EditTitle.Size = new System.Drawing.Size(55, 24);
            this.Label_EditTitle.TabIndex = 1;
            this.Label_EditTitle.Text = "Edit.";
            // 
            // Panel_Details
            // 
            this.Panel_Details.BackColor = System.Drawing.Color.White;
            this.Panel_Details.Controls.Add(this.Label_CodesTotal);
            this.Panel_Details.Controls.Add(this.Label_Codes);
            this.Panel_Details.Controls.Add(this.Label_SelectSection);
            this.Panel_Details.Controls.Add(this.ComboBox_SelectSection);
            this.Panel_Details.Controls.Add(this.Label_SelectTemplate);
            this.Panel_Details.Controls.Add(this.Label_SectionsTotal);
            this.Panel_Details.Controls.Add(this.Label_Sections);
            this.Panel_Details.Controls.Add(this.ComboBox_SelectTemplate);
            this.Panel_Details.Controls.Add(this.Label_TemplatesTotal);
            this.Panel_Details.Controls.Add(this.Button_Back);
            this.Panel_Details.Controls.Add(this.Label_Templates);
            this.Panel_Details.Controls.Add(this.Label_DetailsTitle);
            this.Panel_Details.Location = new System.Drawing.Point(747, 153);
            this.Panel_Details.Name = "Panel_Details";
            this.Panel_Details.Size = new System.Drawing.Size(211, 387);
            this.Panel_Details.TabIndex = 49;
            // 
            // Label_CodesTotal
            // 
            this.Label_CodesTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_CodesTotal.ForeColor = System.Drawing.Color.Black;
            this.Label_CodesTotal.Location = new System.Drawing.Point(18, 310);
            this.Label_CodesTotal.Name = "Label_CodesTotal";
            this.Label_CodesTotal.Size = new System.Drawing.Size(177, 14);
            this.Label_CodesTotal.TabIndex = 55;
            this.Label_CodesTotal.Text = "[code_total]";
            this.Label_CodesTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Codes
            // 
            this.Label_Codes.AutoSize = true;
            this.Label_Codes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_Codes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Codes.Location = new System.Drawing.Point(18, 286);
            this.Label_Codes.Name = "Label_Codes";
            this.Label_Codes.Size = new System.Drawing.Size(46, 14);
            this.Label_Codes.TabIndex = 54;
            this.Label_Codes.Text = "Codes:";
            this.Label_Codes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_SectionsTotal
            // 
            this.Label_SectionsTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_SectionsTotal.ForeColor = System.Drawing.Color.Black;
            this.Label_SectionsTotal.Location = new System.Drawing.Point(18, 249);
            this.Label_SectionsTotal.Name = "Label_SectionsTotal";
            this.Label_SectionsTotal.Size = new System.Drawing.Size(177, 14);
            this.Label_SectionsTotal.TabIndex = 53;
            this.Label_SectionsTotal.Text = "[section_total]";
            this.Label_SectionsTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Sections
            // 
            this.Label_Sections.AutoSize = true;
            this.Label_Sections.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_Sections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Sections.Location = new System.Drawing.Point(18, 225);
            this.Label_Sections.Name = "Label_Sections";
            this.Label_Sections.Size = new System.Drawing.Size(58, 14);
            this.Label_Sections.TabIndex = 52;
            this.Label_Sections.Text = "Sections:";
            this.Label_Sections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_TemplatesTotal
            // 
            this.Label_TemplatesTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_TemplatesTotal.ForeColor = System.Drawing.Color.Black;
            this.Label_TemplatesTotal.Location = new System.Drawing.Point(18, 189);
            this.Label_TemplatesTotal.Name = "Label_TemplatesTotal";
            this.Label_TemplatesTotal.Size = new System.Drawing.Size(177, 14);
            this.Label_TemplatesTotal.TabIndex = 51;
            this.Label_TemplatesTotal.Text = "[template_total]";
            this.Label_TemplatesTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Templates
            // 
            this.Label_Templates.AutoSize = true;
            this.Label_Templates.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_Templates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Templates.Location = new System.Drawing.Point(18, 165);
            this.Label_Templates.Name = "Label_Templates";
            this.Label_Templates.Size = new System.Drawing.Size(68, 14);
            this.Label_Templates.TabIndex = 50;
            this.Label_Templates.Text = "Templates:";
            this.Label_Templates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_DetailsTitle
            // 
            this.Label_DetailsTitle.AutoSize = true;
            this.Label_DetailsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_DetailsTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label_DetailsTitle.Location = new System.Drawing.Point(17, 14);
            this.Label_DetailsTitle.Name = "Label_DetailsTitle";
            this.Label_DetailsTitle.Size = new System.Drawing.Size(84, 24);
            this.Label_DetailsTitle.TabIndex = 6;
            this.Label_DetailsTitle.Text = "Details.";
            // 
            // CodeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.Panel_Details);
            this.Controls.Add(this.Panel_Edit);
            this.Controls.Add(this.Panel_CodeList);
            this.Controls.Add(this.Panel_Management);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "CodeViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_CodeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesBindingSource)).EndInit();
            this.Panel_Management.ResumeLayout(false);
            this.Panel_Management.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementLogo)).EndInit();
            this.Panel_CodeList.ResumeLayout(false);
            this.Panel_CodeList.PerformLayout();
            this.Panel_Edit.ResumeLayout(false);
            this.Panel_Edit.PerformLayout();
            this.Panel_Details.ResumeLayout(false);
            this.Panel_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_SelectSection;
        private System.Windows.Forms.DataGridView DataGrid_CodeList;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private System.Windows.Forms.BindingSource codesBindingSource;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Label Label_SelectSection;
        private System.Windows.Forms.ComboBox ComboBox_SelectTemplate;
        private System.Windows.Forms.Label Label_SelectTemplate;
        private System.Windows.Forms.Button Button_EditTemplate;
        private System.Windows.Forms.Panel Panel_Management;
        private System.Windows.Forms.Label Label_ManagementStage3;
        private System.Windows.Forms.PictureBox PictureBox_ManagementStage3;
        private System.Windows.Forms.Label Label_ManagementStage2;
        private System.Windows.Forms.PictureBox PictureBox_ManagementStage2;
        private System.Windows.Forms.Label Label_ManagementStage1;
        private System.Windows.Forms.PictureBox PictureBox_ManagementStage1;
        private System.Windows.Forms.PictureBox PictureBox_ManagementLogo;
        private System.Windows.Forms.Panel Panel_CodeList;
        private System.Windows.Forms.Label Label_CodeListTitle;
        private System.Windows.Forms.Panel Panel_Edit;
        private System.Windows.Forms.Label Label_EditTitle;
        private System.Windows.Forms.Panel Panel_Details;
        private System.Windows.Forms.Label Label_TemplatesTotal;
        private System.Windows.Forms.Label Label_Templates;
        private System.Windows.Forms.Label Label_DetailsTitle;
        private System.Windows.Forms.Label Label_CodesTotal;
        private System.Windows.Forms.Label Label_Codes;
        private System.Windows.Forms.Label Label_SectionsTotal;
        private System.Windows.Forms.Label Label_Sections;
    }
}