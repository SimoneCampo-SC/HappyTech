namespace HappyTech
{
    partial class FeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            this.RichTextBox_Feedback = new System.Windows.Forms.RichTextBox();
            this.RichTextBox_Comments = new System.Windows.Forms.RichTextBox();
            this.Label_TemplateTitle = new System.Windows.Forms.Label();
            this.Label_CodesTitle = new System.Windows.Forms.Label();
            this.Label_CommentsTitle = new System.Windows.Forms.Label();
            this.Label_ListPosition = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ListBox_CodesList = new System.Windows.Forms.CheckedListBox();
            this.Panel_Management = new System.Windows.Forms.Panel();
            this.Label_ManagementStage3 = new System.Windows.Forms.Label();
            this.PictureBox_ManagementStage3 = new System.Windows.Forms.PictureBox();
            this.Label_ManagementStage2 = new System.Windows.Forms.Label();
            this.PictureBox_ManagementStage2 = new System.Windows.Forms.PictureBox();
            this.Label_ManagementStage1 = new System.Windows.Forms.Label();
            this.PictureBox_ManagementStage1 = new System.Windows.Forms.PictureBox();
            this.PictureBox_ManagementLogo = new System.Windows.Forms.PictureBox();
            this.Panel_Codes = new System.Windows.Forms.Panel();
            this.Panel_Template = new System.Windows.Forms.Panel();
            this.Panel_Comments = new System.Windows.Forms.Panel();
            this.Panel_Details = new System.Windows.Forms.Panel();
            this.Label_ApplicantTemplate = new System.Windows.Forms.Label();
            this.Label_Template = new System.Windows.Forms.Label();
            this.Label_ApplicantJob = new System.Windows.Forms.Label();
            this.Label_ApplicantEmail = new System.Windows.Forms.Label();
            this.Label_ApplicantName = new System.Windows.Forms.Label();
            this.Label_RecruiterName = new System.Windows.Forms.Label();
            this.Label_Position = new System.Windows.Forms.Label();
            this.Button_Next = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Label_Applicant = new System.Windows.Forms.Label();
            this.Label_Recruiter = new System.Windows.Forms.Label();
            this.Label_DetailsTitle = new System.Windows.Forms.Label();
            this.Panel_Management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementLogo)).BeginInit();
            this.Panel_Codes.SuspendLayout();
            this.Panel_Template.SuspendLayout();
            this.Panel_Comments.SuspendLayout();
            this.Panel_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBox_Feedback
            // 
            this.RichTextBox_Feedback.BackColor = System.Drawing.Color.White;
            this.RichTextBox_Feedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBox_Feedback.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox_Feedback.Location = new System.Drawing.Point(17, 67);
            this.RichTextBox_Feedback.Name = "RichTextBox_Feedback";
            this.RichTextBox_Feedback.ReadOnly = true;
            this.RichTextBox_Feedback.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBox_Feedback.Size = new System.Drawing.Size(439, 242);
            this.RichTextBox_Feedback.TabIndex = 0;
            this.RichTextBox_Feedback.Text = "";
            // 
            // RichTextBox_Comments
            // 
            this.RichTextBox_Comments.BackColor = System.Drawing.Color.White;
            this.RichTextBox_Comments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBox_Comments.Font = new System.Drawing.Font("Arial", 8.25F);
            this.RichTextBox_Comments.Location = new System.Drawing.Point(17, 65);
            this.RichTextBox_Comments.Name = "RichTextBox_Comments";
            this.RichTextBox_Comments.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBox_Comments.Size = new System.Drawing.Size(439, 100);
            this.RichTextBox_Comments.TabIndex = 0;
            this.RichTextBox_Comments.Text = "";
            // 
            // Label_TemplateTitle
            // 
            this.Label_TemplateTitle.AutoSize = true;
            this.Label_TemplateTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_TemplateTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label_TemplateTitle.Location = new System.Drawing.Point(13, 13);
            this.Label_TemplateTitle.Name = "Label_TemplateTitle";
            this.Label_TemplateTitle.Size = new System.Drawing.Size(107, 24);
            this.Label_TemplateTitle.TabIndex = 6;
            this.Label_TemplateTitle.Text = "Template.";
            // 
            // Label_CodesTitle
            // 
            this.Label_CodesTitle.AutoSize = true;
            this.Label_CodesTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_CodesTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label_CodesTitle.Location = new System.Drawing.Point(14, 13);
            this.Label_CodesTitle.Name = "Label_CodesTitle";
            this.Label_CodesTitle.Size = new System.Drawing.Size(81, 24);
            this.Label_CodesTitle.TabIndex = 7;
            this.Label_CodesTitle.Text = "Codes.";
            // 
            // Label_CommentsTitle
            // 
            this.Label_CommentsTitle.AutoSize = true;
            this.Label_CommentsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_CommentsTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label_CommentsTitle.Location = new System.Drawing.Point(17, 21);
            this.Label_CommentsTitle.Name = "Label_CommentsTitle";
            this.Label_CommentsTitle.Size = new System.Drawing.Size(126, 24);
            this.Label_CommentsTitle.TabIndex = 8;
            this.Label_CommentsTitle.Text = "Comments.";
            // 
            // Label_ListPosition
            // 
            this.Label_ListPosition.AutoSize = true;
            this.Label_ListPosition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ListPosition.ForeColor = System.Drawing.Color.Black;
            this.Label_ListPosition.Location = new System.Drawing.Point(15, 70);
            this.Label_ListPosition.Name = "Label_ListPosition";
            this.Label_ListPosition.Size = new System.Drawing.Size(90, 14);
            this.Label_ListPosition.TabIndex = 9;
            this.Label_ListPosition.Text = "Applicant x of y";
            // 
            // ListBox_CodesList
            // 
            this.ListBox_CodesList.CheckOnClick = true;
            this.ListBox_CodesList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListBox_CodesList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.ListBox_CodesList.ForeColor = System.Drawing.Color.Black;
            this.ListBox_CodesList.FormattingEnabled = true;
            this.ListBox_CodesList.Location = new System.Drawing.Point(18, 67);
            this.ListBox_CodesList.Name = "ListBox_CodesList";
            this.ListBox_CodesList.Size = new System.Drawing.Size(94, 439);
            this.ListBox_CodesList.TabIndex = 0;
            this.ListBox_CodesList.SelectedValueChanged += new System.EventHandler(this.ListBox_CodesList_SelectedValueChanged);
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
            this.Panel_Management.TabIndex = 10;
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
            this.PictureBox_ManagementStage1.Image = global::HappyTech.Properties.Resources.happytech_tick;
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
            // Panel_Codes
            // 
            this.Panel_Codes.BackColor = System.Drawing.Color.White;
            this.Panel_Codes.Controls.Add(this.Label_CodesTitle);
            this.Panel_Codes.Controls.Add(this.ListBox_CodesList);
            this.Panel_Codes.Location = new System.Drawing.Point(115, 12);
            this.Panel_Codes.Name = "Panel_Codes";
            this.Panel_Codes.Size = new System.Drawing.Size(130, 539);
            this.Panel_Codes.TabIndex = 11;
            // 
            // Panel_Template
            // 
            this.Panel_Template.BackColor = System.Drawing.Color.White;
            this.Panel_Template.Controls.Add(this.Label_TemplateTitle);
            this.Panel_Template.Controls.Add(this.RichTextBox_Feedback);
            this.Panel_Template.Location = new System.Drawing.Point(262, 12);
            this.Panel_Template.Name = "Panel_Template";
            this.Panel_Template.Size = new System.Drawing.Size(474, 338);
            this.Panel_Template.TabIndex = 12;
            // 
            // Panel_Comments
            // 
            this.Panel_Comments.BackColor = System.Drawing.Color.White;
            this.Panel_Comments.Controls.Add(this.Label_CommentsTitle);
            this.Panel_Comments.Controls.Add(this.RichTextBox_Comments);
            this.Panel_Comments.Location = new System.Drawing.Point(262, 370);
            this.Panel_Comments.Name = "Panel_Comments";
            this.Panel_Comments.Size = new System.Drawing.Size(474, 181);
            this.Panel_Comments.TabIndex = 13;
            // 
            // Panel_Details
            // 
            this.Panel_Details.BackColor = System.Drawing.Color.White;
            this.Panel_Details.Controls.Add(this.Label_ApplicantTemplate);
            this.Panel_Details.Controls.Add(this.Label_Template);
            this.Panel_Details.Controls.Add(this.Label_ApplicantJob);
            this.Panel_Details.Controls.Add(this.Label_ApplicantEmail);
            this.Panel_Details.Controls.Add(this.Label_ApplicantName);
            this.Panel_Details.Controls.Add(this.Label_RecruiterName);
            this.Panel_Details.Controls.Add(this.Label_ListPosition);
            this.Panel_Details.Controls.Add(this.Label_Position);
            this.Panel_Details.Controls.Add(this.Button_Next);
            this.Panel_Details.Controls.Add(this.Button_Back);
            this.Panel_Details.Controls.Add(this.Label_Email);
            this.Panel_Details.Controls.Add(this.Label_Applicant);
            this.Panel_Details.Controls.Add(this.Label_Recruiter);
            this.Panel_Details.Controls.Add(this.Label_DetailsTitle);
            this.Panel_Details.Location = new System.Drawing.Point(754, 11);
            this.Panel_Details.Name = "Panel_Details";
            this.Panel_Details.Size = new System.Drawing.Size(216, 540);
            this.Panel_Details.TabIndex = 14;
            // 
            // Label_ApplicantTemplate
            // 
            this.Label_ApplicantTemplate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ApplicantTemplate.ForeColor = System.Drawing.Color.Black;
            this.Label_ApplicantTemplate.Location = new System.Drawing.Point(15, 419);
            this.Label_ApplicantTemplate.Name = "Label_ApplicantTemplate";
            this.Label_ApplicantTemplate.Size = new System.Drawing.Size(186, 14);
            this.Label_ApplicantTemplate.TabIndex = 53;
            this.Label_ApplicantTemplate.Text = "[applicant_temp]";
            this.Label_ApplicantTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Template
            // 
            this.Label_Template.AutoSize = true;
            this.Label_Template.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_Template.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Template.Location = new System.Drawing.Point(15, 395);
            this.Label_Template.Name = "Label_Template";
            this.Label_Template.Size = new System.Drawing.Size(61, 14);
            this.Label_Template.TabIndex = 52;
            this.Label_Template.Text = "Template:";
            // 
            // Label_ApplicantJob
            // 
            this.Label_ApplicantJob.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ApplicantJob.ForeColor = System.Drawing.Color.Black;
            this.Label_ApplicantJob.Location = new System.Drawing.Point(15, 349);
            this.Label_ApplicantJob.Name = "Label_ApplicantJob";
            this.Label_ApplicantJob.Size = new System.Drawing.Size(186, 14);
            this.Label_ApplicantJob.TabIndex = 50;
            this.Label_ApplicantJob.Text = "[applicant_job]";
            this.Label_ApplicantJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_ApplicantEmail
            // 
            this.Label_ApplicantEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ApplicantEmail.ForeColor = System.Drawing.Color.Black;
            this.Label_ApplicantEmail.Location = new System.Drawing.Point(15, 277);
            this.Label_ApplicantEmail.Name = "Label_ApplicantEmail";
            this.Label_ApplicantEmail.Size = new System.Drawing.Size(186, 14);
            this.Label_ApplicantEmail.TabIndex = 49;
            this.Label_ApplicantEmail.Text = "[applicant_email]";
            this.Label_ApplicantEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_ApplicantName
            // 
            this.Label_ApplicantName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ApplicantName.ForeColor = System.Drawing.Color.Black;
            this.Label_ApplicantName.Location = new System.Drawing.Point(15, 205);
            this.Label_ApplicantName.Name = "Label_ApplicantName";
            this.Label_ApplicantName.Size = new System.Drawing.Size(186, 14);
            this.Label_ApplicantName.TabIndex = 48;
            this.Label_ApplicantName.Text = "[applicant_name]";
            this.Label_ApplicantName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_RecruiterName
            // 
            this.Label_RecruiterName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_RecruiterName.ForeColor = System.Drawing.Color.Black;
            this.Label_RecruiterName.Location = new System.Drawing.Point(15, 136);
            this.Label_RecruiterName.Name = "Label_RecruiterName";
            this.Label_RecruiterName.Size = new System.Drawing.Size(186, 14);
            this.Label_RecruiterName.TabIndex = 47;
            this.Label_RecruiterName.Text = "[recruiter_name]";
            this.Label_RecruiterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Position
            // 
            this.Label_Position.AutoSize = true;
            this.Label_Position.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_Position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Position.Location = new System.Drawing.Point(15, 325);
            this.Label_Position.Name = "Label_Position";
            this.Label_Position.Size = new System.Drawing.Size(55, 14);
            this.Label_Position.TabIndex = 9;
            this.Label_Position.Text = "Position:";
            // 
            // Button_Next
            // 
            this.Button_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.Button_Next.FlatAppearance.BorderSize = 0;
            this.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Next.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Button_Next.ForeColor = System.Drawing.Color.White;
            this.Button_Next.Image = global::HappyTech.Properties.Resources.happytech_next;
            this.Button_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Next.Location = new System.Drawing.Point(18, 501);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(183, 26);
            this.Button_Next.TabIndex = 2;
            this.Button_Next.Text = "Next";
            this.Button_Next.UseVisualStyleBackColor = false;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.Button_Back.FlatAppearance.BorderSize = 0;
            this.Button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Back.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Button_Back.ForeColor = System.Drawing.Color.White;
            this.Button_Back.Image = global::HappyTech.Properties.Resources.happytech_back;
            this.Button_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Back.Location = new System.Drawing.Point(18, 460);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(183, 26);
            this.Button_Back.TabIndex = 1;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Email.Location = new System.Drawing.Point(15, 253);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(39, 14);
            this.Label_Email.TabIndex = 8;
            this.Label_Email.Text = "Email:";
            // 
            // Label_Applicant
            // 
            this.Label_Applicant.AutoSize = true;
            this.Label_Applicant.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_Applicant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Applicant.Location = new System.Drawing.Point(15, 181);
            this.Label_Applicant.Name = "Label_Applicant";
            this.Label_Applicant.Size = new System.Drawing.Size(61, 14);
            this.Label_Applicant.TabIndex = 7;
            this.Label_Applicant.Text = "Applicant:";
            // 
            // Label_Recruiter
            // 
            this.Label_Recruiter.AutoSize = true;
            this.Label_Recruiter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_Recruiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Recruiter.Location = new System.Drawing.Point(15, 112);
            this.Label_Recruiter.Name = "Label_Recruiter";
            this.Label_Recruiter.Size = new System.Drawing.Size(61, 14);
            this.Label_Recruiter.TabIndex = 6;
            this.Label_Recruiter.Text = "Recruiter:";
            // 
            // Label_DetailsTitle
            // 
            this.Label_DetailsTitle.AutoSize = true;
            this.Label_DetailsTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DetailsTitle.ForeColor = System.Drawing.Color.Black;
            this.Label_DetailsTitle.Location = new System.Drawing.Point(14, 14);
            this.Label_DetailsTitle.Name = "Label_DetailsTitle";
            this.Label_DetailsTitle.Size = new System.Drawing.Size(84, 24);
            this.Label_DetailsTitle.TabIndex = 0;
            this.Label_DetailsTitle.Text = "Details.";
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.Panel_Details);
            this.Controls.Add(this.Panel_Comments);
            this.Controls.Add(this.Panel_Template);
            this.Controls.Add(this.Panel_Codes);
            this.Controls.Add(this.Panel_Management);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "FeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.Panel_Management.ResumeLayout(false);
            this.Panel_Management.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementStage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ManagementLogo)).EndInit();
            this.Panel_Codes.ResumeLayout(false);
            this.Panel_Codes.PerformLayout();
            this.Panel_Template.ResumeLayout(false);
            this.Panel_Template.PerformLayout();
            this.Panel_Comments.ResumeLayout(false);
            this.Panel_Comments.PerformLayout();
            this.Panel_Details.ResumeLayout(false);
            this.Panel_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.RichTextBox RichTextBox_Comments;
        private System.Windows.Forms.Label Label_TemplateTitle;
        private System.Windows.Forms.Label Label_CodesTitle;
        private System.Windows.Forms.Label Label_CommentsTitle;
        private System.Windows.Forms.Label Label_ListPosition;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RichTextBox RichTextBox_Feedback;
        private System.Windows.Forms.CheckedListBox ListBox_CodesList;
        private System.Windows.Forms.Panel Panel_Management;
        private System.Windows.Forms.Label Label_ManagementStage3;
        private System.Windows.Forms.PictureBox PictureBox_ManagementStage3;
        private System.Windows.Forms.Label Label_ManagementStage2;
        private System.Windows.Forms.PictureBox PictureBox_ManagementStage2;
        private System.Windows.Forms.Label Label_ManagementStage1;
        private System.Windows.Forms.PictureBox PictureBox_ManagementStage1;
        private System.Windows.Forms.PictureBox PictureBox_ManagementLogo;
        private System.Windows.Forms.Panel Panel_Codes;
        private System.Windows.Forms.Panel Panel_Template;
        private System.Windows.Forms.Panel Panel_Comments;
        private System.Windows.Forms.Panel Panel_Details;
        private System.Windows.Forms.Label Label_ApplicantTemplate;
        private System.Windows.Forms.Label Label_Template;
        private System.Windows.Forms.Label Label_ApplicantJob;
        private System.Windows.Forms.Label Label_ApplicantEmail;
        private System.Windows.Forms.Label Label_ApplicantName;
        private System.Windows.Forms.Label Label_RecruiterName;
        private System.Windows.Forms.Label Label_Position;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_Applicant;
        private System.Windows.Forms.Label Label_Recruiter;
        private System.Windows.Forms.Label Label_DetailsTitle;
    }
}