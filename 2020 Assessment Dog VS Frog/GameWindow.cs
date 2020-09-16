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
        bool w, a, s, d;
        string move;
        int lives, time;

        
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrDog.Enabled = false;
                TmrFrog.Enabled = false;
                TmrTime.Enabled = false;
                MessageBox.Show("Game Over");
                FrmHighScore HighScore2 = new FrmHighScore(lblPlayerName.Text, lblElapsed.Text);
                Hide();
                HighScore2.ShowDialog();
            }

        }
            private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { a = true; }
            if (e.KeyData == Keys.D) { d = true; }
            if (e.KeyData == Keys.W) { w = true; }
            if (e.KeyData == Keys.S) { s = true; }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { a = false; }
            if (e.KeyData == Keys.D) { d = false; }
            if (e.KeyData == Keys.W) { w = false; }
            if (e.KeyData == Keys.S) { s = false; }
        }


        private void TmrDog_Tick_1(object sender, EventArgs e)
        {
            if (d) // if right arrow key pressed
            {
                move = "right";
                frame1.MoveDog(move);
            }
            if (a) // if left arrow key pressed
            {
                move = "left";
                frame1.MoveDog(move);
            }
            if (w) // if up arrow key pressed
            {
                move = "up";
                frame1.MoveDog(move);
            }
            if (s) // if down arrow key pressed
            {
                move = "down";
                frame1.MoveDog(move);
            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time += 1;
            lblElapsed.Text = time.ToString("000");
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            lives = int.Parse(lblPlayerLives.Text);// pass lives in label to lives variable
            time = int.Parse(lblElapsed.Text);// pass lives in label to lives variable
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            TmrTime.Enabled = false;
            TmrDog.Enabled = false;
            TmrFrog.Enabled = false;

            btnResume.Visible = true;
            btnMainMenu.Visible = true;
            btnQuit.Visible = true;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            TmrTime.Enabled = true;
            TmrDog.Enabled = true;
            TmrFrog.Enabled = true;

            btnResume.Visible = false;
            btnMainMenu.Visible = false;
            btnQuit.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //stops arrow keys from selecting buttons
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!msg.HWnd.Equals(this.Handle) &&
                (keyData == Keys.Left || keyData == Keys.Right ||
                keyData == Keys.Up || keyData == Keys.Down))
                return true;
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Start Start2 = new Start();
            Hide();
            Start2.ShowDialog();
        }

        private void lblElapsed_Click(object sender, EventArgs e)
        {

        }

        public GameWindow(string PlayerName, string PlayerLives)
        {
            InitializeComponent();

            // get name and score from start form and show in lblPlayerName and lblPlayerLives
            lblPlayerName.Text = PlayerName;
            lblPlayerLives.Text = PlayerLives;

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

                    if (time > 20)
                    {
                        rndmspeed = xspeed.Next(5, 16);
                    }
                    if (time > 30)
                    {
                        rndmspeed = xspeed.Next(10, 21);
                    }
                    if (time > 50)
                    {
                        rndmspeed = xspeed.Next(15, 26);
                    }
                    if (time > 60)
                    {
                        rndmspeed = xspeed.Next(20, 31);
                    }
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

                    if (time > 20)
                    {
                        rndmspeed1 = xspeed.Next(5, 16);
                    }
                    if (time > 30)
                    {
                        rndmspeed1 = xspeed.Next(10, 21);
                    }
                    if (time > 50)
                    {
                        rndmspeed1 = xspeed.Next(15, 26);
                    }
                    if (time > 60)
                    {
                        rndmspeed1 = xspeed.Next(20, 31);
                    }
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

                    if (time > 20)
                    {
                        rndmspeed2 = xspeed.Next(5, 16);
                    }
                    if (time > 30)
                    {
                        rndmspeed2 = xspeed.Next(10, 21);
                    }
                    if (time > 50)
                    {
                        rndmspeed2 = xspeed.Next(15, 26);
                    }
                    if (time > 60)
                    {
                        rndmspeed2 = xspeed.Next(20, 31);
                    }
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

                    if (time > 20)
                    {
                        rndmspeed3 = xspeed.Next(5, 16);
                    }
                    if (time > 30)
                    {
                        rndmspeed3 = xspeed.Next(10, 21);
                    }
                    if (time > 50)
                    {
                        rndmspeed3 = xspeed.Next(15, 26);
                    }
                    if (time > 60)
                    {
                        rndmspeed3 = xspeed.Next(20, 31);
                    }
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

                    if (time > 20)
                    {
                        rndmspeed4 = xspeed.Next(5, 16);
                    }
                    if (time > 30)
                    {
                        rndmspeed4 = xspeed.Next(10, 21);
                    }
                    if (time > 50)
                    {
                        rndmspeed4 = xspeed.Next(15, 26);
                    }
                    if (time > 60)
                    {
                        rndmspeed4 = xspeed.Next(20, 31);
                    }
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

                    if (time > 20)
                    {
                        rndmspeed5 = xspeed.Next(5, 16);
                    }
                    if (time > 30)
                    {
                        rndmspeed5 = xspeed.Next(10, 21);
                    }
                    if (time > 50)
                    {
                        rndmspeed5 = xspeed.Next(15, 26);
                    }
                    if (time > 60)
                    {
                        rndmspeed5 = xspeed.Next(20, 31);
                    }
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

                    if (time > 20)
                    {
                        rndmspeed6 = xspeed.Next(5, 16);
                    }
                    if (time > 30)
                    {
                        rndmspeed6 = xspeed.Next(10, 21);
                    }
                    if (time > 50)
                    {
                        rndmspeed6 = xspeed.Next(15, 26);
                    }
                    if (time > 60)
                    {
                        rndmspeed6 = xspeed.Next(20, 31);
                    }
                }

                frog[6].x += rndmspeed6;


                //if frog reaches right of the Panel, place it back on the left
                if (frog[6].x > PnlGame.Width)
                {
                    rndmpos = xpos.Next(-800, -20);
                    frog[6].x = rndmpos;
                }
            }

            if (frame1.dogRec.IntersectsWith(frog[0].frogRec))
            {
                //reset frog[0] back to left of panel
                frog[0].x = -200; // set x value of frogRec
                lives -= 1;// lose a life
                lblPlayerLives.Text = lives.ToString();// display number of lives
                CheckLives();
            }

            if (frame1.dogRec.IntersectsWith(frog[1].frogRec))
            {
                //reset frog[1] back to left of panel
                frog[1].x = -200; // set x value of frogRec
                lives -= 1;// lose a life
                lblPlayerLives.Text = lives.ToString();// display number of lives
                CheckLives();
            }

            if (frame1.dogRec.IntersectsWith(frog[2].frogRec))
            {
                //reset frog[2] back to left of panel
                frog[2].x = -200; // set x value of frogRec
                lives -= 1;// lose a life
                lblPlayerLives.Text = lives.ToString();// display number of lives
                CheckLives();
            }

            if (frame1.dogRec.IntersectsWith(frog[3].frogRec))
            {
                //reset frog[3] back to left of panel
                frog[3].x = -200; // set x value of frogRec
                lives -= 1;// lose a life
                lblPlayerLives.Text = lives.ToString();// display number of lives
                CheckLives();
            }

            if (frame1.dogRec.IntersectsWith(frog[4].frogRec))
            {
                //reset frog[4] back to left of panel
                frog[4].x = -200; // set x value of frogRec
                lives -= 1;// lose a life
                lblPlayerLives.Text = lives.ToString();// display number of lives
                CheckLives();
            }

            if (frame1.dogRec.IntersectsWith(frog[4].frogRec))
            {
                //reset frog[4] back to left of panel
                frog[4].x = -200; // set x value of frogRec
                lives -= 1;// lose a life
                lblPlayerLives.Text = lives.ToString();// display number of lives
                CheckLives();
            }

            if (frame1.dogRec.IntersectsWith(frog[5].frogRec))
            {
                //reset frog[5] back to left of panel
                frog[5].x = -200; // set x value of frogRec
                lives -= 1;// lose a life
                lblPlayerLives.Text = lives.ToString();// display number of lives
                CheckLives();
            }

            if (frame1.dogRec.IntersectsWith(frog[6].frogRec))
            {
                //reset frog[6] back to left of panel
                frog[6].x = -200; // set x value of frogRec
                lives -= 1;// lose a life
                lblPlayerLives.Text = lives.ToString();// display number of lives
                CheckLives();
            }

            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

    }
}
