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
        const int indexWidth =-2;
        const int nameWidth =-20;
        const int strWidth = -20;
        const int valueWidth = -5;
        private string CreateRaport()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(MostKills());
            sb.Append(MostMatches());
            sb.Append(MostWins());
            sb.Append(MostRoundWon());
            sb.Append(BestPolishPlayer());
            sb.Append(BestKdRatio());
            return sb.ToString();
        }

        string MostKills()
        {
            string query = "select top 3 p.Nick, sum(ps.Kills) as KillsSum  " +
                "from PlayerStats ps " +
                "join Players p on p.PlayerID = ps.PlayerID " +
                "group by p.PlayerID, p.Nick " +
                "order by KillsSum desc";
            StringBuilder sb = new StringBuilder();
            sb.Append("Top 3 Players by Kills:\n");
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {

                DataTable bestPlayerTable = new DataTable();
                adapter.Fill(bestPlayerTable);
                int i = 1;
                foreach (DataRow row in bestPlayerTable.Rows)
                {
                    sb.Append($" {i++,indexWidth} :   {row["Nick"],nameWidth} {"Kills: ",strWidth }{row["KillsSum"],valueWidth} \n");
                }

            }
            return sb.ToString();
        }

       

        string MostMatches()
        {
            string query = "select top 3 p.Nick, count(ps.MatchID) as MatchSum  " +
                "from PlayerStats ps " +
                "join Players p on p.PlayerID = ps.PlayerID " +
                "group by p.PlayerID, p.Nick " +
                "order by MatchSum desc";
            StringBuilder sb = new StringBuilder();
            sb.Append("Top 3 players with the most matches played:\n");
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {

                DataTable bestPlayerTable = new DataTable();
                adapter.Fill(bestPlayerTable);
                int i = 1;
                foreach (DataRow row in bestPlayerTable.Rows)
                {
                    sb.Append($" {i++,indexWidth} :   {row["Nick"],nameWidth} {"Matches played:",strWidth }{row["MatchSum"],valueWidth} \n");
                }

            }
            return sb.ToString();
        }

        string MostWins()
        {
            string query = "select top 3  t.Name, (count(m.MatchID) ) as MatchesWon " +
                "from Teams t " +
                "join Matches m on (m.Team1ID = t.TeamID and m.Team1Rounds > m.Team2Rounds) or " +
                "(m.Team2ID = t.TeamID and m.Team1Rounds < m.Team2Rounds) " +
                "group by t.TeamID, t.Name " +
                "order by MatchesWon desc";

            StringBuilder sb = new StringBuilder();
            sb.Append("Top 3 teams with the most matches won:\n");
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {

                DataTable bestPlayerTable = new DataTable();
                adapter.Fill(bestPlayerTable);
                int i = 1;
                foreach (DataRow row in bestPlayerTable.Rows)
                {
                    sb.Append($" {i++,indexWidth} :   {row["Name"],nameWidth} {"Matches won:",strWidth }{row["MatchesWon"],valueWidth} \n");
                }

            }
            return sb.ToString();
        }

        string MostRoundWon()
        {
            string query = "select top 3 t.Name, ISNULL(Away.RoundAway, 0) + ISNULL(Home.RoundsHome, 0) as suma " +
                "from Teams t " +
                "full outer join(select t.TeamID, sum(m.Team2Rounds) as RoundAway " +
                "from Matches m " +
                "join Teams t on t.TeamID = m.Team2ID " +
                "group by t.TeamID) Away on Away.TeamID = t.TeamID " +
                "full outer join(select  t.TeamID, sum(m.Team1Rounds) as RoundsHome " +
                "from Matches m " +
                "join Teams t on t.TeamID = m.Team1ID " +
                "group by t.TeamID) Home on Home.TeamID = t.TeamID " +
                "order by suma desc";


           StringBuilder sb = new StringBuilder();
            sb.Append("Top 3 teams with the most round won:\n");
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {

                DataTable bestPlayerTable = new DataTable();
                adapter.Fill(bestPlayerTable);
                int i = 1;
                foreach (DataRow row in bestPlayerTable.Rows)
                {
                    sb.Append($" {i++,indexWidth} :   {row["Name"],nameWidth} {"Rounds won:",strWidth }{row["suma"],valueWidth} \n");
                }

            }
            return sb.ToString();
        }

        string BestPolishPlayer()
        {
            string query = "select top 1 p.Nick, sum(ps.Points) as PointsSum, sum(ps.Kills) as KillsSum, sum(ps.Deatch) as DeathsSum " +
                "from PlayerStats ps " +
                "join Players p on p.PlayerID = ps.PlayerID " +
                "join Teams t on t.TeamID = p.TeamID " +
                "where t.Nation = 'Poland' " +
                "group by p.PlayerID, p.Nick " +
                "order by PointsSum desc";


            StringBuilder sb = new StringBuilder();
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {

                DataTable bestPlayerTable = new DataTable();
                adapter.Fill(bestPlayerTable);
                foreach (DataRow row in bestPlayerTable.Rows)
                {
                    sb.Append($" {row["Nick"],nameWidth}  {"Kills: ",-7 }  {row["KillsSum"],valueWidth}  {"Deaths: ",-9 }  {row["DeathsSum"],valueWidth}  {"Points: ",-8 }  {row["PointsSum"],valueWidth} \n");
                }

            }
            if(sb.Length == 0)
            {
                sb.Append("There is no info on any Polish player\n");
            }
            return "Best player from Poland:\n" + sb.ToString();
        }

        string BestKdRatio()
        {
            string query = "select top 3 p.Nick,  CONVERT(DECIMAL(10,2),cast(sum(ps.Kills) as float) / cast(ISNULL(nullif( sum(ps.Deatch),0),1) as float)) as KDRatio " +
                "from PlayerStats ps " +
                "join Players p on p.PlayerID = ps.PlayerID " +
                "group by p.PlayerID, p.Nick " +
                "order by KDRatio desc";


            StringBuilder sb = new StringBuilder();
            sb.Append("Top 3 players with best KD Ratio:\n");
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {

                DataTable bestPlayerTable = new DataTable();
                adapter.Fill(bestPlayerTable);
                int i = 1;
                foreach (DataRow row in bestPlayerTable.Rows)
                {
                    sb.Append($" {i++,indexWidth} :   {row["Nick"],nameWidth} {"KD Ratio:",strWidth } {row["KDRatio"], 5} \n");
                }

            }
           
            return sb.ToString();
        }
    }
}
