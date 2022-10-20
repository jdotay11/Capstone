namespace VCloset
{
    public partial class Form1 : Form
    {
        int topsIndex = 0;
        string[] topsPath = new string[];
        public Form1()
        {
            InitializeComponent();
            string topsFolder = "C:\\Users\\jaybr\\source\\repos\\Capstone\\VCloset\\Tops\\";
            topsPaths = Directory.GetFiles(topsFolder);
            int maxTops = topsPaths.Length;
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
                topPicture.ImageLocation = imageLocation;
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
            topsIndex++;
            System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(topsPath[topsIndex]);
        }

        private void topBackBtn_Click(object sender, EventArgs e)
        {
            // get last file
            // draw the file as bitmap
            topsIndex--;
            System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(topsPath[topsIndex]);
        }

        private void bottomNextBtn_Click(object sender, EventArgs e)
        {

        }

        private void bottomBackBtn_Click(object sender, EventArgs e)
        {

        }
    }
}