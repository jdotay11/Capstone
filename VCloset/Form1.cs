using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;

namespace VCloset
{
    public partial class Form1 : Form
    {
        Wardrobe wardrobe;
        UploadView uploadView;
        Settings settingsView;
        FAQ faqView;
        public Form1()
        {
            InitializeComponent();
            wardrobe = new Wardrobe();
            settingsView = new Settings(this, faqView);
            faqView = new FAQ(this, settingsView);  
            uploadView = new UploadView(this, wardrobe, settingsView, faqView);
            faqView = new FAQ(this, settingsView);

            List<Bitmap> bmps = wardrobe.Populate();
            if(bmps.Count > 0)
            {
                topPicture.Image = bmps[0];
                bottomPicture.Image = bmps[1];
                shoesPicture.Image = bmps[2];
            }
            else
            {
                MessageBox.Show("No Top(s) and/or Bottom(s) to Display");
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            uploadView.Show();
            this.Hide();
            // need to wait for form to close then run if else
            if (uploadView.ReturnValueIndex == 1)
            {
                topPicture.ImageLocation = uploadView.ReturnValuePic;
            }
            else if (uploadView.ReturnValueIndex == 2)
            {
                bottomPicture.ImageLocation = uploadView.ReturnValuePic;
            }
            else
            {
                //MessageBox.Show("Didn't Get an Image to Upload");
            }
            // check if uv has been closed ?
            // display returned string to corresponding picture box
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

        private void shoesNextBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = wardrobe.NextShoe();
            shoesPicture.Image = bmp;
        }

        private void shoesBackBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = wardrobe.PrevShoe();
            shoesPicture.Image = bmp;
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
                shoesPicture.Image = bmps[2];
            }
            else
            {
                MessageBox.Show("No Top(s) and Bottom(s) to Shuffle");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void faqBtn_Click(object sender, EventArgs e)
        {
            settingsView = new Settings(this, faqView);
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