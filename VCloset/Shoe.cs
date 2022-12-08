﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCloset
{
    public class Shoe: ClothingItem
    {
        public override Bitmap image { get; set; }
        public override String fileName { get; set; }

        public Shoe(String file)
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