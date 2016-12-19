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
    public partial class frm_StartGame : Form
    {


        string playersJsonPath = Application.StartupPath + "\\Players.json";
        public static List<Player> PlayerList = new List<Player>();
        public static int PlayerIndex;
        int playerCount;

        public frm_StartGame()
        {
            InitializeComponent();
        }

        private void frm_StartGame_Load(object sender, EventArgs e)
        {
            loadPlayers(playersJsonPath);
        }

        private void loadPlayers(string jsonPath)
        {
            try
            {
                PlayerList.Clear();
                PlayerList = JsonConvert.DeserializeObject<List<Player>>(System.IO.File.ReadAllText(jsonPath));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListBoxRefresh();
        }

        private void ListBoxRefresh()
        {
            lstb_Profiles.Items.Clear();
            foreach (var obj in PlayerList)
            {
                lstb_Profiles.Items.Add(obj);
            }
            // Όρισε το δείκτη ίσο με τον μέγεθος της λίστας
            playerCount = PlayerList.Count;
        }

        private void SavePlayers(string path)
        {

            try
            {
                //Καταχώρησε στην μεταβλητή contentsToWriteToFile τα στοιχεία της λίστας 
                string contentsToWriteToFile = JsonConvert.SerializeObject(PlayerList.ToArray(), Formatting.Indented);

                //Πέρασε στο Json την παραπάνω μεταβλητή
                System.IO.File.WriteAllText(path, contentsToWriteToFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_StartGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePlayers(playersJsonPath);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            PlayerList.Add(new Player(txtb_Name.Text, txtb_Password.Text, 0));
            ListBoxRefresh();
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            if(lstb_Profiles.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Profile to continue");
            }
            else
            {
                PlayerIndex = lstb_Profiles.SelectedIndex;
                if(PlayerList[PlayerIndex].password == txtb_Psw.Text)
                {
                    MessageBox.Show("Password Correct !");
                }
                else
                {
                    MessageBox.Show("Password Wrong !");
                }
            }
        }

        private void chkb_AddNew_CheckedChanged(object sender, EventArgs e)
        {
           
            pnl_Add.Visible = chkb_AddNew.Checked;
            if (chkb_AddNew.Checked)
            {
                pnl_Psw.Visible = !chkb_AddNew.Checked;
            }
           
           
        }

        private void lstb_Profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chkb_AddNew.Checked && lstb_Profiles.SelectedIndex != -1)
                pnl_Psw.Visible = true;
        }
    }

}
