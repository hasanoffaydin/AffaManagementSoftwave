using AffaManagementSoftwave.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffaManagementSoftwave
{
    public partial class TurnirCedveli : Form
    {
        public TurnirCedveli()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void TurnirCedveli_Load(object sender, EventArgs e)
        {
            string query = @"
    SELECT 
    T.TeamName,
    COUNT(G.GameId) AS TotalGames,
   SUM(CASE 
        WHEN RG.Team1Name = T.TeamName AND RG.Team1Goals > RG.Team2Goals THEN 1
        WHEN RG.Team2Name = T.TeamName AND RG.Team2Goals > RG.Team1Goals THEN 1
        ELSE 0 
    END) AS Wins,
    SUM(CASE 
        WHEN RG.Team1Name = T.TeamName AND RG.Team1Goals < RG.Team2Goals THEN 1
        WHEN RG.Team2Name = T.TeamName AND RG.Team2Goals < RG.Team1Goals THEN 1
        ELSE 0 
    END) AS Losses,
    SUM(CASE WHEN RG.Team1Goals = RG.Team2Goals THEN 1 ELSE 0 END) AS Draws,
    SUM(CASE 
        WHEN RG.Team1Name = T.TeamName THEN RG.Team1Goals 
        WHEN RG.Team2Name = T.TeamName THEN RG.Team2Goals 
        ELSE 0 
    END) AS GoalsScored,
    SUM(CASE 
        WHEN RG.Team1Name = T.TeamName THEN RG.Team2Goals 
        WHEN RG.Team2Name = T.TeamName THEN RG.Team1Goals 
        ELSE 0 
    END) AS GoalsConceded,
    SUM(CASE 
        WHEN RG.Team1Name = T.TeamName AND RG.Team1Goals > RG.Team2Goals THEN 3
        WHEN RG.Team2Name = T.TeamName AND RG.Team2Goals > RG.Team1Goals THEN 3
        WHEN RG.Team1Goals = RG.Team2Goals THEN 1
        ELSE 0 
    END) AS Points
FROM 
    Teams T
LEFT JOIN 
    Games G ON T.TeamId = G.HomeTeamId OR T.TeamId = G.AwayTeamId
LEFT JOIN 
    ResultGames RG ON (RG.Team1Name = T.TeamName OR RG.Team2Name = T.TeamName) AND G.GameId = RG.GameId
GROUP BY 
    T.TeamName
ORDER BY 
    Points DESC, GoalsScored DESC;

    ";

            DbHelper dbHelper = new DbHelper();
            DataTable dt = dbHelper.ExecuteReader(query, new System.Data.SqlClient.SqlParameter[] { });

            dataGridView1.DataSource = dt;
        }
    }
}
