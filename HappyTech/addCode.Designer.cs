namespace HappyTech
{
    partial class addCode
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCode));
            this.sectionBox = new System.Windows.Forms.ComboBox();
            this.sectionLbl = new System.Windows.Forms.Label();
            this.codeShortBx = new System.Windows.Forms.TextBox();
            this.codeShortLb = new System.Windows.Forms.Label();
            this.codeParaBx = new System.Windows.Forms.RichTextBox();
            this.codeParaLb = new System.Windows.Forms.Label();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goToAddTemplate = new System.Windows.Forms.Button();
            this.goToAddSections = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sectionBox
            // 
            this.sectionBox.FormattingEnabled = true;
            this.sectionBox.Location = new System.Drawing.Point(153, 126);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(154, 21);
            this.sectionBox.TabIndex = 0;
            // 
            // sectionLbl
            // 
            this.sectionLbl.AutoSize = true;
            this.sectionLbl.Location = new System.Drawing.Point(150, 96);
            this.sectionLbl.Name = "sectionLbl";
            this.sectionLbl.Size = new System.Drawing.Size(179, 13);
            this.sectionLbl.TabIndex = 1;
            this.sectionLbl.Text = "select section to attach new code to";
            // 
            // codeShortBx
            // 
            this.codeShortBx.Location = new System.Drawing.Point(150, 50);
            this.codeShortBx.Name = "codeShortBx";
            this.codeShortBx.Size = new System.Drawing.Size(100, 20);
            this.codeShortBx.TabIndex = 2;
            // 
            // codeShortLb
            // 
            this.codeShortLb.AutoSize = true;
            this.codeShortLb.Location = new System.Drawing.Point(150, 31);
            this.codeShortLb.Name = "codeShortLb";
            this.codeShortLb.Size = new System.Drawing.Size(103, 13);
            this.codeShortLb.TabIndex = 3;
            this.codeShortLb.Text = "Enter the short code";
            this.codeShortLb.Click += new System.EventHandler(this.label1_Click);
            // 
            // codeParaBx
            // 
            this.codeParaBx.Location = new System.Drawing.Point(49, 182);
            this.codeParaBx.Name = "codeParaBx";
            this.codeParaBx.Size = new System.Drawing.Size(367, 96);
            this.codeParaBx.TabIndex = 4;
            this.codeParaBx.Text = "";
            // 
            // codeParaLb
            // 
            this.codeParaLb.AutoSize = true;
            this.codeParaLb.Location = new System.Drawing.Point(52, 163);
            this.codeParaLb.Name = "codeParaLb";
            this.codeParaLb.Size = new System.Drawing.Size(364, 13);
            this.codeParaLb.TabIndex = 5;
            this.codeParaLb.Text = "Enter the paragraph of feedback to be produced when this code is selected";
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(260, 305);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(90, 39);
            this.buttonSub.TabIndex = 6;
            this.buttonSub.Text = "submit";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(107, 306);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(96, 38);
            this.buttonback.TabIndex = 7;
            this.buttonback.Text = "back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "Section";
            // 
            // goToAddTemplate
            // 
            this.goToAddTemplate.Location = new System.Drawing.Point(648, 115);
            this.goToAddTemplate.Name = "goToAddTemplate";
            this.goToAddTemplate.Size = new System.Drawing.Size(99, 40);
            this.goToAddTemplate.TabIndex = 8;
            this.goToAddTemplate.Text = "Add Templates";
            this.goToAddTemplate.UseVisualStyleBackColor = true;
            this.goToAddTemplate.Click += new System.EventHandler(this.goToAddTemplate_Click);
            // 
            // goToAddSections
            // 
            this.goToAddSections.Location = new System.Drawing.Point(648, 219);
            this.goToAddSections.Name = "goToAddSections";
            this.goToAddSections.Size = new System.Drawing.Size(99, 38);
            this.goToAddSections.TabIndex = 9;
            this.goToAddSections.Text = "Add Sections";
            this.goToAddSections.UseVisualStyleBackColor = true;
            this.goToAddSections.Click += new System.EventHandler(this.goToAddSections_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonback);
            this.groupBox1.Controls.Add(this.buttonSub);
            this.groupBox1.Controls.Add(this.codeParaLb);
            this.groupBox1.Controls.Add(this.codeParaBx);
            this.groupBox1.Controls.Add(this.codeShortLb);
            this.groupBox1.Controls.Add(this.codeShortBx);
            this.groupBox1.Controls.Add(this.sectionLbl);
            this.groupBox1.Controls.Add(this.sectionBox);
            this.groupBox1.Location = new System.Drawing.Point(72, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 396);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // addCode
            // 
            this.BackgroundImage = global::HappyTech.Properties.Resources.happytech_bg_reg;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.goToAddSections);
            this.Controls.Add(this.goToAddTemplate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(998, 602);
            this.MinimumSize = new System.Drawing.Size(998, 602);
            this.Name = "addCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech";
            this.Load += new System.EventHandler(this.addCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox sectionBox;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private System.Windows.Forms.Label sectionLbl;
        private System.Windows.Forms.TextBox codeShortBx;
        private System.Windows.Forms.Label codeShortLb;
        private System.Windows.Forms.RichTextBox codeParaBx;
        private System.Windows.Forms.Label codeParaLb;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button goToAddTemplate;
        private System.Windows.Forms.Button goToAddSections;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}