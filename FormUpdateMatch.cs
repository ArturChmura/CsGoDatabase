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
    public partial class FormUpdateMatch : Form
    {
        CsGoDatabase csGoDatabase;
        int matchID;
        class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }

        }
        public FormUpdateMatch(CsGoDatabase csGoDatabase, int matchID)
        {
            this.csGoDatabase = csGoDatabase;
            this.matchID = matchID;
            InitializeComponent();
            LoadTeamsNames();
        }
        void LoadTeamsNames()
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
                    labelTeam1.Text = row["Team1Name"].ToString();
                    labelTeam2.Text = row["Team2Name"].ToString();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
          
            string query = " update  Matches " +
                "set Team1Rounds = @Team1Rounds, Team2Rounds = @Team2Rounds, Date = @Date " +
                "where MatchID = @MatchID ";



            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@MatchID", matchID);
                command.Parameters.AddWithValue("@Date", dateTimePicker.Value);
                command.Parameters.AddWithValue("@Team1Rounds", numericUpDown1.Value);
                command.Parameters.AddWithValue("@Team2Rounds", numericUpDown2.Value);


                command.ExecuteScalar();

            }
            csGoDatabase.ShowValues();
            MessageBox.Show("Match Updated");
            this.Controls.Clear();
            this.Close();
        }


    }
}
