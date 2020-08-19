using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2020_Assessment_Dog_VS_Frog
{
    class Dog
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image dog;//variable for the dog's image

        public Rectangle dogRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Dog()
        {
            x = 1700;
            y = 360;
            width = 140;
            height = 100;
            dog = Properties.Resources.frame1;
            dogRec = new Rectangle(x, y, width, height);
        }

        //methods
        public void DrawDog(Graphics g)
        {

            g.DrawImage(dog, dogRec);
        }

        public void moveDog(int mouseX, int mouseY)
        {
            dogRec.X = mouseX - (dogRec.Width / 2);
            dogRec.Y = mouseY - (dogRec.Height / 2);
        }

    }
}
