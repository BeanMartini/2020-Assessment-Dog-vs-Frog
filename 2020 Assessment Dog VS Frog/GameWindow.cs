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
        Frog frog1 = new Frog(); //create the object, frog
        Dog frame1 = new Dog();

        public GameWindow()
        {
            InitializeComponent();
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Frog class's DrawFrog method to draw the image frog1 
            frog1.DrawFrog(g);

            frame1.DrawDog(g);

        }
    }
}
