using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_Assessment_Dog_VS_Frog
{
    class Dog
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle

        Image[] images = new Image[8];//set space for an array called images of 8 images

        public Rectangle dogRec;//variable for a rectangle to place our image in

        Animation animate;//create an object called animate

        //Create a constructor (initialises the values of the fields)
        public Dog()
        {
            x = 1700;
            y = 360;
            width = 140;
            height = 100;
            for (int i = 1; i <= 7; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\frame" + i.ToString() + ".gif");
            }
            //pass the images array to the Animation class's constructor
            animate = new Animation(images);

            dogRec = new Rectangle(x, y, width, height);
        }

        //methods
        public void DrawDog(Graphics g)
        {
            //instead of just drawing the person we use the GetNextImage() method to animate the person
            g.DrawImage(animate.GetNextImage(), dogRec);
        }
        public void MoveDog(string move)
        {
            dogRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (dogRec.Location.X >= 1750) // is spaceship within 50 of right side
                {

                    x = 1750;
                    dogRec.Location = new Point(x, y);
                }
                else
                {
                    x += 15;
                    dogRec.Location = new Point(x, y);
                }

            }

            if (move == "left")
            {
                if (dogRec.Location.X < 0) // is spaceship within 10 of left side
                {

                    x = 0;
                    dogRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 15;
                    dogRec.Location = new Point(x, y);
                }

            }


            if (move == "up")
            {
                if (dogRec.Location.Y <= 0) // is spaceship within 50 of right side
                {

                    y = 0;
                    dogRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 15;
                    dogRec.Location = new Point(x, y);
                }

            }

            if (move == "down")
            {
                if (dogRec.Location.Y >= 760) // is spaceship within 10 of left side
                {

                    y = 760;
                    dogRec.Location = new Point(x, y);
                }
                else
                {
                    y += 15;
                    dogRec.Location = new Point(x, y);
                }

            }

        }

    }
}
