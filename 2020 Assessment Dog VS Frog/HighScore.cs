using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_Assessment_Dog_VS_Frog
{
    class HighScore
    {
        //we create a Constructor with 2 overloads, 1 for the player's name and one for their score
        public HighScore(string name, int time)
        {
            Name = name;
            Time = time;
        }
        //set properties so we can access the name and score
        public string Name { get; set; }

        public int Time { get; set; }

    }
}
