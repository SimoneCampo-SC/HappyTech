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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Label_LoginTitle = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.DataGrid_Users = new System.Windows.Forms.DataGridView();
            this.Button_Debug = new System.Windows.Forms.Button();
            this.Button_Create = new System.Windows.Forms.Button();
            this.Label_Error = new System.Windows.Forms.Label();
            this.Label_FirstTime = new System.Windows.Forms.Label();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.Button_Users = new System.Windows.Forms.Button();
            this.Button_Autofill = new System.Windows.Forms.Button();
            this.Button_PasswordVisibility = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.PictureBox_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Users)).BeginInit();
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
            // DataGrid_Users
            // 
            this.DataGrid_Users.AllowUserToAddRows = false;
            this.DataGrid_Users.AllowUserToDeleteRows = false;
            this.DataGrid_Users.AllowUserToResizeColumns = false;
            this.DataGrid_Users.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid_Users.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid_Users.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid_Users.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Users.ColumnHeadersHeight = 26;
            this.DataGrid_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Users.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Users.GridColor = System.Drawing.Color.White;
            this.DataGrid_Users.Location = new System.Drawing.Point(11, 411);
            this.DataGrid_Users.Name = "DataGrid_Users";
            this.DataGrid_Users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid_Users.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Users.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid_Users.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataGrid_Users.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_Users.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.DataGrid_Users.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGrid_Users.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.DataGrid_Users.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGrid_Users.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Users.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGrid_Users.Size = new System.Drawing.Size(461, 140);
            this.DataGrid_Users.TabIndex = 5;
            this.DataGrid_Users.Visible = false;
            // 
            // Button_Debug
            // 
            this.Button_Debug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Debug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Debug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Debug.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Debug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Debug.Location = new System.Drawing.Point(397, 12);
            this.Button_Debug.Name = "Button_Debug";
            this.Button_Debug.Size = new System.Drawing.Size(75, 23);
            this.Button_Debug.TabIndex = 6;
            this.Button_Debug.Text = "Debug";
            this.Button_Debug.UseVisualStyleBackColor = true;
            this.Button_Debug.Click += new System.EventHandler(this.Button_Debug_Click);
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
            this.Panel_Login.Controls.Add(this.Button_Users);
            this.Panel_Login.Controls.Add(this.Button_Autofill);
            this.Panel_Login.Controls.Add(this.DataGrid_Users);
            this.Panel_Login.Controls.Add(this.Button_PasswordVisibility);
            this.Panel_Login.Controls.Add(this.Button_Login);
            this.Panel_Login.Controls.Add(this.TextBox_Password);
            this.Panel_Login.Controls.Add(this.Button_Debug);
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
            // Button_Users
            // 
            this.Button_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Users.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Users.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Users.Location = new System.Drawing.Point(234, 12);
            this.Button_Users.Name = "Button_Users";
            this.Button_Users.Size = new System.Drawing.Size(75, 23);
            this.Button_Users.TabIndex = 8;
            this.Button_Users.Text = "Users";
            this.Button_Users.UseVisualStyleBackColor = true;
            this.Button_Users.Visible = false;
            this.Button_Users.Click += new System.EventHandler(this.Button_Users_Click);
            // 
            // Button_Autofill
            // 
            this.Button_Autofill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Autofill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Autofill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Autofill.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Autofill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Autofill.Location = new System.Drawing.Point(315, 12);
            this.Button_Autofill.Name = "Button_Autofill";
            this.Button_Autofill.Size = new System.Drawing.Size(75, 23);
            this.Button_Autofill.TabIndex = 7;
            this.Button_Autofill.Text = "Autofill";
            this.Button_Autofill.UseVisualStyleBackColor = true;
            this.Button_Autofill.Visible = false;
            this.Button_Autofill.Click += new System.EventHandler(this.Button_Autofill_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Users)).EndInit();
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
        private System.Windows.Forms.DataGridView DataGrid_Users;
        private System.Windows.Forms.Button Button_Debug;
        private System.Windows.Forms.Button Button_Create;
        private System.Windows.Forms.Label Label_Error;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_FirstTime;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Button Button_PasswordVisibility;
        private System.Windows.Forms.Button Button_Autofill;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
        private System.Windows.Forms.Button Button_Users;
    }
}

