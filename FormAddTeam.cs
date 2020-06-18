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
    public partial class FormAddTeam : Form
    {
   
        CsGoDatabase csGoDatabase;
        public FormAddTeam(CsGoDatabase csGoDatabase)
        {
            this.csGoDatabase = csGoDatabase;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if(textBoxTeamName.Text.Length == 0 || textBoxTeamNation.Text.Length == 0)
            {
                MessageBox.Show("Type down all data");
                return;
            }
            string query = " INSERT INTO Teams " +
                "Values(@TeamName, @TeamNation)";



            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@TeamName", textBoxTeamName.Text);

                command.Parameters.AddWithValue("@TeamNation", textBoxTeamNation.Text);

                command.ExecuteScalar();

            }
            csGoDatabase.ShowValues();
            MessageBox.Show("Team Added");
            this.Controls.Clear();
            InitializeComponent();
        }

       
    }
}
