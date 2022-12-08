using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCloset
{
    public abstract class ClothingItem
    {
        public abstract Bitmap image { get; set; }
        public abstract String fileName { get; set; }


        public abstract Bitmap GetImage();
        public void saveImage()
        {

        }
    }
}
