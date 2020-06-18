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
    public partial class FormAddPlayer : Form
    {
        CsGoDatabase csGoDatabase;
        int teamID;
        public FormAddPlayer(CsGoDatabase csGoDatabase,int teamID)
        {
            this.csGoDatabase = csGoDatabase;
            this.teamID = teamID;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Length == 0 || textBoxNick.Text.Length == 0 || textBoxLastName.Text.Length == 0)
            {
                MessageBox.Show("Type down all data");
                return;
            }

            string query = " INSERT INTO Players " +
                  "Values(@FirstName, @LastName,@Nick,@TeamID)";



            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                command.Parameters.AddWithValue("@Nick", textBoxNick.Text);
                command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                command.Parameters.AddWithValue("@TeamID", teamID);

                command.ExecuteScalar();

            }
            csGoDatabase.ShowValues();
            MessageBox.Show("Player Added");
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
