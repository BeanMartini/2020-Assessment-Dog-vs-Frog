using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2020_Assessment_Dog_VS_Frog
{
    class Frog
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image frogImage;//variable for the frog's image

        public Rectangle frogRec;//variable for a rectangle to place our image in
        //Create a constructor (initialises the values of the fields)

        

        public Frog(int spacing)
        {
            x= -20;
            y = spacing;
            width = 60;
            height = 30;
            //frogImage contains the frog1.gif image
            frogImage = Properties.Resources.frog1;
            frogRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Frog class
        public void DrawFrog(Graphics g)
        {
            frogRec = new Rectangle(x, y, width, height);

            g.DrawImage(frogImage, frogRec);
        }
        public void MoveFrog()
        {
            frogRec.Location = new Point(x, y);
        }


    }
}
