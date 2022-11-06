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
            
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            UploadView uv = new UploadView(this, wardrobe);
            uv.Show();
            // need to wait for form to close then run if else
            if(uv.ReturnValueIndex == 1)
            {
                topPicture.ImageLocation = uv.ReturnValuePic;
            }
            else if(uv.ReturnValueIndex == 2)
            {
                bottomPicture.ImageLocation = uv.ReturnValuePic;
            }
            else
            {
                MessageBox.Show("Didn't Get an Image to Upload");
            }
            // check if uv has been closed ?
            // display returned string to corresponding picture box
        }
    }
}