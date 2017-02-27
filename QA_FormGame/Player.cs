using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FormGame
{
    public class Player
    {
        public string name { get; set; }
        public int currentScore { get; set; }
        public List<int> recentScores = new List<int>();
        public string password { get; set; }
        private int _hiscore;
        public int hiScore
        {
            get
            {
                //return recentScores.Max(); 
                return _hiscore;
            }
            set
            {
                _hiscore = recentScores.Max();
            }

        }

        public void addScore()
        {
            
            if (recentScores.Count < 15)
            {
                recentScores.Add(currentScore);
                recentScores.Sort();
            }
            else if (recentScores.Count >= 15 && recentScores.Min() < currentScore)
            {
                recentScores.Remove(recentScores.Min());
                recentScores.Add(currentScore);
                recentScores.Sort();
            }
        }

        public Player()
        {

        }
        public Player(string name,string password, int curScore)
        {
            this.name = name;
            currentScore = curScore;
            this.password = password;
            hiScore = recentScores.Max();
            addScore();
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} ",
                    "Name:", name,
                    "     Hiscore:", hiScore);
        }
    }
}
