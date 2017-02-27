using Newtonsoft.Json;
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
    public partial class frm_MainGame : Form
    {
        string phrasesJsonPath = Application.StartupPath + "\\Phrases.json";
        public static bool gFormMainClosed;
        public static List<Phrases> phrasesList = new List<Phrases>();
        public static int phraseIndex;
        int phraseCount;
        List<Label> labelList = new List<Label>();
        string word = string.Empty;
        int clockMax = 15;
        int clockcounter = 15;
        int round = 1;
        int totalLifes = 3;
        static bool click = false;
        bool[] indexesfound = new bool[50];

        public frm_MainGame()
        {
            InitializeComponent();
        }

        private void loadPhrases(string jsonPath)
        {
            try
            {
                phrasesList.Clear();
                phrasesList = JsonConvert.DeserializeObject<List < Phrases >> (System.IO.File.ReadAllText(jsonPath));
                phraseCount = phrasesList.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //ListBoxRefresh();
        }

        private void currentPhrase(int round)
        {
            
                for(int i = 0; i < phraseCount; i++)
                {
                    if(phrasesList[i].difficulty == round && !phrasesList[i].played)
                    {
                    phraseIndex = i;
                    break;
                    }
                }
            lblCreate(phrasesList[phraseIndex]);

        }

        private void roundCheck()
        {

            if (pgrbrLife.Value == 0 && totalLifes > 0)
            {
                lblDestroy();
                totalLifes--;
                round++;
                currentPhrase(round);
                pgrbrLife.Value = 100;
            }
            else if (pgrbrLife.Value == 0 && totalLifes == 0)
            {
                lblMessage.Text = "You have lost all of your lifes! Game Over! Try with a new game!";
            }


        }

        private void tmrCounter_Tick(object sender, EventArgs e)
        {
            //roundCheck();
            insertCheck();
            if (clockcounter >= 0)
            {
                lblMessage.Text = "";
                lblTime.Text = "" + clockcounter+ "\"";
                if (clockcounter > clockMax/3)
                {
                    lblTime.BackColor = Color.Green;
                }

                else
                {
                    lblTime.BackColor = Color.Red;
                }
                clockcounter--;

            }
            else
            {
                lblMessage.Text = "Your time is over you need to be faster next time !";
                pgrbrLife.Value -= 25;
                clockcounter = clockMax;
            }

        }

        private void frm_MainGame_Load(object sender, EventArgs e)
        {

            lblHighScore.Text = "High Score :" + frm_StartGame.PlayerList[frm_StartGame.PlayerIndex].hiScore;
            lblPlayerName.Text = "Player Name: " + frm_StartGame.PlayerList[frm_StartGame.PlayerIndex].name;
            this.BackColor = Color.Wheat;
            pnlStats.BackColor = Color.LightSeaGreen;
            pnlPlayer.BackColor = Color.Coral;
            pnlWord.BackColor = Color.DarkKhaki;
            frm_StartGame.PlayerList[frm_StartGame.PlayerIndex].currentScore = 0;
            this.KeyPreview = true;
            loadPhrases(phrasesJsonPath);
            currentPhrase(round);
            tmrCounter.Interval = 1000;
            tmrCounter.Start();
            pgrbrLife.Value = 100;
            pgrbrLife.BackColor = Color.Green;
            //lblLife.ForeColor = Color.Green;
            
        }

        private void lblCreate(Phrases word)
        {
            for (int i = 0; i < 50; i++)
            {
                indexesfound[i] = false;
            }
            Label lblCategory = new Label();
            lblCategory.AutoSize = true;
            //lblCategory.Size = new System.Drawing.Size(20, 20);
            lblCategory.Location = new Point(20, 10);
            lblCategory.TabIndex = 0;
            lblCategory.Name = "lblCategory";
            lblCategory.TextAlign = ContentAlignment.MiddleCenter;
            lblCategory.Font = new Font("Arial", 12, FontStyle.Bold);
            lblCategory.Text = "Category: " + word.category;
            pnlWord.Controls.Add(lblCategory);
            Label lblHint = new Label();
            lblHint.AutoSize = false;
            lblHint.Size = new System.Drawing.Size(500,20);
            lblHint.TextAlign = ContentAlignment.MiddleRight;
            lblHint.TabIndex = 0;
            lblHint.Name = "lblHint";
            lblHint.TextAlign = ContentAlignment.MiddleCenter;
            lblHint.Font = new Font("Arial", 12, FontStyle.Bold);
            lblHint.Text = "Hint: " + word.hint;
            lblHint.Location = new Point(pnlWord.ClientRectangle.Width - lblHint.Width , 10);
            lblHint.Visible = false;
            pnlWord.Controls.Add(lblHint);
            
            int lblLocationX = 20;
            int lblLocationY = 55;
            for (int i = 0; i < word.phrase.Length; i++)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Size = new System.Drawing.Size(13, 13);
                lbl.Location = new Point(lblLocationX, lblLocationY);
                lbl.TabIndex = 0;
                lbl.Name = i.ToString();
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font("Arial", 20, FontStyle.Bold);
                if(word.phrase[i] == ' ')
                {
                    lbl.Text = " ";
                    indexesfound[i] = true;
                }
                else if (word.phrase[i] == '-')
                {
                    lbl.Text = "-";
                    indexesfound[i] = true;
                }
                else if (Char.IsUpper(word.phrase[i]))
                {
                    lbl.Text = word.phrase[i].ToString();
                    indexesfound[i] = true;
                }
                else if (Char.IsLower(word.phrase[i]))
                {
                    lbl.Text = "_";
                }
                lblLocationX += 30;
                pnlWord.Controls.Add(lbl);
                labelList.Add(lbl);
            }
        }

        private void lblDestroy()
        {
            labelList.Clear();
            pnlWord.Controls.Clear();
            foreach (Control c in pnlWord.Controls)
             c.Dispose();
        }

        private bool lblCheck(List<Label> lblList, char ch, Phrases word)
        {
            
            if (word.phrase.Contains(ch))
            {
                for (int i = 0; i < word.phrase.Length; i++)
                {
                    if (ch == word.phrase[i] && !indexesfound[i])
                    {
                        lblList[i].Text = ch.ToString();
                        indexesfound[i] = true;
                        frm_StartGame.PlayerList[frm_StartGame.PlayerIndex].currentScore += 10;
                    }
                    else if(ch == word.phrase[i] && indexesfound[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            click = true;
            //string.tryparse()

        }


        private bool checkForWin(Phrases word)
        {
            for (int i = 0; i < word.phrase.Length; i++)
            {
                if (!indexesfound[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void insertCheck()
        {
            lblLifesLeft.Text = "Lifes left : "+ totalLifes;
            lblDificulty.Text = "Dificulty Level : " + round;
            lblScore.Text = "Score : " + frm_StartGame.PlayerList[frm_StartGame.PlayerIndex].currentScore;

            lblHighScore.Text = "High Score :" + frm_StartGame.PlayerList[frm_StartGame.PlayerIndex].hiScore;

            if (checkForWin(phrasesList[phraseIndex]))
            {
                lbl_lettersUsed.Text = "Letters Used:";
                lblDestroy();
                round++;
                currentPhrase(round);
                frm_StartGame.PlayerList[frm_StartGame.PlayerIndex].currentScore += 100;
                pgrbrLife.Value = 100;
            }

            else if (pgrbrLife.Value == 0 && totalLifes > 0)
            {
                lbl_lettersUsed.Text = "Letters Used:";
                lblDestroy();
                totalLifes--;
                round++;
                currentPhrase(round);
                pgrbrLife.Value = 100;
            }

            else if (pgrbrLife.Value == 0 && totalLifes == 0)
            {
                lblMessage.Text = "You have lost all of your lifes! Game Over! Try with a new game!";
                frm_StartGame.PlayerList[frm_StartGame.PlayerIndex].addScore();
                this.Close();
                gFormMainClosed = true;
            }

            if (click)
            {
                if (txtb_Insert.Text == string.Empty)
                {
                    lblMessage.Text = "Please Type A letter!";

                }
                else
                {
                    try
                    {
                        if (lblCheck(labelList, Convert.ToChar(txtb_Insert.Text), phrasesList[phraseIndex]))
                        {
                            clockcounter = clockMax;
                            lbl_lettersUsed.Text += " " + txtb_Insert.Text;
                            txtb_Insert.Text = "";
                        }
                        else
                        {
                            lbl_lettersUsed.Text += " " + txtb_Insert.Text;
                            txtb_Insert.Text = "";
                            pgrbrLife.Value -= 25;
                        }
                    }
                    catch(Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    
                }
                
                click = false;
            }
            
        }

        private void frm_MainGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Enter)) //Ψυφιακό OR ( | ) 
            {
                click = true;
            }
        }

        private void frm_MainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_StartGame.PlayerList[frm_StartGame.PlayerIndex].addScore();
            gFormMainClosed = true;
        }

        private void pnlStats_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
