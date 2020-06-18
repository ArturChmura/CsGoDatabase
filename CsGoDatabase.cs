using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace CsGoDatabase
{
    public partial class CsGoDatabase : Form
    {
        public string connectionString;
        public SqlConnection connection;
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();


        public CsGoDatabase()
        {
            InitializeComponent();
            builder.UserID = "sa"; 
            builder.Password = " TU PROSZE PODAC HASLO DO LOKALNEGO SERWARA ";
            builder.DataSource = "127.0.0.1";
            builder.InitialCatalog = "CsGoDatabase";
            connectionString = builder.ConnectionString;
        }

        private void CsGoDatabase_Load(object sender, EventArgs e)
        {
            ShowMatches();
            ShowTeams();
        }

        public void ShowValues()
        {
            int matchIndex =-1, playerIndex=-1, teamIndex=-1, statsIndex=-1;
            if(listViewMatches.SelectedItems.Count > 0)
            {
                matchIndex = listViewMatches.SelectedItems[0].Index;
            }
            if (listViewTeams.SelectedItems.Count > 0)
            {
                teamIndex = listViewTeams.SelectedItems[0].Index;
            }
            if (listViewPlayers.SelectedItems.Count > 0)
            {
                playerIndex = listViewPlayers.SelectedItems[0].Index;

            }
            if (listViewStats.SelectedItems.Count > 0)
            {
                statsIndex = listViewStats.SelectedItems[0].Index;
            }
            ShowMatches();
            ShowTeams();
            ShowPlayers();
            ShowStats();
            if(matchIndex>= 0 && listViewMatches.Items.Count > 0)
            {
                listViewMatches.Items[matchIndex % (listViewMatches.Items.Count)].Selected = true;
            }
            if ( teamIndex >= 0 && listViewTeams.Items.Count > 0)
            {
                listViewTeams.Items[teamIndex % (listViewTeams.Items.Count)].Selected = true;
            }
            if (playerIndex >= 0 && listViewPlayers.Items.Count > 0)
            {
                listViewPlayers.Items[playerIndex % (listViewPlayers.Items.Count)].Selected = true;
            }
            if (statsIndex >= 0 && listViewStats.Items.Count > 0)
            {
                listViewStats.Items[statsIndex % (listViewStats.Items.Count)].Selected = true;
            }

        }


        void ShowMatches()
        {
            string query = " select m.MatchID,m.Date, t1.Name as Team1Name, t2.Name as Team2Name, m.Team1Rounds, m.Team2Rounds " +
                "from Matches m " +
                "join Teams t1 on m.Team1ID = t1.TeamID " +
                "join Teams t2 on m.Team2ID = t2.TeamID ";



            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable matchesTable = new DataTable();
                adapter.Fill(matchesTable);

                listViewMatches.Items.Clear();
                foreach (DataRow row in matchesTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["Team1Name"].ToString());
                    item.SubItems.Add(row["Team1Rounds"].ToString() + ":" + row["Team2Rounds"].ToString());
                    item.SubItems.Add(row["Team2Name"].ToString());
                    item.SubItems.Add(row["Date"].ToString());
                    item.ImageIndex = int.Parse(row["MatchID"].ToString());
                    listViewMatches.Items.Add(item);
                }


            }
        }
        void ShowTeams()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from Teams", connection))
            {

                DataTable teamsTable = new DataTable();
                adapter.Fill(teamsTable);


                listViewTeams.Items.Clear();
                foreach (DataRow row in teamsTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["Name"].ToString());
                    item.SubItems.Add(row["Nation"].ToString());
                    item.ImageIndex = int.Parse(row["TeamID"].ToString());
                    listViewTeams.Items.Add(item);
                }

            }
        }
        void ShowPlayers()
        {
            if (listViewTeams.SelectedItems.Count == 0)
            {
                listViewPlayers.Items.Clear();
                return;
            }
            string query = " select * from Players p " +
                "where p.TeamID = @TeamID";


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TeamID", listViewTeams.SelectedItems[0].ImageIndex);
                DataTable playersTable = new DataTable();
                adapter.Fill(playersTable);


                listViewPlayers.Items.Clear();
                foreach (DataRow row in playersTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["FirstName"].ToString() + " \"" + row["Nick"].ToString() + "\" " + row["LastName"].ToString());
                    item.ImageIndex = int.Parse(row["PlayerID"].ToString());
                    listViewPlayers.Items.Add(item);
                }
            }

        }

        void ShowStats()
        {
            if (listViewPlayers.SelectedItems.Count == 0)
            {
                listViewStats.Items.Clear();
                return;
            }
            string query = "select ps.MatchID, ps.Kills, ps.Deatch, ps.Points, t1.Name as Team1Name,t2.Name as Team2Name,t1.TeamID as Team1ID,t2.TeamID as Team2ID from Matches m " +
                "join PlayerStats ps on ps.MatchID = m.MatchID " +
                "join Teams t1 on m.Team1ID = t1.TeamID " +
                "join Teams t2 on m.Team2ID = t2.TeamID " +
                "where ps.PlayerID = @PlayerID";


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@PlayerID", listViewPlayers.SelectedItems[0].ImageIndex);
                DataTable statsTable = new DataTable();
                adapter.Fill(statsTable);

                listViewStats.Items.Clear();
                foreach (DataRow row in statsTable.Rows)
                {
                    ListViewItem item;

                    if ((int)row["Team1ID"] == listViewTeams.SelectedItems[0].ImageIndex)
                    {
                        item = new ListViewItem(row["Team2Name"].ToString());
                    }
                    else
                    {
                        item = new ListViewItem(row["Team1Name"].ToString());
                    }
                    
                    item.SubItems.Add(row["Kills"].ToString());
                    item.SubItems.Add(row["Deatch"].ToString());
                    item.SubItems.Add(row["Points"].ToString());
                    item.ImageIndex = int.Parse(row["MatchID"].ToString());
                    listViewStats.Items.Add(item);
                }



            }
        }

        private void listViewTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPlayers();
            ShowStats();
        }
        private void listViewPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowStats();
        }

        private void listViewMatches_DoubleClick(object sender, EventArgs e)
        {
            FormMatchTable form = new FormMatchTable(this, listViewMatches.SelectedItems[0].ImageIndex);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("siema");
        }

       
      
    }




}


