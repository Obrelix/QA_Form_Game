using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_FormGame
{
    public partial class frm_HiScores : Form
    {
        public static List<Player> HiscoreList = new List<Player>();
        public frm_HiScores()
        {
            InitializeComponent();
        }

        private void frm_HiScores_Load(object sender, EventArgs e)
        {
            ListBoxRefresh();
        }

        private void ListBoxRefresh()
        {
            lstb_HiScores.Items.Clear();
            foreach (var score in HighScoreList.scoreList)
            {
                lstb_HiScores.Items.Add(score);
            }
        }

    }
}
