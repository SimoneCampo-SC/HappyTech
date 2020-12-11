namespace HappyTech
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Label_LoginTitle = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Button_Create = new System.Windows.Forms.Button();
            this.Label_Error = new System.Windows.Forms.Label();
            this.Label_FirstTime = new System.Windows.Forms.Label();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.Button_PasswordVisibility = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.PictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Login.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Email.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Email.Location = new System.Drawing.Point(90, 192);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(303, 20);
            this.TextBox_Email.TabIndex = 0;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Password.Location = new System.Drawing.Point(90, 257);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(303, 20);
            this.TextBox_Password.TabIndex = 1;
            this.TextBox_Password.UseSystemPasswordChar = true;
            this.TextBox_Password.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            // 
            // Button_Login
            // 
            this.Button_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Login.AutoSize = true;
            this.Button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.FlatAppearance.BorderSize = 0;
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.Location = new System.Drawing.Point(90, 328);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(303, 26);
            this.Button_Login.TabIndex = 3;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Label_LoginTitle
            // 
            this.Label_LoginTitle.AutoSize = true;
            this.Label_LoginTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LoginTitle.ForeColor = System.Drawing.Color.Black;
            this.Label_LoginTitle.Location = new System.Drawing.Point(85, 135);
            this.Label_LoginTitle.Name = "Label_LoginTitle";
            this.Label_LoginTitle.Size = new System.Drawing.Size(110, 24);
            this.Label_LoginTitle.TabIndex = 0;
            this.Label_LoginTitle.Text = "Welcome.";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Password.Location = new System.Drawing.Point(87, 236);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(63, 14);
            this.Label_Password.TabIndex = 0;
            this.Label_Password.Text = "Password";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_Email.Location = new System.Drawing.Point(87, 175);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(36, 14);
            this.Label_Email.TabIndex = 0;
            this.Label_Email.Text = "Email";
            // 
            // Button_Create
            // 
            this.Button_Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Create.FlatAppearance.BorderSize = 0;
            this.Button_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Create.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.Button_Create.Location = new System.Drawing.Point(150, 375);
            this.Button_Create.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(98, 23);
            this.Button_Create.TabIndex = 4;
            this.Button_Create.Text = "Create account";
            this.Button_Create.UseVisualStyleBackColor = true;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Label_Error.Location = new System.Drawing.Point(87, 296);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(89, 14);
            this.Label_Error.TabIndex = 0;
            this.Label_Error.Text = "Error Message";
            this.Label_Error.Visible = false;
            // 
            // Label_FirstTime
            // 
            this.Label_FirstTime.AutoSize = true;
            this.Label_FirstTime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FirstTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.Label_FirstTime.Location = new System.Drawing.Point(87, 379);
            this.Label_FirstTime.Name = "Label_FirstTime";
            this.Label_FirstTime.Size = new System.Drawing.Size(67, 14);
            this.Label_FirstTime.TabIndex = 0;
            this.Label_FirstTime.Text = "First time?";
            // 
            // Panel_Login
            // 
            this.Panel_Login.Controls.Add(this.Button_PasswordVisibility);
            this.Panel_Login.Controls.Add(this.Button_Login);
            this.Panel_Login.Controls.Add(this.TextBox_Password);
            this.Panel_Login.Controls.Add(this.Button_Create);
            this.Panel_Login.Controls.Add(this.Label_FirstTime);
            this.Panel_Login.Controls.Add(this.Label_Password);
            this.Panel_Login.Controls.Add(this.Label_Error);
            this.Panel_Login.Controls.Add(this.Label_Email);
            this.Panel_Login.Controls.Add(this.TextBox_Email);
            this.Panel_Login.Controls.Add(this.Label_LoginTitle);
            this.Panel_Login.Location = new System.Drawing.Point(498, 0);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(485, 565);
            this.Panel_Login.TabIndex = 0;
            // 
            // Button_PasswordVisibility
            // 
            this.Button_PasswordVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_PasswordVisibility.FlatAppearance.BorderSize = 0;
            this.Button_PasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_PasswordVisibility.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_PasswordVisibility.Image = global::HappyTech.Properties.Resources.showPass;
            this.Button_PasswordVisibility.Location = new System.Drawing.Point(364, 258);
            this.Button_PasswordVisibility.Name = "Button_PasswordVisibility";
            this.Button_PasswordVisibility.Size = new System.Drawing.Size(26, 17);
            this.Button_PasswordVisibility.TabIndex = 2;
            this.Button_PasswordVisibility.UseVisualStyleBackColor = false;
            this.Button_PasswordVisibility.Visible = false;
            this.Button_PasswordVisibility.Click += new System.EventHandler(this.Button_PasswordVisibility_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.panelLogo.Controls.Add(this.PictureBox_Logo);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(499, 565);
            this.panelLogo.TabIndex = 0;
            // 
            // PictureBox_Logo
            // 
            this.PictureBox_Logo.Image = global::HappyTech.Properties.Resources.happytech_login;
            this.PictureBox_Logo.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_Logo.Name = "PictureBox_Logo";
            this.PictureBox_Logo.Size = new System.Drawing.Size(499, 565);
            this.PictureBox_Logo.TabIndex = 0;
            this.PictureBox_Logo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.Panel_Login);
            this.Controls.Add(this.panelLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.Panel_Login.ResumeLayout(false);
            this.Panel_Login.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Label Label_LoginTitle;
        private System.Windows.Forms.Button Button_Create;
        private System.Windows.Forms.Label Label_Error;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_FirstTime;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Button Button_PasswordVisibility;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
    }
}

