namespace HappyTech
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.Panel_Account = new System.Windows.Forms.Panel();
            this.lbPassReq = new System.Windows.Forms.Label();
            this.lbEmailReq = new System.Windows.Forms.Label();
            this.lbLastNameReq = new System.Windows.Forms.Label();
            this.lbFirstNameReq = new System.Windows.Forms.Label();
            this.Button_PasswordVisibility = new System.Windows.Forms.Button();
            this.Label_HaveAccount = new System.Windows.Forms.Label();
            this.Label_AccountTitle = new System.Windows.Forms.Label();
            this.Label_FirstName = new System.Windows.Forms.Label();
            this.Label_LastName = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Label_Error = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.TextBox_FirstName = new System.Windows.Forms.TextBox();
            this.TextBox_LastName = new System.Windows.Forms.TextBox();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Button_Create = new System.Windows.Forms.Button();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.Panel_Account.SuspendLayout();
            this.Panel_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Account
            // 
            this.Panel_Account.BackColor = System.Drawing.Color.White;
            this.Panel_Account.Controls.Add(this.lbPassReq);
            this.Panel_Account.Controls.Add(this.lbEmailReq);
            this.Panel_Account.Controls.Add(this.lbLastNameReq);
            this.Panel_Account.Controls.Add(this.lbFirstNameReq);
            this.Panel_Account.Controls.Add(this.Button_PasswordVisibility);
            this.Panel_Account.Controls.Add(this.Label_HaveAccount);
            this.Panel_Account.Controls.Add(this.Label_AccountTitle);
            this.Panel_Account.Controls.Add(this.Label_FirstName);
            this.Panel_Account.Controls.Add(this.Label_LastName);
            this.Panel_Account.Controls.Add(this.Label_Email);
            this.Panel_Account.Controls.Add(this.Label_Error);
            this.Panel_Account.Controls.Add(this.Label_Password);
            this.Panel_Account.Controls.Add(this.TextBox_FirstName);
            this.Panel_Account.Controls.Add(this.TextBox_LastName);
            this.Panel_Account.Controls.Add(this.TextBox_Email);
            this.Panel_Account.Controls.Add(this.TextBox_Password);
            this.Panel_Account.Controls.Add(this.Button_Create);
            this.Panel_Account.Controls.Add(this.Button_Login);
            this.Panel_Account.ForeColor = System.Drawing.Color.Black;
            this.Panel_Account.Location = new System.Drawing.Point(327, 47);
            this.Panel_Account.Name = "Panel_Account";
            this.Panel_Account.Size = new System.Drawing.Size(327, 469);
            this.Panel_Account.TabIndex = 0;
            // 
            // lbPassReq
            // 
            this.lbPassReq.AutoSize = true;
            this.lbPassReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbPassReq.Location = new System.Drawing.Point(93, 297);
            this.lbPassReq.Name = "lbPassReq";
            this.lbPassReq.Size = new System.Drawing.Size(11, 14);
            this.lbPassReq.TabIndex = 0;
            this.lbPassReq.Text = "*";
            // 
            // lbEmailReq
            // 
            this.lbEmailReq.AutoSize = true;
            this.lbEmailReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbEmailReq.Location = new System.Drawing.Point(66, 229);
            this.lbEmailReq.Name = "lbEmailReq";
            this.lbEmailReq.Size = new System.Drawing.Size(11, 14);
            this.lbEmailReq.TabIndex = 0;
            this.lbEmailReq.Text = "*";
            // 
            // lbLastNameReq
            // 
            this.lbLastNameReq.AutoSize = true;
            this.lbLastNameReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbLastNameReq.Location = new System.Drawing.Point(95, 160);
            this.lbLastNameReq.Name = "lbLastNameReq";
            this.lbLastNameReq.Size = new System.Drawing.Size(11, 14);
            this.lbLastNameReq.TabIndex = 0;
            this.lbLastNameReq.Text = "*";
            // 
            // lbFirstNameReq
            // 
            this.lbFirstNameReq.AutoSize = true;
            this.lbFirstNameReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbFirstNameReq.Location = new System.Drawing.Point(96, 90);
            this.lbFirstNameReq.Name = "lbFirstNameReq";
            this.lbFirstNameReq.Size = new System.Drawing.Size(11, 14);
            this.lbFirstNameReq.TabIndex = 0;
            this.lbFirstNameReq.Text = "*";
            // 
            // Button_PasswordVisibility
            // 
            this.Button_PasswordVisibility.FlatAppearance.BorderSize = 0;
            this.Button_PasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_PasswordVisibility.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_PasswordVisibility.Image = global::HappyTech.Properties.Resources.showPass;
            this.Button_PasswordVisibility.Location = new System.Drawing.Point(254, 320);
            this.Button_PasswordVisibility.Name = "Button_PasswordVisibility";
            this.Button_PasswordVisibility.Size = new System.Drawing.Size(26, 17);
            this.Button_PasswordVisibility.TabIndex = 4;
            this.Button_PasswordVisibility.UseVisualStyleBackColor = false;
            this.Button_PasswordVisibility.Visible = false;
            this.Button_PasswordVisibility.Click += new System.EventHandler(this.Button_PasswordVisibility_Click);
            // 
            // Label_HaveAccount
            // 
            this.Label_HaveAccount.AutoSize = true;
            this.Label_HaveAccount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_HaveAccount.Location = new System.Drawing.Point(59, 438);
            this.Label_HaveAccount.Name = "Label_HaveAccount";
            this.Label_HaveAccount.Size = new System.Drawing.Size(147, 14);
            this.Label_HaveAccount.TabIndex = 0;
            this.Label_HaveAccount.Text = "Already have an account?";
            // 
            // Label_AccountTitle
            // 
            this.Label_AccountTitle.AutoSize = true;
            this.Label_AccountTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AccountTitle.ForeColor = System.Drawing.Color.Black;
            this.Label_AccountTitle.Location = new System.Drawing.Point(33, 35);
            this.Label_AccountTitle.Name = "Label_AccountTitle";
            this.Label_AccountTitle.Size = new System.Drawing.Size(170, 24);
            this.Label_AccountTitle.TabIndex = 0;
            this.Label_AccountTitle.Text = "Create account.";
            // 
            // Label_FirstName
            // 
            this.Label_FirstName.AutoSize = true;
            this.Label_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_FirstName.Location = new System.Drawing.Point(34, 90);
            this.Label_FirstName.Name = "Label_FirstName";
            this.Label_FirstName.Size = new System.Drawing.Size(66, 14);
            this.Label_FirstName.TabIndex = 0;
            this.Label_FirstName.Text = "First Name";
            // 
            // Label_LastName
            // 
            this.Label_LastName.AutoSize = true;
            this.Label_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_LastName.Location = new System.Drawing.Point(34, 160);
            this.Label_LastName.Name = "Label_LastName";
            this.Label_LastName.Size = new System.Drawing.Size(65, 14);
            this.Label_LastName.TabIndex = 0;
            this.Label_LastName.Text = "Last Name";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Email.Location = new System.Drawing.Point(34, 229);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(36, 14);
            this.Label_Email.TabIndex = 0;
            this.Label_Email.Text = "Email";
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Label_Error.Location = new System.Drawing.Point(34, 367);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(35, 14);
            this.Label_Error.TabIndex = 0;
            this.Label_Error.Text = "Error";
            this.Label_Error.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Label_Error.Visible = false;
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Password.Location = new System.Drawing.Point(34, 297);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(63, 14);
            this.Label_Password.TabIndex = 0;
            this.Label_Password.Text = "Password";
            // 
            // TextBox_FirstName
            // 
            this.TextBox_FirstName.Font = new System.Drawing.Font("Arial", 8.25F);
            this.TextBox_FirstName.ForeColor = System.Drawing.Color.Black;
            this.TextBox_FirstName.Location = new System.Drawing.Point(37, 112);
            this.TextBox_FirstName.Name = "TextBox_FirstName";
            this.TextBox_FirstName.Size = new System.Drawing.Size(246, 20);
            this.TextBox_FirstName.TabIndex = 0;
            this.TextBox_FirstName.TextChanged += new System.EventHandler(this.TextBox_FirstName_TextChanged);
            // 
            // TextBox_LastName
            // 
            this.TextBox_LastName.Font = new System.Drawing.Font("Arial", 8.25F);
            this.TextBox_LastName.ForeColor = System.Drawing.Color.Black;
            this.TextBox_LastName.Location = new System.Drawing.Point(37, 182);
            this.TextBox_LastName.Name = "TextBox_LastName";
            this.TextBox_LastName.Size = new System.Drawing.Size(246, 20);
            this.TextBox_LastName.TabIndex = 1;
            this.TextBox_LastName.TextChanged += new System.EventHandler(this.TextBox_LastName_TextChanged);
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Font = new System.Drawing.Font("Arial", 8.25F);
            this.TextBox_Email.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Email.Location = new System.Drawing.Point(37, 251);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(246, 20);
            this.TextBox_Email.TabIndex = 2;
            this.TextBox_Email.TextChanged += new System.EventHandler(this.TextBox_Email_TextChanged);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Font = new System.Drawing.Font("Arial", 8.25F);
            this.TextBox_Password.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Password.Location = new System.Drawing.Point(37, 319);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(246, 20);
            this.TextBox_Password.TabIndex = 3;
            this.TextBox_Password.UseSystemPasswordChar = true;
            this.TextBox_Password.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            // 
            // Button_Create
            // 
            this.Button_Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Create.AutoSize = true;
            this.Button_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.Button_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Create.FlatAppearance.BorderSize = 0;
            this.Button_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Create.ForeColor = System.Drawing.Color.White;
            this.Button_Create.Location = new System.Drawing.Point(37, 398);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(246, 26);
            this.Button_Create.TabIndex = 5;
            this.Button_Create.Text = "Create";
            this.Button_Create.UseVisualStyleBackColor = false;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // Button_Login
            // 
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.FlatAppearance.BorderSize = 0;
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.Button_Login.Location = new System.Drawing.Point(206, 434);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(49, 23);
            this.Button_Login.TabIndex = 6;
            this.Button_Login.Text = "Log in";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.Panel_Background.Controls.Add(this.Panel_Account);
            this.Panel_Background.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Background.Location = new System.Drawing.Point(0, 0);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(982, 563);
            this.Panel_Background.TabIndex = 0;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.Panel_Background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.Panel_Account.ResumeLayout(false);
            this.Panel_Account.PerformLayout();
            this.Panel_Background.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Account;
        private System.Windows.Forms.Label lbPassReq;
        private System.Windows.Forms.Label lbEmailReq;
        private System.Windows.Forms.Label lbLastNameReq;
        private System.Windows.Forms.Label lbFirstNameReq;
        private System.Windows.Forms.Button Button_PasswordVisibility;
        private System.Windows.Forms.Label Label_HaveAccount;
        private System.Windows.Forms.Label Label_AccountTitle;
        private System.Windows.Forms.Label Label_FirstName;
        private System.Windows.Forms.Label Label_LastName;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_Error;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox TextBox_FirstName;
        private System.Windows.Forms.TextBox TextBox_LastName;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Button Button_Create;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Panel Panel_Background;
    }
}