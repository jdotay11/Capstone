using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Imaging;

namespace VCloset
{
    public partial class Form1 : Form
    {
        string topFolder;
        string bottomFolder;
        int topIndex = 0;
        int maxTop;
        int bottomIndex = 0;
        int maxBottom;
        string[] topPath;
        string[] bottomPath;

        public Form1()
        {
            InitializeComponent();
            topFolder = "..\\..\\..\\Tops\\";
            bottomFolder = "..\\..\\..\\Bottoms\\";
            topPath = Directory.GetFiles(topFolder);
            bottomPath = Directory.GetFiles(bottomFolder);
            maxTop = topPath.Length;
            maxBottom = bottomPath.Length;

            if(topPath != null)
            {
                System.Drawing.Bitmap topBmp = new System.Drawing.Bitmap(topPath[0]);
                topPicture.Image = topBmp;
            }
            
            if(bottomPath != null)
            {
                System.Drawing.Bitmap botBmp = new System.Drawing.Bitmap(bottomPath[0]);
                bottomPicture.Image = botBmp;
            }
        }

        private void topUploadBtn_Click(object sender, EventArgs e)
        {
            Image img;
            string imageLocation = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "png files(*.png)|*.png| all files(*.*)|*.*";
                if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = ofd.FileName;
                }

                img = Image.FromFile(imageLocation);
                img.Save("C:\\Users\\jaybr\\source\\repos\\Capstone\\VCloset\\Tops\\");
                //topPicture.ImageLocation = imageLocation;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Reading in Photo");
            }
        }

        private void bottomUploadBtn_Click(object sender, EventArgs e)
        {
            Image img;
            string imageLocation = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "png files(*.png)|*.png| all files(*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = ofd.FileName;
                }

                img = Image.FromFile(imageLocation);
                bottomPicture.ImageLocation = imageLocation;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Reading in Photo");
            }
        }


        private void topNextBtn_Click(object sender, EventArgs e)
        {
            // get next file
            // draw the file as bitmap
            if(topIndex + 1 == maxTop)
            {
                topIndex = 0;
            }
            else
            {
                topIndex++;
            }
            System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(topPath[topIndex]);
            topPicture.Image = newBmp;
        }

        private void topBackBtn_Click(object sender, EventArgs e)
        {
            // get last file
            // draw the file as bitmap
            if(topIndex - 1 < 0)
            {
                topIndex = maxTop - 1;
            }
            else
            {
                topIndex--;
            }
            System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(topPath[topIndex]);
            topPicture.Image = newBmp;
        }

        private void bottomNextBtn_Click(object sender, EventArgs e)
        {
            if (bottomIndex + 1 == maxBottom)
            {
                bottomIndex = 0;
            }
            else
            {
                bottomIndex++;
            }
            System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(bottomPath[bottomIndex]);
            bottomPicture.Image = newBmp;
        }

        private void bottomBackBtn_Click(object sender, EventArgs e)
        {
            if (bottomIndex - 1 < 0)
            {
                bottomIndex = maxBottom - 1;
            }
            else
            {
                bottomIndex--;
            }
            System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(bottomPath[bottomIndex]);
            bottomPicture.Image = newBmp;
        }
    }
}