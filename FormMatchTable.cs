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
    public partial class FormMatchTable : Form
    {
        CsGoDatabase csGoDatabase;
        int matchId;
        public FormMatchTable(CsGoDatabase csGoDatabase,int matchId)
        {
            this.csGoDatabase = csGoDatabase;
            this.matchId = matchId;
            InitializeComponent();
            FillTable();
            SetName();
        }
        void SetName()
        {
            string query = "select t1.Name as Name1, t2.Name as Name2, m.Team1Rounds, m.Team2Rounds " +
                "from Matches m " +
                "join Teams t1 on t1.TeamID = m.Team1ID " +
                "join Teams t2 on t2.TeamID = m.Team2ID " +
                "where m.MatchID = @MatchID ";

            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@MatchID", matchId);
                DataTable matchesTable = new DataTable();
                adapter.Fill(matchesTable);
             
                foreach (DataRow row in matchesTable.Rows)
                {
                  label1.Text = row["Name1"].ToString() + " "+ row["Team1Rounds"].ToString()+":" + row["Team2Rounds"].ToString() + " "+ row["Name2"].ToString();
                }


            }
        }
        void FillTable()
        {
            string query = "select p.Nick,t.Name,ps.kills,ps.Deatch,ps.Points " +
                "from Matches m " +
                "join PlayerStats ps on ps.MatchID = m.MatchID " +
                "join Players p on p.PlayerID = ps.PlayerID " +
                "join Teams t on t.TeamID = p.TeamID " +
                "where m.MatchID = @MatchID " +
                "order by Points desc ";

            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@MatchID", matchId);
                DataTable matchesTable = new DataTable();
                adapter.Fill(matchesTable);

                listView1.Items.Clear();
                foreach (DataRow row in matchesTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["Nick"].ToString());
                    item.SubItems.Add(row["Name"].ToString() );
                    item.SubItems.Add(row["kills"].ToString());
                    item.SubItems.Add(row["Deatch"].ToString());
                    item.SubItems.Add(row["Points"].ToString());
                    listView1.Items.Add(item);
                }


            }

        }

     
    }
}
