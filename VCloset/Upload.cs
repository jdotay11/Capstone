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
    public partial class Upload : Form
    {
        Form1 homeView;
        Settings settingsView;
        FAQ faqView;
        Wardrobe origWardrobe;
        public int ReturnValueIndex { get; set; }
        public string ReturnValuePic { get; set; }
        public Upload(Form1 home, Wardrobe w, Settings settings, FAQ faq)
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
                itemSelect.ClearSelected();
                MessageBox.Show("Please Select Only One Type");
            }
            else
            {
                if (itemSelect.CheckedItems[0].ToString().Equals("Top"))
                {
                    ReturnValueIndex = 1;
                    ReturnValuePic = origWardrobe.AddTop();

                    ClearListBox();
                    homeView.SetPictureBox(ReturnValueIndex);
                    this.Hide();
                    homeView.Show();
                }
                else if (itemSelect.CheckedItems[0].ToString().Equals("Bottom"))
                {
                    ReturnValueIndex = 2;
                    ReturnValuePic = origWardrobe.AddBottom();

                    ClearListBox();
                    homeView.SetPictureBox(ReturnValueIndex);
                    this.Hide();
                    homeView.Show();
                }
                else if (itemSelect.CheckedItems[0].ToString().Equals("Shoes"))
                {
                    ReturnValueIndex = 3;
                    origWardrobe.AddShoes();

                    ClearListBox();
                    homeView.SetPictureBox(ReturnValueIndex);
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

        public void ClearListBox()
        {
            for(int x = 0; x < itemSelect.Items.Count; x++)
            {
                itemSelect.SetItemChecked(x, false);
            }
        }
    }
}
