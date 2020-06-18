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
    public partial class FormUpdatePlayer : Form
    {
        CsGoDatabase csGoDatabase;
        int playerID;
        public FormUpdatePlayer(CsGoDatabase csGoDatabase,int playerID)
        {
            this.csGoDatabase = csGoDatabase;
            this.playerID = playerID;
            InitializeComponent();
            FillTextBoxes();
        }
        void FillTextBoxes()
        {

            string query = " select p.FirstName , p.Nick, p.LastName " +
                "from Players p " +
                "where p.PlayerID = @PlayerID";

            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@PlayerID", playerID);
                DataTable namesTable = new DataTable();
                adapter.Fill(namesTable);
                foreach (DataRow row in namesTable.Rows)
                {
                    textBoxFirstName.Text = row["FirstName"].ToString();
                    textBoxNick.Text = row["Nick"].ToString();
                    textBoxLastName.Text = row["LastName"].ToString();
                }
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Length == 0 || textBoxNick.Text.Length == 0 || textBoxLastName.Text.Length == 0)
            {
                MessageBox.Show("Type down all data");
                return;
            }

            string query = " update  Players " +
                  "set FirstName = @FirstName " +
                  ",Nick = @Nick " +
                  ",LastName = @LastName " +
                  "where PlayerID = @PlayerID ";


            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                command.Parameters.AddWithValue("@Nick", textBoxNick.Text);
                command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                command.Parameters.AddWithValue("@PlayerID", playerID);

                command.ExecuteScalar();

            }
            csGoDatabase.ShowValues();
            MessageBox.Show("Player Updated");
            this.Close();
        }
    }
}
