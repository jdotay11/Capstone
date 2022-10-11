namespace VCloset
{
    public partial class Form1 : Form
    {
        List<Image> topImgs = new List<Image>();
        List<Image> bottomImgs = new List<Image>();
        public Form1()
        {
            InitializeComponent();
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



        private void bottomBackBtn_Click(object sender, EventArgs e)
        {

        }
    }
}