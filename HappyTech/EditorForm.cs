﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class EditorForm : Form
    {
        int currentPosition;
        public EditorForm(int position)
        {
            currentPosition = position;
            InitializeComponent();
            lbApplicants.Text = "Applicant " + (position + 1).ToString() +
                                " out of " + Applicant.applicants.Count;
            lbHeader.Text = Template.templates[position].GetHeader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditorForm f;
            if (currentPosition > 0)
            {
                f = EditorClass.NextForm(0, currentPosition);
                this.Hide();
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditorForm f;
            if (currentPosition < Template.templates.Count - 1)
            {
                f = EditorClass.NextForm(1, currentPosition);
                this.Hide();
                f.Show();
            }
            else if (currentPosition >= Template.templates.Count - 1)
            {
                this.Hide();
                PreviewForm pf = new PreviewForm();
                pf.Show();
            }
        }
    }
}