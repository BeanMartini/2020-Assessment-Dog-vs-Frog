using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2020_Assessment_Dog_VS_Frog
{
    public partial class FrmHighScore : Form
    {
        string binPath = Application.StartupPath + @"\highscores.txt";

        List<HighScore> highScore = new List<HighScore>();

        public FrmHighScore(string playerName, string playerElapsed)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore
            lblPlayerName.Text = playerName;
            lblPlayerTime.Text = playerElapsed;

            var reader = new StreamReader(binPath);

            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                // Split into the name and the score.
                var values = line.Split(',');

                highScore.Add(new HighScore(values[0], values[1]));
            }
            reader.Close();
        }

        public void DisplayHighScore()
        {
            foreach (HighScore s in highScore)
            {
                lstBoxName.Items.Add(s.Name);
                lstBoxTime.Items.Add(s.Time);

            }
        }

        private void btnQuit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMainMenu2_Click(object sender, EventArgs e)
        {
            SaveHighScore();
            Start Start2 = new Start();
            Hide();
            Start2.ShowDialog();
        }

        private void FrmHighScore_Load(object sender, EventArgs e)
        {
            string lowest_time = highScore[highScore.Count - 1].Time;

            if (string (lblPlayerTime.Text) > lowest_time)
            {
                lblMessage.Text = "You have made the Top Ten! Well Done!";
                highScore.Add(new HighScore(lblPlayerName.Text, lblPlayerTime.Text));
            }
            else
            {
                lblMessage.Text = "Keep trying to make the top ten!";
            }

            DisplayHighScore();
        }

        public void SaveHighScore()
        {
            StringBuilder builder = new StringBuilder();
            foreach (HighScore score in highScore)
            {
                //{0} is for the Name, {1} is for the Score and {2} is for a new line
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Time, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }

        public void SortHighScore()
        {
            highScore = highScore.OrderByDescending(hs => hs.Time).Take(10).ToList();
        }

    }
}
