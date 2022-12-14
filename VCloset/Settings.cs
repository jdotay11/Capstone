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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            homeView.ClearPictureBoxs();

            System.IO.DirectoryInfo tops = new DirectoryInfo("..\\..\\..\\Tops\\");
            System.IO.DirectoryInfo bottoms = new DirectoryInfo("..\\..\\..\\Bottoms\\");
            System.IO.DirectoryInfo shoes = new DirectoryInfo("..\\..\\..\\Shoes\\");
            

            foreach (FileInfo file in tops.GetFiles())
            {
                file.Delete();
            }

            foreach (FileInfo file in bottoms.GetFiles())
            {
                file.Delete();
            }

            foreach (FileInfo file in shoes.GetFiles())
            {
                file.Delete();
            }

            homeView.ResettingObjects();
            this.Hide();
            homeView.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void toggleBtn_Click(object sender, EventArgs e)
        {
            if (toggleHeadwear.Checked)
            {
                this.Hide();
                toggleHeadwear.Checked = false;
                homeView.Show();

            }
            else if (toggleTop.Checked)
            {
                this.Hide();
                toggleTop.Checked = false;
                homeView.Show();
                homeView.ToggleTops();
            }
            else if (toggleBottom.Checked)
            {
                this.Hide();
                toggleBottom.Checked = false;
                homeView.Show();
                homeView.ToggleBottoms();
            }
            else if (toggleShoe.Checked)
            {
                this.Hide();
                toggleShoe.Checked = false;
                homeView.Show();
                homeView.ToggleShoes();
            }
            else
            {
                MessageBox.Show("No Item was selected to be toggled!");
            }
        }

        private void darkModeSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
