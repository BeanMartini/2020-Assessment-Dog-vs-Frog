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
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        private void btnQuit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMainMenu2_Click(object sender, EventArgs e)
        {
            Start Start2 = new Start();
            Hide();
            Start2.ShowDialog();
        }
    }
}
