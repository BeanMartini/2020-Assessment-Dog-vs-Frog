using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_Assessment_Dog_VS_Frog
{
    class Frog
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle

        Image[] images = new Image[6];//set space for an array called images of 4 images

        public Rectangle frogRec;//variable for a rectangle to place our image in
        //Create a constructor (initialises the values of the fields)

        Animation animate;//create an object called animate

        public Frog(int spacing)
        {
            x= -200;
            y = spacing;
            width = 120;
            height = 60;
            for (int i = 1; i <= 5; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\frog" + i.ToString() + ".gif");
            }

            //pass the images array to the Animation class's constructor
            animate = new Animation(images);

            frogRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Frog class
        public void DrawFrog(Graphics g)
        {

            //instead of just drawing the missile we use the GetNextImage() method to animate the missile
            g.DrawImage(animate.GetNextImage(), frogRec);
        }
        public void MoveFrog()
        {
            frogRec.Location = new Point(x, y);
        }


    }
}
