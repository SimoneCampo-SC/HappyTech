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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPassVis = new System.Windows.Forms.Button();
            this.lbHaveAcc = new System.Windows.Forms.Label();
            this.lbCreate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 563);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnPassVis);
            this.panel2.Controls.Add(this.lbHaveAcc);
            this.panel2.Controls.Add(this.lbCreate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.errorMessage);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nameBox);
            this.panel2.Controls.Add(this.surnameBox);
            this.panel2.Controls.Add(this.emailBox);
            this.panel2.Controls.Add(this.passBox);
            this.panel2.Controls.Add(this.registerButton);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(327, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 469);
            this.panel2.TabIndex = 0;
            // 
            // btnPassVis
            // 
            this.btnPassVis.FlatAppearance.BorderSize = 0;
            this.btnPassVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassVis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassVis.Image = global::HappyTech.Properties.Resources.showPass;
            this.btnPassVis.Location = new System.Drawing.Point(254, 320);
            this.btnPassVis.Name = "btnPassVis";
            this.btnPassVis.Size = new System.Drawing.Size(26, 17);
            this.btnPassVis.TabIndex = 4;
            this.btnPassVis.UseVisualStyleBackColor = false;
            this.btnPassVis.Click += new System.EventHandler(this.btnPassVis_Click);
            // 
            // lbHaveAcc
            // 
            this.lbHaveAcc.AutoSize = true;
            this.lbHaveAcc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHaveAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.lbHaveAcc.Location = new System.Drawing.Point(59, 438);
            this.lbHaveAcc.Name = "lbHaveAcc";
            this.lbHaveAcc.Size = new System.Drawing.Size(147, 14);
            this.lbHaveAcc.TabIndex = 0;
            this.lbHaveAcc.Text = "Already have an account?";
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreate.ForeColor = System.Drawing.Color.Black;
            this.lbCreate.Location = new System.Drawing.Point(33, 35);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(170, 24);
            this.lbCreate.TabIndex = 0;
            this.lbCreate.Text = "Create account.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(34, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(34, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.errorMessage.Location = new System.Drawing.Point(34, 367);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(35, 14);
            this.errorMessage.TabIndex = 0;
            this.errorMessage.Text = "Error";
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.errorMessage.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(34, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Arial", 8.25F);
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.Location = new System.Drawing.Point(37, 112);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(246, 20);
            this.nameBox.TabIndex = 0;
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Arial", 8.25F);
            this.surnameBox.ForeColor = System.Drawing.Color.Black;
            this.surnameBox.Location = new System.Drawing.Point(37, 182);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(246, 20);
            this.surnameBox.TabIndex = 1;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Arial", 8.25F);
            this.emailBox.ForeColor = System.Drawing.Color.Black;
            this.emailBox.Location = new System.Drawing.Point(37, 251);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(246, 20);
            this.emailBox.TabIndex = 2;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Arial", 8.25F);
            this.passBox.ForeColor = System.Drawing.Color.Black;
            this.passBox.Location = new System.Drawing.Point(37, 319);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(246, 20);
            this.passBox.TabIndex = 3;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.AutoSize = true;
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(37, 398);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(246, 26);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Create";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.backBtn.Location = new System.Drawing.Point(206, 434);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(49, 23);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Log in";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.Label lbHaveAcc;
        private System.Windows.Forms.Button btnPassVis;
    }
}