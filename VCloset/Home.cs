using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;

namespace VCloset
{
    public partial class Form1 : Form
    {
        Wardrobe wardrobe;
        Upload uploadView;
        Settings settingsView;
        FAQ faqView;

        bool topVisible;
        bool bottomVisible;
        bool shoeVisible;

        public Form1()
        {
            InitializeComponent();
            wardrobe = new Wardrobe(this);
            settingsView = new Settings(this, faqView);
            faqView = new FAQ(this, settingsView);  
            uploadView = new Upload(this, wardrobe, settingsView, faqView);
            faqView = new FAQ(this, settingsView);
            topVisible = true; bottomVisible = true; shoeVisible = true;
            wardrobe.Populate();
            
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            uploadView.Show();
            this.Hide();
            uploadView.ClearListBox();
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

        public void ClearPictureBoxs()
        {
            if(topPicture.Image != null)
            {
                topPicture.Image.Dispose();
            }

            if(bottomPicture.Image != null)
            {
                bottomPicture.Image.Dispose();
            }
            
            if(shoesPicture.Image != null)
            {
                shoesPicture.Image.Dispose();
            }
        }

        public void Populate(Bitmap popTop, Bitmap popBottom, Bitmap popShoe)
        {
            topPicture.Image = popTop;
            bottomPicture.Image = popBottom;
            shoesPicture.Image = popShoe;

        }

        public void PopulateTop(Bitmap popTop)
        {
            topPicture.Image = popTop;
        }

        public void PopulateBottom(Bitmap popBottom)
        {
            bottomPicture.Image = popBottom;
        }

        public void PopulateShoe(Bitmap popShoe)
        {
            shoesPicture.Image = popShoe;
        }

        public void SetPictureBox(int box)
        {
            if(box == 1)
            {
                topPicture.Image = wardrobe.GetNewestTop();
            }
            else if(box == 2)
            {
                bottomPicture.Image = wardrobe.GetNewestBottom();
            }
            else if(box == 3)
            {
                shoesPicture.Image = wardrobe.GetNewestShoe();
            }
        }

        public void EnableTops()
        {
            topNextBtn.Enabled = true;
            topBackBtn.Enabled = true;
        }

        public void DisableTops()
        {
            topNextBtn.Enabled = false;
            topBackBtn.Enabled = false;
        }

        public void EnableBottoms()
        {
            bottomNextBtn.Enabled = true;
            bottomBackBtn.Enabled = true;
        }

        public void DisableBottoms()
        {
            bottomNextBtn.Enabled = false;
            bottomBackBtn.Enabled = false;
        }

        public void EnableShoes()
        {
            shoesNextBtn.Enabled = true;
            shoesBackBtn.Enabled = true;
        }

        public void DisableShoes()
        {
            shoesNextBtn.Enabled = false;
            shoesBackBtn.Enabled = false;
        }

        public void ToggleTops()
        {
            if (topVisible)
            {
                topVisible = false;
                topNextBtn.Hide();
                topBackBtn.Hide();
                topPicture.Hide();
            }
            else
            {
                topVisible = true;
                topNextBtn.Show();
                topBackBtn.Show();
                topPicture.Show();
            }
        }

        public void ToggleBottoms()
        {
            if (bottomVisible)
            {
                bottomVisible = false;
                bottomNextBtn.Hide();
                bottomBackBtn.Hide();
                bottomPicture.Hide();
            }
            else
            {
                bottomVisible = true;
                bottomNextBtn.Show();
                bottomBackBtn.Show();
                bottomPicture.Show();
            }
        }

        public void ToggleShoes()
        {
            if (shoeVisible)
            {
                shoeVisible = false;
                shoesNextBtn.Hide();
                shoesBackBtn.Hide();
                shoesPicture.Hide();
            }
            else
            {
                shoeVisible = true;
                shoesNextBtn.Show();
                shoesBackBtn.Show();
                shoesPicture.Show();
            }
        }

        public void ResettingObjects()
        {
            wardrobe.ClearObjectLists();
            var a = new Bitmap(1, 1);
            a.SetPixel(0, 0, Color.White);
            var b = new Bitmap(1, 1);
            b.SetPixel(0, 0, Color.White);
            var c = new Bitmap(1, 1);
            c.SetPixel(0, 0, Color.White);
            topPicture.Image = new Bitmap(a, 1024, 1024);
            bottomPicture.Image = new Bitmap(b, 1024, 1024);
            shoesPicture.Image = new Bitmap(c, 1024, 1024);
            DisableTops(); DisableBottoms(); DisableShoes();
        }
    }
}