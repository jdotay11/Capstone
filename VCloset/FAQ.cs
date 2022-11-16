using System;
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
    public partial class FAQ : Form
    {
        Form1 homeView;
        Settings settingsView;
        public FAQ(Form1 home, Settings settings)
        {
            InitializeComponent();
            homeView = home;
            settingsView = settings;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeView.Show();
        }

        private void faqBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            settingsView.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.microsoft.com");
        }
    }
}
