﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCloset
{
    // whenever inheriting from ClothingItem, gives error (: ClothingItem)
    public class Top: ClothingItem
    {
        public override Bitmap image { get; set; }
        public override String fileName { get; set; }

        public Top(String file)
        {
            fileName = file;
            image = new System.Drawing.Bitmap(file);
        }

        public override Bitmap GetImage()
        {
            return image;
        }

    }
}
