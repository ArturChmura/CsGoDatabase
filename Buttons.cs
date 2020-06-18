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
        private void buttonRaport_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Raport(*.txt)|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter txt = new StreamWriter(fileDialog.FileName);
                string Raport = CreateRaport();
                txt.Write(Raport);
                txt.Close();
            }
        }

      

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            FormAddTeam formAddTeam = new FormAddTeam(this);
            formAddTeam.Show();
        }
        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if (listViewTeams.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select Team to add player");
                return;
            }

            FormAddPlayer form = new FormAddPlayer(this, listViewTeams.SelectedItems[0].ImageIndex);

            form.Show();
        }

        private void buttonAddStats_Click(object sender, EventArgs e)
        {
            if (listViewPlayers.SelectedItems.Count == 0 )
            {
                MessageBox.Show("Select Player to add stats");
                return;
            }

            FormAddStats form = new FormAddStats(this, listViewPlayers.SelectedItems[0].ImageIndex);

            form.Show();
        }
        private void buttonAddMatch_Click(object sender, EventArgs e)
        {
            FormAddMatch form = new FormAddMatch(this);
            form.Show();
        }
        private void buttonDeleteStats_Click(object sender, EventArgs e)
        {
            if(listViewStats.SelectedItems.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure?\n", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteStats((int)listViewPlayers.SelectedItems[0].ImageIndex, 
                    listViewStats.SelectedItems[0].ImageIndex) ;
            }
        }

        private void buttonDeleteMatch_Click(object sender, EventArgs e)
        {
            if(listViewMatches.SelectedItems.Count == 0)
            {
                return;
            }    
            if (MessageBox.Show("Are you sure?\n", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteMatch((int)listViewMatches.SelectedItems[0].ImageIndex);
            }
        }
        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            if (listViewTeams.SelectedItems.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure?\nDeleting a Team also delete all its players and matches", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteTeam((int)listViewTeams.SelectedItems[0].ImageIndex);
            }


        }
        private void buttonDeletePlayer_Click(object sender, EventArgs e)
        {
            if (listViewPlayers.SelectedItems.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure?\n", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeletePlayer((int)listViewPlayers.SelectedItems[0].ImageIndex);
            }
        }

        private void buttonUpdateMatch_Click(object sender, EventArgs e)
        {
            if (listViewMatches.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select match to update");
                return;
            }
            FormUpdateMatch form = new FormUpdateMatch(this, listViewMatches.SelectedItems[0].ImageIndex);
            form.Show();
        }

        private void buttonUpdateTeam_Click(object sender, EventArgs e)
        {
            if (listViewTeams.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select team to update");
                return;
            }
            FormUpdateTeam form = new FormUpdateTeam(this, listViewTeams.SelectedItems[0].ImageIndex);
            form.Show();
        }

        private void buttonUpdatePlayer_Click(object sender, EventArgs e)
        {
            if (listViewPlayers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select player to update");
                return;
            }
            FormUpdatePlayer form = new FormUpdatePlayer(this, listViewPlayers.SelectedItems[0].ImageIndex);
            form.Show();
        }

        private void buttonUpdateStats_Click(object sender, EventArgs e)
        {
            if (listViewStats.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select stats to update");
                return;
            }
            FormUpdateStats form = new FormUpdateStats(this, listViewPlayers.SelectedItems[0].ImageIndex, listViewStats.SelectedItems[0].ImageIndex);
            form.Show();
        }
    }
}
