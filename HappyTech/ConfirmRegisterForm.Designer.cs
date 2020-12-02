namespace HappyTech
{
    partial class ConfirmRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmRegisterForm));
            this.Label_Success = new System.Windows.Forms.Label();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Panel_Account = new System.Windows.Forms.Panel();
            this.Label_AccountTitle = new System.Windows.Forms.Label();
            this.Panel_Account.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Success
            // 
            this.Label_Success.AutoSize = true;
            this.Label_Success.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.Label_Success.Location = new System.Drawing.Point(40, 203);
            this.Label_Success.Name = "Label_Success";
            this.Label_Success.Size = new System.Drawing.Size(251, 19);
            this.Label_Success.TabIndex = 0;
            this.Label_Success.Text = "The account has been created.";
            this.Label_Success.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(174)))), ((int)(((byte)(71)))));
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.Location = new System.Drawing.Point(37, 398);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(246, 26);
            this.Button_Login.TabIndex = 1;
            this.Button_Login.Text = "Success! Log in";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Panel_Account
            // 
            this.Panel_Account.BackColor = System.Drawing.Color.White;
            this.Panel_Account.Controls.Add(this.Button_Login);
            this.Panel_Account.Controls.Add(this.Label_Success);
            this.Panel_Account.Controls.Add(this.Label_AccountTitle);
            this.Panel_Account.ForeColor = System.Drawing.Color.Black;
            this.Panel_Account.Location = new System.Drawing.Point(328, 47);
            this.Panel_Account.Name = "Panel_Account";
            this.Panel_Account.Size = new System.Drawing.Size(327, 469);
            this.Panel_Account.TabIndex = 3;
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
            // ConfirmRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.Panel_Account);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "ConfirmRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.Panel_Account.ResumeLayout(false);
            this.Panel_Account.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Success;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Panel Panel_Account;
        private System.Windows.Forms.Label Label_AccountTitle;
    }
}