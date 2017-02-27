using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FormGame
{
    public class Phrases
    {
        public string phrase { get; set; }
        public string hint { get; set; }
        public string category { get; set; }
        public int difficulty { get; set; }
        public bool played { get; set; }

        public Phrases()
        {
            phrase = "";
            hint = "";
            category = "";
            difficulty = 1;
        }

        public Phrases(string phr,string hnt, string ctg, int df)
        {
            phrase = phr;
            hint = hnt;
            category = ctg;
            difficulty = df;
            played = false;

        }
    }

}
