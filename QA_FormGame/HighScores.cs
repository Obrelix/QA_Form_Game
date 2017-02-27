using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FormGame
{
    public class HighScores
    {
        public string name { get; set; }
        public int score { get; set; }
        public int rank { get; set; }

        public HighScores(string name, int score, int rank)
        {
            this.name = name;
            this.score = score;
            this.rank = rank;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", rank,
                    "   ", name,
                    "   ", score);
        }
    }

    public static class HighScoreList
    {
        public static List<HighScores> scoreList = new List<HighScores>();

        public static int max()
        {
            return scoreList.Max(r => r.score);
        }

        public static int min()
        {
            return scoreList.Min(r => r.score);
        }

        public static void scan(Player player)
        {
            int i = 0;
            foreach (int score in player.recentScores)
            {
                try
                {
                    if(scoreList.Count == 0)
                    {
                        scoreList.Add(new HighScores(player.name, score, i++));
                    }
                    //else if (score > scoreList.Where(r => r.score != null).Min(r => r.score))
                    else if (score > scoreList.Min(r => r.score))
                    {
                        scoreList.Add(new HighScores(player.name, score, i++));
                        scoreList.Sort((s2, s1) => s1.score.CompareTo(s2.score));
                    }
                }
                catch
                {

                }
            }
            i = 0;
            foreach(HighScores score in scoreList)
            {
                score.rank = ++i;
            }
            
        }
    }
}
