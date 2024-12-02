using AffaManagementSoftwave.Data;
using AffaManagementSoftwave.Entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AffaManagementSoftwave
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void games_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (games.SelectedItem != null)
            {
                string selectedMatch = games.SelectedItem.ToString();
                string[] teams = selectedMatch.Split(new string[] { " vs " }, StringSplitOptions.None);

                if (teams.Length == 2)
                {
                    team1.Text = teams[0];
                    team2.Text = teams[1];

                    games.Items.Remove(games.SelectedItem);
                }
            }
        }

        private void Result_Load(object sender, EventArgs e)
        {
            games.Items.Clear();

            string query = @"
             SELECT 
                T1.TeamName AS HomeTeam,
                T2.TeamName AS AwayTeam,
                G.GameId
            FROM 
                Games G
            JOIN 
                Teams T1 ON G.HomeTeamId = T1.TeamId
            JOIN 
                Teams T2 ON G.AwayTeamId = T2.TeamId
            LEFT JOIN
                ResultGames RG ON G.GameId = RG.GameId
            WHERE
                RG.ResultGameId IS NULL";

            SqlParameter[] parameters = new SqlParameter[] { };

            try
            {
                DbHelper dbHelper = new DbHelper();
                DataTable gamesTable = dbHelper.ExecuteReader(query, parameters);

                foreach (DataRow row in gamesTable.Rows)
                {
                    string match = $"{row["HomeTeam"]} vs {row["AwayTeam"]}";
                    games.Items.Add(match);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Məlumat yüklənərkən xəta baş verdi: " + ex.Message);
            }
        }


        private void netice_Click(object sender, EventArgs e)
        {
            ResultGame result = new ResultGame()
            {
                Team1Name = team1.Text,
                Team2Name = team2.Text,
                Team1Goals = Convert.ToInt32(team1Score.Text),
                Team2Goals = Convert.ToInt32(team2Score.Text),
            };

            DbHelper connections = new DbHelper();
            try
            {
                string getGameIdQuery = @"
                                         SELECT GameId
                                         FROM Games G
                                         JOIN Teams T1 ON G.HomeTeamId = T1.TeamId
                                         JOIN Teams T2 ON G.AwayTeamId = T2.TeamId
                                         WHERE T1.TeamName = @Team1Name AND T2.TeamName = @Team2Name";

                SqlParameter[] gameIdParams = new SqlParameter[]
                {
                    new SqlParameter("@Team1Name", result.Team1Name),
                    new SqlParameter("@Team2Name", result.Team2Name)
                };

                int gameId = Convert.ToInt32(connections.ExecuteScalar(getGameIdQuery, gameIdParams));

                string insertQuery = "INSERT INTO ResultGames (GameId, Team1Name, Team2Name, Team1Goals, Team2Goals) " +
                                     "VALUES (@GameId, @Team1Name, @Team2Name, @Team1Goals, @Team2Goals)";

                SqlParameter[] insertParameters = new SqlParameter[]
                {
                      new SqlParameter("@GameId", gameId),
                      new SqlParameter("@Team1Name", result.Team1Name),
                      new SqlParameter("@Team2Name", result.Team2Name),
                      new SqlParameter("@Team1Goals", result.Team1Goals),
                      new SqlParameter("@Team2Goals", result.Team2Goals)
                };

                connections.ExecuteNonQuery(insertQuery, insertParameters);

                int team1Score = result.Team1Goals;
                int team2Score = result.Team2Goals;

                int team1Points = 0;
                int team2Points = 0;

                if (team1Score > team2Score)
                {
                    team1Points = 3;
                    team2Points = 0;
                }
                else if (team1Score < team2Score)
                {
                    team1Points = 0;
                    team2Points = 3;
                }
                else
                {
                    team1Points = 1;
                    team2Points = 1;
                }

                string getTeam1ScoreQuery = "SELECT TeamScore FROM Teams WHERE TeamName = @Team1Name";
                SqlParameter[] team1Params = new SqlParameter[] { new SqlParameter("@Team1Name", result.Team1Name) };
                int team1CurrentScore = Convert.ToInt32(connections.ExecuteScalar(getTeam1ScoreQuery, team1Params));

                string updateTeam1ScoreQuery = "UPDATE Teams SET TeamScore = @NewScore WHERE TeamName = @Team1Name";
                SqlParameter[] updateTeam1Params = new SqlParameter[]
                {
                   new SqlParameter("@NewScore", team1CurrentScore + team1Points),
                   new SqlParameter("@Team1Name", result.Team1Name)
                };
                connections.ExecuteNonQuery(updateTeam1ScoreQuery, updateTeam1Params);

                string getTeam2ScoreQuery = "SELECT TeamScore FROM Teams WHERE TeamName = @Team2Name";
                SqlParameter[] team2Params = new SqlParameter[] { new SqlParameter("@Team2Name", result.Team2Name) };
                int team2CurrentScore = Convert.ToInt32(connections.ExecuteScalar(getTeam2ScoreQuery, team2Params));

                string updateTeam2ScoreQuery = "UPDATE Teams SET TeamScore = @NewScore WHERE TeamName = @Team2Name";
                SqlParameter[] updateTeam2Params = new SqlParameter[]
                {
                      new SqlParameter("@NewScore", team2CurrentScore + team2Points),
                      new SqlParameter("@Team2Name", result.Team2Name)
                };
                connections.ExecuteNonQuery(updateTeam2ScoreQuery, updateTeam2Params);

                MessageBox.Show("Nəticə uğurla əlavə olundu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();   
            adminPanel.Show();
            this.Hide();
        }
    }
}
