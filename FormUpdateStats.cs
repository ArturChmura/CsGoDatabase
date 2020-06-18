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

namespace CsGoDatabase
{
    public partial class FormUpdateStats : Form
    {
        CsGoDatabase csGoDatabase;
        int playerID;
        int matchID;
        public FormUpdateStats(CsGoDatabase csGoDatabase, int playerID, int matchID)
        {
            this.csGoDatabase = csGoDatabase;
            this.playerID = playerID;
            this.matchID = matchID;
            InitializeComponent();
            LoadPlayerName();
            LoadMatchName();
        }
        class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }

        }

        void LoadMatchName()
        {

            string query = " select t1.Name as Team1Name, t2.Name as Team2Name " +
                "from Matches m " +
                "join Teams t1 on t1.TeamID = m.Team1ID " +
                "join Teams t2 on t2.TeamID = m.Team2ID " +
                "where m.MatchID = @MatchID";

            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@MatchID", matchID);
                DataTable namesTable = new DataTable();
                adapter.Fill(namesTable);
                foreach (DataRow row in namesTable.Rows)
                {
                    label2.Text = row["Team1Name"].ToString() + " vs " + row["Team2Name"].ToString();
                }
            }
        }
        //void LoadComboBoxes()
        //{

        //    string query = "select m.MatchID, m.Date, t1.Name as Team1Name,t2.Name as Team2Name  " +
        //        "from Matches m " +
        //        "join Players p on p.PlayerID = @PlayerID " +
        //        "join Teams t1 on t1.TeamID = m.Team1ID " +
        //        "join Teams t2 on t2.TeamID = m.Team2ID " +
        //        "where p.TeamID = m.Team1ID or p.TeamID = m.Team2ID ";

        //    using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
        //    using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
        //    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //    {
        //        csGoDatabase.connection.Open();
        //        command.Parameters.AddWithValue("@PlayerID", playerID);

        //        DataTable teamsTable1 = new DataTable();
        //        adapter.Fill(teamsTable1);
        //        List<ComboItem> list = new List<ComboItem>();
        //        foreach (DataRow  row in teamsTable1.Rows)
        //        {
        //            list.Add(new ComboItem { ID = int.Parse(row["MatchID"].ToString()), Text = row["Team1Name"].ToString() + " vs " + row["Team2Name"].ToString() + " " + row["Date"].ToString() });
        //        }
        //        comboBoxMatches.DisplayMember = "Text";
        //        comboBoxMatches.ValueMember = "ID";
        //        comboBoxMatches.DataSource = list;
        //    }
        //}

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //if(comboBoxMatches.SelectedValue == null)
            //{
            //    MessageBox.Show("The match has not been chosen");
            //    return;
            //}
            string query = " update PlayerStats " +
                "set Kills = @Kills, Deatch = @Deatch, Points = @Points " +
                "where PlayerID = @PlayerID and MatchID = @MatchID";



            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@PlayerID", playerID);
                command.Parameters.AddWithValue("@MatchID", matchID);
                command.Parameters.AddWithValue("@Kills", numericKills.Value);
                command.Parameters.AddWithValue("@Deatch", numericDeaths.Value);
                command.Parameters.AddWithValue("@Points", numericPoints.Value);

                
                    command.ExecuteScalar();
                
               

            }
            csGoDatabase.ShowValues();
            MessageBox.Show("Stats Updated");
            this.Close();
        }

        private void LoadPlayerName()
        {
            string query = "select FirstName, Nick, LastName from Players p " +
               "where p.PlayerID = @PlayerID";

            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@PlayerID", playerID);

                DataTable teamsTable1 = new DataTable();
                adapter.Fill(teamsTable1);

                label1.Text = teamsTable1.Rows[0]["FirstName"].ToString() + " \"" + teamsTable1.Rows[0]["Nick"].ToString() + "\" "+  teamsTable1.Rows[0]["LastName"].ToString();
            }
        }

        
    }
}
