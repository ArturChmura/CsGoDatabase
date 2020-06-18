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
    public partial class FormUpdateTeam : Form
    {
   
        CsGoDatabase csGoDatabase;
        int teamID;
        public FormUpdateTeam(CsGoDatabase csGoDatabase,int teamID)
        {
            this.csGoDatabase = csGoDatabase;
            this.teamID = teamID;
            InitializeComponent();
            FillTextBoxes();
        }

        void FillTextBoxes()
        {

            string query = " select t.Name , t.Nation " +
                "from Teams t " +
                "where t.TeamID = @TeamID";

            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@TeamID", teamID);
                DataTable namesTable = new DataTable();
                adapter.Fill(namesTable);
                foreach (DataRow row in namesTable.Rows)
                {
                    textBoxTeamName.Text = row["Name"].ToString();
                    textBoxTeamNation.Text = row["Nation"].ToString();
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if(textBoxTeamName.Text.Length == 0 || textBoxTeamNation.Text.Length == 0)
            {
                MessageBox.Show("Type down all data");
                return;
            }
            string query = " update Teams " +
                "Set Name = @Name, Nation = @Nation " +
                "where TeamID = @TeamID";



            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@Name", textBoxTeamName.Text);

                command.Parameters.AddWithValue("@Nation", textBoxTeamNation.Text);
                command.Parameters.AddWithValue("@TeamID", teamID);

                command.ExecuteScalar();

            }
            csGoDatabase.ShowValues();
            MessageBox.Show("Team Updated");
            this.Close();
        }

       
    }
}
