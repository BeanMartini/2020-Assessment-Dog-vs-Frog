using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

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

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            for (int i = 0; i < 7; i++)
            {
                int y = 10 + (i * 70);
                frog[i] = new Frog(y);
            }

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;

            for (int i = 0; i < 7; i++)
            {
                //call the Frog class's drawFrog method to draw the images
                frog[i].DrawFrog(g);
            }


            frame1.DrawDog(g);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                frog[i].MoveFrog();

                //if frog reaches right of the Panel, place it back on the left
                if (frog[i].x >= PnlGame.Width)
                {
                    frog[i].x = -20;
                }

            }

            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}
