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
        Random xspeed = new Random();
        Random xpos = new Random();
        Dog frame1 = new Dog();
        int rndmspeed;
        int rndmspeed1;
        int rndmspeed2;
        int rndmspeed3;
        int rndmspeed4;
        int rndmspeed5;
        int rndmspeed6;
        int rndmpos;
        bool left, right, up, down;
        string move;

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
        }


        private void TmrDog_Tick_1(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                frame1.MoveDog(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                frame1.MoveDog(move);
            }
            if (up) // if up arrow key pressed
            {
                move = "up";
                frame1.MoveDog(move);
            }
            if (down) // if down arrow key pressed
            {
                move = "down";
                frame1.MoveDog(move);
            }
        }

        public GameWindow()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            for (int i = 0; i < 7; i++)
            {
                int y = 10 + (i * 130);
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
                frog[0].MoveFrog();

                if (frog[0].x <= -20)
                {
                    // generate a random number from 5 to 20 and put it in rndmspeed
                    rndmspeed = xspeed.Next(1, 12);
                }

                    frog[0].x += rndmspeed;


                //if frog reaches right of the Panel, place it back on the left
                if (frog[0].x > PnlGame.Width)
                {
                    rndmpos = xpos.Next(-800, -20);
                    frog[0].x = rndmpos;
                }

                frog[1].MoveFrog();

                if (frog[1].x <= -20)
                {
                    // generate a random number from 5 to 20 and put it in rndmspeed
                    rndmspeed1 = xspeed.Next(1, 12);
                }

                frog[1].x += rndmspeed1;


                //if frog reaches right of the Panel, place it back on the left
                if (frog[1].x > PnlGame.Width)
                {
                    rndmpos = xpos.Next(-800, -20);
                    frog[1].x = rndmpos;
                }

                frog[2].MoveFrog();

                if (frog[2].x <= -20)
                {
                    // generate a random number from 5 to 20 and put it in rndmspeed
                    rndmspeed2 = xspeed.Next(1, 12);
                }

                frog[2].x += rndmspeed2;


                //if frog reaches right of the Panel, place it back on the left
                if (frog[2].x > PnlGame.Width)
                {
                    rndmpos = xpos.Next(-800, -20);
                    frog[2].x = rndmpos;
                }

                frog[3].MoveFrog();

                if (frog[3].x <= -20)
                {
                    // generate a random number from 5 to 20 and put it in rndmspeed
                    rndmspeed3 = xspeed.Next(1, 12);
                }

                frog[3].x += rndmspeed3;


                //if frog reaches right of the Panel, place it back on the left
                if (frog[3].x > PnlGame.Width)
                {
                    rndmpos = xpos.Next(-800, -20);
                    frog[3].x = rndmpos;
                }

                frog[4].MoveFrog();

                if (frog[4].x <= -20)
                {
                    // generate a random number from 5 to 20 and put it in rndmspeed
                    rndmspeed4 = xspeed.Next(1, 12);
                }

                frog[4].x += rndmspeed4;


                //if frog reaches right of the Panel, place it back on the left
                if (frog[4].x > PnlGame.Width)
                {
                    rndmpos = xpos.Next(-800, -20);
                    frog[4].x = rndmpos;
                }

                frog[5].MoveFrog();

                if (frog[5].x <= -20)
                {
                    // generate a random number from 5 to 20 and put it in rndmspeed
                    rndmspeed5 = xspeed.Next(1, 12);
                }

                frog[5].x += rndmspeed5;


                //if frog reaches right of the Panel, place it back on the left
                if (frog[5].x > PnlGame.Width)
                {
                    rndmpos = xpos.Next(-800, -20);
                    frog[5].x = rndmpos;
                }

                frog[6].MoveFrog();

                if (frog[6].x <= -20)
                {
                    // generate a random number from 5 to 20 and put it in rndmspeed
                    rndmspeed6 = xspeed.Next(1, 12);
                }

                frog[6].x += rndmspeed6;


                //if frog reaches right of the Panel, place it back on the left
                if (frog[6].x > PnlGame.Width)
                {
                    rndmpos = xpos.Next(-800, -20);
                    frog[6].x = rndmpos;
                }
            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

    }
}
