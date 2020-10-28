namespace HappyTech
{
    partial class Registration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backBtn);
            this.groupBox1.Controls.Add(this.emailBox);
            this.groupBox1.Controls.Add(this.passBox);
            this.groupBox1.Controls.Add(this.surnameBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.registerButton);
            this.groupBox1.Location = new System.Drawing.Point(238, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 291);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "login info";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(21, 73);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(110, 20);
            this.surnameBox.TabIndex = 1;
            this.surnameBox.Text = "Surname";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(21, 33);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(103, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.Text = "First Name";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.AutoSize = true;
            this.registerButton.Location = new System.Drawing.Point(176, 230);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "start";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(21, 116);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(110, 20);
            this.passBox.TabIndex = 3;
            this.passBox.Text = "Password";
            this.passBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(21, 160);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(110, 20);
            this.emailBox.TabIndex = 4;
            this.emailBox.Text = "Email";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(39, 230);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button backBtn;
    }
}