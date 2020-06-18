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
    public partial class CsGoDatabase : Form
    {
        void DeleteTeam(int teamID)
        {
            //deleting matches (and stats to this matches)
            DeleteMatchByTeamId(teamID);

            //deleting players
            string queryPlayers = " delete from Players " +
                   "where TeamID = @TeamID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryPlayers, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TeamID", teamID);
                command.ExecuteScalar();
            }

            //deleting team
            string queryTeam = " Delete from Teams " +
                "where TeamID = @TeamID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryTeam, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TeamID", teamID);
                command.ExecuteScalar();
            }
            ShowValues();
        }

        void DeletePlayer(int playerID)
        {
            DeleteStatsByPlayerId(playerID);

            string query = " Delete from Players " +
                "where PlayerID = @PlayerID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@PlayerID", playerID);
                command.ExecuteScalar();
            }
            ShowValues();
        }

        void DeleteStatsByPlayerId(int playerID)
        {
            string query = " Delete from PlayerStats " +
                "where PlayerID = @PlayerID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@PlayerID", playerID);
                command.ExecuteScalar();
            }
            ShowValues();
        }

        void DeleteStatsByMatchId(int matchID)
        {
            string query = " Delete from PlayerStats " +
                "where MatchID = @MatchID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@MatchID", matchID);
                command.ExecuteScalar();
            }
            ShowValues();
        }

        void DeleteMatchByTeamId(int teamID)
        {
            //delete stats
            string queryStats = "delete ps from PlayerStats ps " +
                "join Matches m on m.MatchID = ps.MatchID " +
                "where m.Team1ID = @TeamID or m.Team2ID = @TeamID";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryStats, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TeamID", teamID);
                command.ExecuteScalar();
            }



            //delete match
            string queryMatches = " delete from Matches " +
                   "where Team1ID = @TeamID or Team2ID = @TeamID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryMatches, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@TeamID", teamID);
                command.ExecuteScalar();
            }
            ShowValues();
        }

        void DeleteMatch(int matchID)
        {
            //delete stats
            DeleteStatsByMatchId(matchID);


            //delete match
            string queryMatches = " delete from Matches " +
                   "where MatchID = @MatchID ";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(queryMatches, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@MatchID", matchID);
                command.ExecuteScalar();
            }
            ShowValues();
        }

        void DeleteStats(int playerID,int matchID)
        {
            string query = " delete from PlayerStats " +
                   "where MatchID = @MatchID and PlayerID = @PlayerID";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@MatchID", matchID);
                command.Parameters.AddWithValue("@PlayerID", playerID);
                command.ExecuteScalar();
            }
            ShowValues();
        }
    }
}
