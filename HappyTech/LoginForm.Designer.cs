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
            this.userEmail = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.loginButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.dataViewRecruiter = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btAutofill = new System.Windows.Forms.Button();
            this.btnPassVis = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRecruiter)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // userEmail
            // 
            this.userEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmail.ForeColor = System.Drawing.Color.Black;
            this.userEmail.Location = new System.Drawing.Point(90, 192);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(303, 20);
            this.userEmail.TabIndex = 0;
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.ForeColor = System.Drawing.Color.Black;
            this.userPassword.Location = new System.Drawing.Point(90, 257);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(303, 20);
            this.userPassword.TabIndex = 1;
            this.userPassword.UseSystemPasswordChar = true;
            this.userPassword.TextChanged += new System.EventHandler(this.userPassword_TextChanged);
            // 
            // loginButt
            // 
            this.loginButt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButt.AutoSize = true;
            this.loginButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.loginButt.FlatAppearance.BorderSize = 0;
            this.loginButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButt.ForeColor = System.Drawing.Color.White;
            this.loginButt.Location = new System.Drawing.Point(90, 328);
            this.loginButt.Name = "loginButt";
            this.loginButt.Size = new System.Drawing.Size(303, 26);
            this.loginButt.TabIndex = 3;
            this.loginButt.Text = "Login";
            this.loginButt.UseVisualStyleBackColor = false;
            this.loginButt.Click += new System.EventHandler(this.loginButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(85, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome.";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lbPass.Location = new System.Drawing.Point(87, 236);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(63, 14);
            this.lbPass.TabIndex = 0;
            this.lbPass.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lbEmail.Location = new System.Drawing.Point(87, 175);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 14);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // dataViewRecruiter
            // 
            this.dataViewRecruiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewRecruiter.Location = new System.Drawing.Point(7, 401);
            this.dataViewRecruiter.Name = "dataViewRecruiter";
            this.dataViewRecruiter.Size = new System.Drawing.Size(384, 150);
            this.dataViewRecruiter.TabIndex = 5;
            this.dataViewRecruiter.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(397, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Debug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRegister
            // 
            this.btRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btRegister.Location = new System.Drawing.Point(150, 375);
            this.btRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(98, 23);
            this.btRegister.TabIndex = 4;
            this.btRegister.Text = "Create account";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.registerButt_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.error.Location = new System.Drawing.Point(87, 296);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(89, 14);
            this.error.TabIndex = 0;
            this.error.Text = "Error Message";
            this.error.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(87, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "First time?";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btAutofill);
            this.panelLogin.Controls.Add(this.dataViewRecruiter);
            this.panelLogin.Controls.Add(this.btnPassVis);
            this.panelLogin.Controls.Add(this.loginButt);
            this.panelLogin.Controls.Add(this.userPassword);
            this.panelLogin.Controls.Add(this.button1);
            this.panelLogin.Controls.Add(this.btRegister);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.lbPass);
            this.panelLogin.Controls.Add(this.error);
            this.panelLogin.Controls.Add(this.lbEmail);
            this.panelLogin.Controls.Add(this.userEmail);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(498, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(485, 565);
            this.panelLogin.TabIndex = 0;
            // 
            // btAutofill
            // 
            this.btAutofill.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAutofill.Location = new System.Drawing.Point(397, 499);
            this.btAutofill.Name = "btAutofill";
            this.btAutofill.Size = new System.Drawing.Size(75, 23);
            this.btAutofill.TabIndex = 7;
            this.btAutofill.Text = "Autofill";
            this.btAutofill.UseVisualStyleBackColor = true;
            this.btAutofill.Visible = false;
            this.btAutofill.Click += new System.EventHandler(this.btAutofill_Click);
            // 
            // btnPassVis
            // 
            this.btnPassVis.FlatAppearance.BorderSize = 0;
            this.btnPassVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassVis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassVis.Image = global::HappyTech.Properties.Resources.showPass;
            this.btnPassVis.Location = new System.Drawing.Point(364, 258);
            this.btnPassVis.Name = "btnPassVis";
            this.btnPassVis.Size = new System.Drawing.Size(26, 17);
            this.btnPassVis.TabIndex = 2;
            this.btnPassVis.UseVisualStyleBackColor = false;
            this.btnPassVis.Click += new System.EventHandler(this.btnPassVis_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.panelLogo.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(499, 565);
            this.panelLogo.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRecruiter)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Button loginButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataViewRecruiter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnPassVis;
        private System.Windows.Forms.Button btAutofill;
    }
}

