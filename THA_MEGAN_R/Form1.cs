using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_MEGAN_R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Team> teams = new List<Team>();
        private void butt_addTeam_Click(object sender, EventArgs e)
        {
            comboBox_country.Items.Clear();
            bool sameTeam = false;
            if (textBox_nameTeam.Text == "" || textBox_countryTeam.Text == "" || textBox_cityTeam.Text == "")
            {
                MessageBox.Show("The text box cannot be empty.", "Please fill in everything.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_nameTeam.Clear();
                textBox_countryTeam.Clear();
                textBox_cityTeam.Clear();
                textBox_nameTeam.Focus();
            }
            else
            {
                Team dreamTeam = new Team(textBox_nameTeam.Text, textBox_countryTeam.Text, textBox_cityTeam.Text);
                foreach (Team team in teams)
                {
                    if (team.teamName == dreamTeam.teamName)
                    {
                        sameTeam = true;
                    }
                }
                if (sameTeam == true)
                {
                    MessageBox.Show("Teams are already exist.", "Please add a new team.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    teams.Add(dreamTeam);
                }
                textBox_nameTeam.Clear();
                textBox_countryTeam.Clear();
                textBox_cityTeam.Clear();
                textBox_nameTeam.Focus();
            }
            foreach (Team team in teams)
            {
                if (!comboBox_country.Items.Contains(team.teamCountry))
                {
                    comboBox_country.Items.Add(team.teamCountry);
                }
            }
        }
        private void comboBox_country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (Team team in teams)
            {
                if (team.teamCountry == comboBox_country.Text)
                {
                    comboBox_team.Items.Add(team.teamName);
                }
            }
        }
        private void comboBox_team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listBox_data.Items.Clear();
            foreach (Team team in teams)
            {
                if (team.teamName == comboBox_team.Text)
                {
                    foreach (Player players in team.Players)
                    {
                        listBox_data.Items.Add("(" + players.playerNumber + ") " + players.playerName + ", " + players.playerPosition);
                        listBox_data.Sorted = true;
                    }
                    break;
                }
            }
        }
        private void butt_addPlayers_Click(object sender, EventArgs e)
        {
            bool samePlayer = true;
            if (textBox_playersName.Text == "" || textBox_playersNumber.Text == "" || comboBox_playerPosition.SelectedIndex == -1)
            {
                MessageBox.Show("The player boxes cannot be empty.", "Please fill in everything.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_playersName.Clear();
                textBox_playersNumber.Clear();
                textBox_playersName.Focus();
            }
            else
            {
                if (comboBox_team.Text == "")
                {
                    MessageBox.Show("The team box cannot be empty.", "Please select a team.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Player newbie = new Player(textBox_playersName.Text, textBox_playersNumber.Text, comboBox_playerPosition.Text);
                    foreach (Team team in teams)
                    {
                        if (team.teamName == comboBox_team.Text)
                        { 
                            foreach (Player player in team.Players)
                            {
                                if (newbie.playerNumber == player.playerNumber)
                                {
                                    samePlayer = false;
                                    break;
                                }
                            }
                            if (samePlayer == true)
                            {
                                team.Players.Add(newbie);
                            }
                            else
                            {
                                MessageBox.Show("Players' number cannot be the same", "Please make a change.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                    }
                }
                textBox_playersName.Text = "";
                textBox_playersNumber.Text = "";
                comboBox_playerPosition.SelectedIndex = -1;
            }
        }
        private void butt_Remove_Click(object sender, EventArgs e)
        {
            if (listBox_data.Items.Count < 12)
            {
                MessageBox.Show("The total of players cannot be less than 11.", "Sorry...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox_data.Items.RemoveAt(listBox_data.SelectedIndex);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Team bubu = new Team("Manchester United", "England", "Manchester");
            teams.Add(bubu);
            Team bibi = new Team("FC Barcelona", "Spain", "Barcelona");
            teams.Add(bibi);
            Team bebe = new Team("Real Madrid", "Spain", "Madrid");
            teams.Add(bebe);
            foreach (Team team in teams)
            {
                if (!comboBox_country.Items.Contains((team.teamCountry)))
                {
                    comboBox_country.Items.Add(team.teamCountry);
                }
            }
            Player player1 = new Player("David De Gea", "01", "GK");
            bubu.Players.Add(player1);
            Player player2 = new Player("Lisando Martinez", "06", "DF");
            bubu.Players.Add(player2);
            Player player3 = new Player("Harry Maguire", "05", "DF");
            bubu.Players.Add(player3);
            Player player4 = new Player("Diogo Dalot", "20", "DF");
            bubu.Players.Add(player4);
            Player player5 = new Player("Bruno Fernandes", "08", "MF");
            bubu.Players.Add(player5);
            Player player6 = new Player("Marcus Rashford", "10", "FW");
            bubu.Players.Add(player6);
            Player player7 = new Player("Marcel Sabitzer", "15", "MF");
            bubu.Players.Add(player7);
            Player player8 = new Player("Antony", "21", "FW");
            bubu.Players.Add(player8);
            Player player9 = new Player("Casemiro", "18", "MF");
            bubu.Players.Add(player9);
            Player player10 = new Player("Raphael Varane", "16", "DF");
            bubu.Players.Add(player10);
            Player player11 = new Player("Anthony Martial", "09", "FW");
            bubu.Players.Add(player11);
            Player player12 = new Player("Courtois", "01", "GK");
            bebe.Players.Add(player12);
            Player player13 = new Player("Carvajal", "02", "DF");
            bebe.Players.Add(player13);
            Player player14 = new Player("E Militao", "03", "DF");
            bebe.Players.Add(player14);
            Player player15 = new Player("Alaba", "04", "DF");
            bebe.Players.Add(player15);
            Player player16 = new Player("Modric", "10", "MF");
            bebe.Players.Add(player16);
            Player player17 = new Player("Benzema", "09", "FW");
            bebe.Players.Add(player17);
            Player player18 = new Player("Camavinga", "12", "MF");
            bebe.Players.Add(player18);
            Player player19 = new Player("Asensio", "11", "FW");
            bebe.Players.Add(player19);
            Player player20 = new Player("D Ceballos", "19", "MF");
            bebe.Players.Add(player20);
            Player player21 = new Player("Lucas V", "17", "DF");
            bebe.Players.Add(player21);
            Player player22 = new Player("Vinny JR", "20", "FW");
            bebe.Players.Add(player22);
            Player player23 = new Player("Marc Andre", "01", "GK");
            bibi.Players.Add(player23);
            Player player24 = new Player("Ronald Araujo" ,"04", "DF");
            bibi.Players.Add(player24);
            Player player25 = new Player("Andreas Christensen", "15", "DF");
            bibi.Players.Add(player25);
            Player player26 = new Player("Marcos Alonso", "17", "DF");
            bibi.Players.Add(player26);
            Player player27 = new Player("Eric Garcia", "24", "DF");
            bibi.Players.Add(player27);
            Player player28 = new Player("Gavi", "06", "MF");
            bibi.Players.Add(player28);
            Player player29 = new Player("Sergio Busquets", "05", "MF");
            bibi.Players.Add(player29);
            Player player30 = new Player("Sergi Roberto", "20", "MF");
            bibi.Players.Add(player30);
            Player player31 = new Player("Ansu Fati", "10", "FW");
            bibi.Players.Add(player31);
            Player player32 = new Player("Ferran Torres", "11", "FW");
            bibi.Players.Add(player32);
            Player player33 = new Player("Raphinha", "22", "FW");
            bibi.Players.Add(player33);
        }
    }
}
