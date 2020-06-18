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
    public partial class FormAddMatch : Form
    {
        CsGoDatabase csGoDatabase;
        class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }

        }
        public FormAddMatch(CsGoDatabase csGoDatabase)
        {
            this.csGoDatabase = csGoDatabase;
            InitializeComponent();
            LoadComboBoxes();
        }
        void LoadComboBoxes()
        {
         
            string query = " select t.TeamID, t.Name from Teams t";

            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                csGoDatabase.connection.Open();
                DataTable teamsTable1 = new DataTable();
                DataTable teamsTable2 = new DataTable();
                adapter.Fill(teamsTable1);
                adapter.Fill(teamsTable2);
                comboBoxTeams1.DisplayMember = comboBoxTeams2.DisplayMember = "Name";
                comboBoxTeams1.ValueMember = comboBoxTeams2.ValueMember = "TeamID";
                comboBoxTeams1.DataSource =  teamsTable1;
                comboBoxTeams2.DataSource = teamsTable2;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxTeams1.SelectedValue == null || comboBoxTeams2.SelectedValue == null)
            {
                MessageBox.Show("The teams have not been chosen");
                return;
            }
            if ((int)comboBoxTeams1.SelectedValue == (int)comboBoxTeams2.SelectedValue )
            {
                MessageBox.Show("Choose 2 different teams");
                return;
            }
            string query = " INSERT INTO Matches " +
                "Values(@Team1ID,@Team2ID,@Date, @Team1Rounds, @Team2Rounds)";



            using (csGoDatabase.connection = new SqlConnection(csGoDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(query, csGoDatabase.connection))
            {
                csGoDatabase.connection.Open();
                command.Parameters.AddWithValue("@Team1ID", (int)comboBoxTeams1.SelectedValue);
                command.Parameters.AddWithValue("@Team2ID", (int)comboBoxTeams2.SelectedValue);
                command.Parameters.AddWithValue("@Date", dateTimePicker.Value);
                command.Parameters.AddWithValue("@Team1Rounds", numericUpDown1.Value);
                command.Parameters.AddWithValue("@Team2Rounds", numericUpDown2.Value);


                command.ExecuteScalar();

            }
            csGoDatabase.ShowValues();
            MessageBox.Show("Match Added");
            this.Controls.Clear();
            InitializeComponent();
            LoadComboBoxes();
        }

     
    }
}
