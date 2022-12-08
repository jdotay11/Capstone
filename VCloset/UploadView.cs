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
    public partial class UploadView : Form
    {
        Form1 homeView;
        Settings settingsView;
        FAQ faqView;
        Wardrobe origWardrobe;
        public int ReturnValueIndex { get; set; }
        public string ReturnValuePic { get; set; }
        public UploadView(Form1 home, Wardrobe w, Settings settings, FAQ faq)
        {
            InitializeComponent();
            homeView = home;
            faqView = faq;
            settingsView = settings;
            origWardrobe = w;
            homeView.Hide();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if(itemSelect.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please Select One Type");
            }
            else if(itemSelect.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please Select Only One Type");
            }
            else
            {
                if (itemSelect.CheckedItems[0].ToString().Equals("Top"))
                {
                    ReturnValueIndex = 1;
                    ReturnValuePic = origWardrobe.AddTop();
                    this.Hide();
                    homeView.Show();
                    // display correct top
                }
                else if (itemSelect.CheckedItems[0].ToString().Equals("Bottom"))
                {
                    ReturnValueIndex = 2;
                    ReturnValuePic = origWardrobe.AddBottom();
                    this.Hide();
                    homeView.Show();
                    //display correct bottom
                }
                else if (itemSelect.CheckedItems[0].ToString().Equals("Shoes"))
                {
                    ReturnValueIndex = 3;
                    origWardrobe.AddShoes();
                    this.Hide();
                    homeView.Show();
                }
                else
                {
                    MessageBox.Show("No Item Selected");
                }
            }
        }

        private void UploadView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            homeView.Show();
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
            this.Hide();
            settingsView.Show();
        }
    }
}
