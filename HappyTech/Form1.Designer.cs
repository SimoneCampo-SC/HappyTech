namespace HappyTech
{
    partial class Form1
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataViewRecruiter = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.registerButt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRecruiter)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(21, 33);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(103, 20);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            this.username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(21, 73);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(110, 20);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // loginButt
            // 
            this.loginButt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButt.AutoSize = true;
            this.loginButt.Location = new System.Drawing.Point(35, 111);
            this.loginButt.Name = "loginButt";
            this.loginButt.Size = new System.Drawing.Size(75, 23);
            this.loginButt.TabIndex = 2;
            this.loginButt.Text = "start";
            this.loginButt.UseVisualStyleBackColor = true;
            this.loginButt.Click += new System.EventHandler(this.loginButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HAPPYTECH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.loginButt);
            this.groupBox1.Location = new System.Drawing.Point(294, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "login info";
            // 
            // dataViewRecruiter
            // 
            this.dataViewRecruiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewRecruiter.Location = new System.Drawing.Point(12, 21);
            this.dataViewRecruiter.Name = "dataViewRecruiter";
            this.dataViewRecruiter.Size = new System.Drawing.Size(240, 294);
            this.dataViewRecruiter.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerButt
            // 
            this.registerButt.Location = new System.Drawing.Point(315, 352);
            this.registerButt.Name = "registerButt";
            this.registerButt.Size = new System.Drawing.Size(75, 23);
            this.registerButt.TabIndex = 8;
            this.registerButt.Text = "register";
            this.registerButt.UseVisualStyleBackColor = true;
            this.registerButt.Click += new System.EventHandler(this.registerButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerButt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataViewRecruiter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HappyTech";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewRecruiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataViewRecruiter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button registerButt;
    }
}

