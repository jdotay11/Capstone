using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;

namespace VCloset
{
    public partial class Form1 : Form
    {
        Wardrobe wardrobe;

        public Form1()
        {
            InitializeComponent();
            wardrobe = new Wardrobe();
            List<Bitmap> bmps = wardrobe.Populate();
            if(bmps.Count > 0)
            {
                topPicture.Image = bmps[0];
                bottomPicture.Image = bmps[1];
            }
            else
            {
                MessageBox.Show("No Top(s) and Bottom(s) to Display");
            }
        }

        private void topUploadBtn_Click(object sender, EventArgs e)
        {
            string img = wardrobe.AddTop();
            topPicture.ImageLocation = img;
        }

        private void bottomUploadBtn_Click(object sender, EventArgs e)
        {
            string img = wardrobe.AddBottom();
            bottomPicture.ImageLocation = img;
        }


        private void topNextBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = wardrobe.NextTop();
            topPicture.Image = bmp;
        }

        private void topBackBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = wardrobe.PrevTop();
            topPicture.Image = bmp;
        }

        private void bottomNextBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = wardrobe.NextBottom();
            bottomPicture.Image = bmp;
        }

        private void bottomBackBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = wardrobe.PrevBottom();
            bottomPicture.Image = bmp;
        }

        private void shuffleBtn_Click(object sender, EventArgs e)
        {
            List<Bitmap> bmps = wardrobe.Shuffle();
            if (bmps.Count > 0)
            {
                topPicture.Image = bmps[0];
                bottomPicture.Image = bmps[1];
            }
            else
            {
                MessageBox.Show("No Top(s) and Bottom(s) to Shuffle");
            }
        }

        private void homeMenu_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void settingsMenu_Click(object sender, EventArgs e)
        {
            var form = new ItemSelect();
            form.Show();
            //this.Hide();
        }
    }
}