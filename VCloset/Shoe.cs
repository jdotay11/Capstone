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
            using (var bmpTemp = new Bitmap(file))
            {
                image = new Bitmap(bmpTemp);
            }
        }

        public override Bitmap GetImage()
        {
            return image;
        }
    }
}
