using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace _2020_Assessment_Dog_VS_Frog
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameWindow GameWindow2 = new GameWindow(txtEnterName.Text, txtEnterLives.Text);
            Hide();
            GameWindow2.ShowDialog();
        }

        private void txtEnterLives_TextChanged(object sender, EventArgs e)
        {
            string context = txtEnterLives.Text;
            bool isnumber = true;
            //for loop checks for numbers as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsNumber(context[i]))//if current character not a number
                {
                    isnumber = false;//make isnumber false
                    break;//exit the for loop
                }

                if (!string.IsNullOrEmpty(txtEnterLives.Text))
                {
                    btnStart.Enabled = true;
                }
            }
            
            if (string.IsNullOrEmpty(txtEnterLives.Text))
                {
                    btnStart.Enabled = false;
                }

            //if not a number clear the textbox and focus on it to enter lives again
            if (isnumber == false)
            {
                txtEnterLives.Clear();
                txtEnterLives.Focus();
            }
        }

        private void txtEnterLives_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 48)//if enter 0 then clear text box
            {
                e.Handled = true;
                txtEnterLives.Focus();
                txtEnterLives.Clear();
            }
        }

        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {
            string context = txtEnterName.Text;
            bool isletter = true;
            //for loop checks for letters as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))//if current character not a letter
                {
                    isletter = false;//make isletter false
                    break;//exit the for loop
                }
            }

            //if not a letter clear the textbox and focus on it to enter name again
            if (isletter == false)
            {
                txtEnterName.Clear();
                txtEnterName.Focus();
            }
        }
    }
}
