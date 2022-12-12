using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VCloset
{
    // create a seperate list in wardrobe contructor for each article
    // populate each list in the constructor
    public class Wardrobe
    {
        Form1 Home;
        List<Top> tops;
        List<Bottom> bottoms;
        List<Shoe> shoes;
        public Wardrobe(Form1 home)
        {
            // set all fields that need set
            Home = home;
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

        public void Populate()
        {

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

            if(tops.Count > 0)
            {
                Home.PopulateTop(tops[0].GetImage());
                if(tops.Count == 1)
                {
                    Home.DisableTops();
                }
            }
            else
            {
                Home.DisableTops();
            }

            if(bottoms.Count > 0)
            {
                Home.PopulateBottom(bottoms[0].GetImage());
                if (bottoms.Count == 1)
                {
                    Home.DisableBottoms();
                }
            }
            else
            {
                Home.DisableBottoms();
            }

            if(shoes.Count > 0)
            {
                Home.PopulateShoe(shoes[0].GetImage());
                if (shoes.Count == 1)
                {
                    Home.DisableShoes();
                }
            }
            else
            {
                Home.DisableShoes();
            }
        }

        public string AddTop()
        {
            Image img;
            string imgLoc = "";
            try
            {
                // getting file from users file explorer
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "png files(*.png)|*.png| all files(*.*)|*.*";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLoc = ofd.FileName;
                }

                //getting exact file name
                string[] tokens = imgLoc.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                // set image variable
                img = Image.FromFile(imgLoc);
                //save image in local dir with original file name
                img.Save("..\\..\\..\\Tops\\" + tokens[tokens.Length-1]);
                //refresh top dir
                topPath = Directory.GetFiles(topFolder);
                // increment maxtop to reflect number of items
                maxTop++;

                // create a clothing item object or top object
                Top temp = new Top(imgLoc);
                // add object to list
                tops.Add(temp);

                // if our list has more than one element we can now iterate through items
                if(tops.Count > 1)
                {
                    Home.EnableTops();
                }
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

                if (bottoms.Count > 1)
                {
                    Home.EnableBottoms();
                }

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

                if (shoes.Count > 1)
                {
                    Home.EnableShoes();
                }

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
            if(tops.Count == 0)
            {
                return new Bitmap(1,1);
            }
            else
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
        }

        public Bitmap PrevTop()
        {
            if(tops.Count == 0)
            {
                return new Bitmap(1, 1);
            }
            else
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
        }

        public Bitmap NextBottom()
        {
            if(bottoms.Count == 0)
            {
                return new Bitmap(1, 1);
            }
            else
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
        }

        public Bitmap PrevBottom()
        {
            if(bottoms.Count == 0)
            {
                return new Bitmap(1, 1);
            }
            else
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
        }

        public Bitmap NextShoe()
        {
            if(shoes.Count == 0)
            {
                return new Bitmap(1, 1);
            }
            else
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
        }

        public Bitmap PrevShoe()
        {
            if(shoes.Count == 0)
            {
                return new Bitmap(1, 1);
            }
            else
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
                // create random vars using bounds of 0 and max items
                int topRnd = rnd.Next(0, maxTop);
                int botRnd = rnd.Next(0, maxBottom);
                int shoeRnd = rnd.Next(0, maxShoe);

                // set new indices
                topIndex = topRnd;
                bottomIndex = botRnd;
                shoeIndex = shoeRnd;

                // create bitmaps from object lists
                Bitmap topBmp = tops[topIndex].GetImage();
                Bitmap botBmp = bottoms[bottomIndex].GetImage();
                Bitmap shoeBmp = shoes[shoeIndex].GetImage();

                // return these bitmaps to be set in Home
                bmps.Add(topBmp);
                bmps.Add(botBmp);
                bmps.Add(shoeBmp);
            }
            return bmps;
        }

        public void ClearObjectLists()
        {
            tops.Clear();
            bottoms.Clear();
            shoes.Clear();
            topIndex = 0;
            maxTop = 0;
            bottomIndex = 0;
            maxBottom = 0;
            shoeIndex = 0;
            maxShoe = 0;
        }
    }
}
