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
            this.userEmail = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.loginButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.dataViewRecruiter = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRecruiter)).BeginInit();
            this.SuspendLayout();
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(84, 35);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(176, 20);
            this.userEmail.TabIndex = 0;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(84, 73);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(176, 20);
            this.userPassword.TabIndex = 1;
            // 
            // loginButt
            // 
            this.loginButt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButt.AutoSize = true;
            this.loginButt.Location = new System.Drawing.Point(122, 111);
            this.loginButt.Name = "loginButt";
            this.loginButt.Size = new System.Drawing.Size(99, 23);
            this.loginButt.TabIndex = 2;
            this.loginButt.Text = "Login";
            this.loginButt.UseVisualStyleBackColor = true;
            this.loginButt.Click += new System.EventHandler(this.loginButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(642, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "HAPPY-TECH";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lbPass);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.userPassword);
            this.groupBox1.Controls.Add(this.userEmail);
            this.groupBox1.Controls.Add(this.loginButt);
            this.groupBox1.Location = new System.Drawing.Point(550, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Page";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(25, 76);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(53, 13);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(25, 38);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email";
            // 
            // dataViewRecruiter
            // 
            this.dataViewRecruiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewRecruiter.Location = new System.Drawing.Point(445, 441);
            this.dataViewRecruiter.Name = "dataViewRecruiter";
            this.dataViewRecruiter.Size = new System.Drawing.Size(444, 110);
            this.dataViewRecruiter.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(895, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(681, 333);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(75, 23);
            this.btRegister.TabIndex = 8;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.registerButt_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Maroon;
            this.error.Location = new System.Drawing.Point(678, 158);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(75, 13);
            this.error.TabIndex = 9;
            this.error.Text = "Error Message";
            this.error.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Not already registered?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.error);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataViewRecruiter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRecruiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Button loginButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataViewRecruiter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label2;
    }
}

