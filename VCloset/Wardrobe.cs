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
        List<Top> tops;
        List<Bottom> bottoms;
        List<Shoe> shoes;
        public Wardrobe()
        {
            // set all fields that need set
            topFolder = "..\\..\\..\\Tops\\";
            bottomFolder = "..\\..\\..\\Bottoms\\";
            shoeFolder = "..\\..\\..\\Shoes\\";
            topPath = Directory.GetFiles(topFolder);
            bottomPath = Directory.GetFiles(bottomFolder);
            shoePath = Directory.GetFiles(shoeFolder);
            topIndex = 0;
            bottomIndex = 0;
            shoeIndex = 0;
            maxTop = topPath.Length;
            maxBottom = bottomPath.Length;
            maxShoe = shoePath.Length;
            tops = new List<Top>();
            bottoms = new List<Bottom>();
            shoes = new List<Shoe>();
        }

        // Fields
        private string topFolder { get; set; }
        private string bottomFolder { get; set; }
        private string shoeFolder { get; set; }
        public string[] topPath { get; private set; }
        public string[] bottomPath { get; private set; }
        public string[] shoePath { get; private set; }
        public int topIndex { get; private set; }
        public int bottomIndex { get; private set; }
        public int shoeIndex { get; private set; }
        public int maxTop { get; private set; }
        public int maxBottom { get; private set; }
        public int maxShoe { get; private set; }
        public string currentTopPic { get; set; }
        public string currentBottomPic { get; set; }
        public string currentShoePic { get; set; }

        # region inc methods
        // incrementation methods
        private void incTopIndex()
        {
            topIndex++;
        }

        private void decTopIndex()
        {
            topIndex--;
        }

        private void incBottomIndex()
        {
            bottomIndex++;
        }

        private void decBottomIndex()
        {
            bottomIndex--;
        }
        #endregion

        public List<Bitmap> Populate()
        {
            List<Bitmap> list = new List<Bitmap>();
            if (topPath.Length > 0 && bottomPath.Length > 0 && shoePath.Length > 0)
            {
                System.Drawing.Bitmap topBmp = new System.Drawing.Bitmap(topPath[0]);
                System.Drawing.Bitmap botBmp = new System.Drawing.Bitmap(bottomPath[0]);
                System.Drawing.Bitmap shoesBmp = new System.Drawing.Bitmap(shoePath[0]);
                list.Add(topBmp);
                list.Add(botBmp);
                list.Add(shoesBmp);
            }

            if(topPath.Length > 0)
            {
                foreach (var item in topPath)
                {
                    Top clothingItem = new Top(item);
                    tops.Add(clothingItem);
                }
            }

            if(bottomPath.Length > 0)
            {
                foreach(var item in bottomPath)
                {
                    Bottom clothingItem = new Bottom(item);
                    bottoms.Add(clothingItem);
                }
            }

            if(shoePath.Length > 0)
            {
                foreach(var item in shoePath)
                {
                    Shoe clothingItem = new Shoe(item);
                    shoes.Add(clothingItem);
                }
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

                // create a clothing item object or top object
                Top temp = new Top(imgLoc);
                // add object to list
                tops.Add(temp);
                return imgLoc;
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

                // create a clothing item object or top object
                 Bottom temp = new Bottom(imgLoc);
                // add object to list
                bottoms.Add(temp);

                return imgLoc;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Reading in Photo");
            }
            return "";
        }

        public string AddShoes()
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
                img.Save("..\\..\\..\\Shoes\\" + tokens[tokens.Length-1]);
                shoePath = Directory.GetFiles(shoeFolder);
                maxShoe++;

                // create a clothing item object or top object
                Shoe temp = new Shoe(imgLoc);
                // add object to list
                shoes.Add(temp);

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
            // old way of returning image
            //System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(topPath[topIndex]);
            return tops[topIndex].GetImage();
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
            // old way of returning image
            //System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(topPath[topIndex]);
            return tops[topIndex].GetImage();
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
            // old way of returning image
            //System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(bottomPath[bottomIndex]);
            return bottoms[bottomIndex].GetImage();
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
            // old way of returning image
            //System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(bottomPath[bottomIndex]);
            return bottoms[bottomIndex].GetImage();
        }

        public Bitmap NextShoe()
        {
 
            if (shoeIndex + 1 == maxShoe)
            {
                shoeIndex = 0;
            }
            else
            {
                shoeIndex++;
            }

            return shoes[shoeIndex].GetImage();
        }

        public Bitmap PrevShoe()
        {
            if (shoeIndex - 1 < 0)
            {
                shoeIndex = maxShoe - 1;
            }
            else
            {
                shoeIndex--;
            }

            return shoes[shoeIndex].GetImage();
        }

        public Bitmap GetNewestTop()
        {
            topIndex = maxTop - 1;
            return tops[maxTop - 1].GetImage();
        }

        public Bitmap GetNewestBottom()
        {
            bottomIndex = maxBottom - 1;
            return bottoms[maxBottom - 1].GetImage();
        }

        public Bitmap GetNewestShoe()
        {
            shoeIndex = maxShoe - 1;
            return shoes[maxShoe - 1].GetImage();
        }

        public List<Bitmap> Shuffle()
        {
            List<Bitmap> bmps = new List<Bitmap>();
            Random rnd = new Random();
            if (topPath != null && bottomPath != null && shoePath != null)
            {
                int topRnd = rnd.Next(0, maxTop);
                int botRnd = rnd.Next(0, maxBottom);
                int shoeRnd = rnd.Next(0, maxShoe);
                topIndex = topRnd;
                bottomIndex = botRnd;
                shoeIndex = shoeRnd;
                Bitmap topBmp = tops[topIndex].GetImage();
                Bitmap botBmp = bottoms[bottomIndex].GetImage();
                Bitmap shoeBmp = shoes[shoeIndex].GetImage();
                // old way of returning images
                //System.Drawing.Bitmap topBmp = new System.Drawing.Bitmap(topPath[topRnd]);
                //System.Drawing.Bitmap botBmp = new System.Drawing.Bitmap(bottomPath[botRnd]);
                bmps.Add(topBmp);
                bmps.Add(botBmp);
                bmps.Add(shoeBmp);
            }
            return bmps;
        }
    }
}
