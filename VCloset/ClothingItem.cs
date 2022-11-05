using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCloset
{
    public class ClothingItem
    {
        Bitmap image { get; set; }
        String fileName { get; set; }

        public ClothingItem(String file)
        {
            fileName = file;
            image = new System.Drawing.Bitmap(file);
        }

        public void saveImage()
        {
            
        }
    }
}
