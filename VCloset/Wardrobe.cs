using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCloset
{
    // create a seperate list in wardrobe contructor for each article
    // populate each list in the constructor
    public class Wardrobe
    {
        List<ClothingItem> tops;
        List<ClothingItem> bottoms;
        public Wardrobe()
        {
            // set all fields that need set
            topFolder = "..\\..\\..\\Tops\\";
            bottomFolder = "..\\..\\..\\Bottoms\\";
            topPath = Directory.GetFiles(topFolder);
            bottomPath = Directory.GetFiles(bottomFolder);
            topIndex = 0;
            bottomIndex = 0;
            maxTop = topPath.Length;
            maxBottom = bottomPath.Length;
        }

        // Fields
        public string topFolder { get; private set; }
        private string bottomFolder { get; set; }
        public string[] topPath { get; private set; }
        public string[] bottomPath { get; private set; }
        public int topIndex { get; private set; }
        public int bottomIndex { get; private set; }
        public int maxTop { get; private set; }
        public int maxBottom { get; private set; }
        public string currentTopPic { get; set; }
        public string currentBottomPic { get; set; }

        # region inc methods
        // incrementation methods
        public void incTopIndex()
        {
            topIndex++;
        }

        public void decTopIndex()
        {
            topIndex--;
        }

        public void incBottomIndex()
        {
            bottomIndex++;
        }

        public void decBottomIndex()
        {
            bottomIndex--;
        }
        #endregion

        public List<Bitmap> Populate()
        {
            List<Bitmap> list = new List<Bitmap>();
            if (topPath != null && bottomPath != null)
            {
                System.Drawing.Bitmap topBmp = new System.Drawing.Bitmap(topPath[0]);
                System.Drawing.Bitmap botBmp = new System.Drawing.Bitmap(bottomPath[0]);
                list.Add(topBmp);
                list.Add(botBmp);
            }
            return list;
        }
        public string AddTop()
        {
            Image img;
            string imgLoc = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "png files(*.png)|*.png| all files(*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLoc = ofd.FileName;
                }
                string[] tokens = imgLoc.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                img = Image.FromFile(imgLoc);
                img.Save("..\\..\\..\\Tops\\" + tokens[tokens.Length-1]);
                topPath = Directory.GetFiles(topFolder);
                maxTop++;
                return imgLoc;
                // create a clothing item object or top object
                // add object to list
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Reading in Photo");
            }
            return "";
        }

        public string AddBottom()
        {
            Image img;
            string imgLoc = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "png files(*.png)|*.png| all files(*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLoc = ofd.FileName;
                }
                string[] tokens = imgLoc.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                img = Image.FromFile(imgLoc);
                img.Save("..\\..\\..\\Bottoms\\" + tokens[tokens.Length-1]);
                bottomPath = Directory.GetFiles(bottomFolder);
                maxBottom++;
                return imgLoc;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Reading in Photo");
            }
            return "";
        }

        public Bitmap NextTop()
        {
            if (topIndex + 1 == maxTop)
            {
                topIndex = 0;
            }
            else
            {
                topIndex++;
            }
            System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(topPath[topIndex]);
            return newBmp;
        }

        public Bitmap PrevTop()
        {
            if (topIndex - 1 < 0)
            {
                topIndex = maxTop - 1;
            }
            else
            {
                topIndex--;
            }
            System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(topPath[topIndex]);
            return newBmp;
        }

        public Bitmap NextBottom()
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
            return newBmp;
        }

        public Bitmap PrevBottom()
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
            return newBmp;
        }

        public List<Bitmap> Shuffle()
        {
            List<Bitmap> bmps = new List<Bitmap>();
            Random rnd = new Random();
            if (topPath != null && bottomPath != null)
            {
                int topRnd = rnd.Next(0, maxTop);
                int botRnd = rnd.Next(0, maxBottom);
                System.Drawing.Bitmap topBmp = new System.Drawing.Bitmap(topPath[topRnd]);
                System.Drawing.Bitmap botBmp = new System.Drawing.Bitmap(bottomPath[botRnd]);
                bmps.Add(topBmp);
                bmps.Add(botBmp);
            }
            return bmps;
        }
    }
}
