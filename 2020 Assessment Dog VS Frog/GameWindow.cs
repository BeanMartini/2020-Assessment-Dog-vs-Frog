using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_Assessment_Dog_VS_Frog
{
    public partial class GameWindow : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called frog 
        Frog[] frog = new Frog[7];
        Dog frame1 = new Dog();

        public GameWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                int y = 10 + (i * 80);
                frog[i] = new Frog(y);
            }

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;

            for (int i = 0; i < 6; i++)
            {
                //call the Frog class's drawFrog method to draw the images
                frog[i].DrawFrog(g);
            }


            frame1.DrawDog(g);

        }
    }
}
