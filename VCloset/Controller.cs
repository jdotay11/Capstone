using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCloset
{


    // dependency on model
    // do i have to create a model 
    // view has dependency on controller ? try that and see if VS recognizes vars correctly 
    public class Controller
    {
        public Controller(Form1 v, Wardrobe m)
        {
            //View view = v;
            Wardrobe model = m;
        }

        public void NextArticle()
        {
            // index++
           // model.incTopIndex();
           // int curr = model.TopIndex;
           // int max = model.MaxTop
            // get that image and give to view
            //System.Drawing.Bitmap newBmp = new System.Drawing.Bitmap(model.topPath[topIndex]);
            //return newBmp;
        }

        public void BackArticle()
        {
            // get specific article's index
            // index--
            // get that image and give to view
        }

        public void Shuffle()
        {
            // get indices and max length from model ?
            // give bitmap to view to display
        }
    }
}
