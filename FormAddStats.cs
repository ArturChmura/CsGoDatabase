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
    public partial class FormAddStats : Form
    {
        CsGoDatabase csGoDatabase;
        int playerID;
        public FormAddStats(CsGoDatabase csGoDatabase, int playerID)
        {
            this.csGoDatabase = csGoDatabase;
            this.playerID = playerID;

            InitializeComponent();
            LoadComboBoxes();
            LoadPlayerName();
        }
        class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }

        }
        void LoadComboBoxes()
        {

            string query = "select m.MatchID, m.Date, t1.Name as Team1Name,t2.Name as Team2Name  " +
                "from Matches m " +
                "join Players p on p.PlayerID = @PlayerID " +
                "join Teams t1 on t1.TeamID = m.Team1ID " +
                "join Teams t2 on t2.TeamID = m.Team2ID " +
                "where p.TeamID = m.Team1ID or p.TeamID = m.Team2ID ";

            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@PlayerID", playerID);

                DataTable teamsTable1 = new DataTable();
                adapter.Fill(teamsTable1);
                List<ComboItem> list = new List<ComboItem>();
                foreach (DataRow  row in teamsTable1.Rows)
                {
                    list.Add(new ComboItem { ID = int.Parse(row["MatchID"].ToString()), Text = row["Team1Name"].ToString() + " vs " + row["Team2Name"].ToString() + " " + row["Date"].ToString() });
                }
                comboBoxMatches.DisplayMember = "Text";
                comboBoxMatches.ValueMember = "ID";
                comboBoxMatches.DataSource = list;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxMatches.SelectedValue == null)
            {
                MessageBox.Show("The match has not been chosen");
                return;
            }
            string query = " INSERT INTO PlayerStats " +
                "Values(@PlayerID,@MatchID,@Kills, @Deaths,@Points)";



            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@PlayerID", playerID);
                command.Parameters.AddWithValue("@MatchID", comboBoxMatches.SelectedValue);
                command.Parameters.AddWithValue("@Kills", numericKills.Value);
                command.Parameters.AddWithValue("@Deaths", numericDeaths.Value);
                command.Parameters.AddWithValue("@Points", numericPoints.Value);

                try
                {
                    command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"This record already exist",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
               

            }
            csGoDatabase.ShowValues();
            MessageBox.Show("Stats Added");
            this.Controls.Clear();
            InitializeComponent();
            LoadComboBoxes();
            LoadPlayerName();
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
