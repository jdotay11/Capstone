﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCloset
{
    public partial class Settings : Form
    {
        Form1 homeView;
        FAQ faqView;
        public Settings(Form1 home, FAQ faq)
        {
            InitializeComponent();
            homeView = home;
            faqView = faq;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeView.Show();
        }

        private void faqBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            faqView.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void colorSelect_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
                homeView.BackColor = colorDialog.Color;
                //faqView.BackColor = colorDialog.Color;
            }
        }
    }
}
