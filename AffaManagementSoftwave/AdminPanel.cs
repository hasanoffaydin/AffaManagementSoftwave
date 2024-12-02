using AffaManagementSoftwave.Data;
using AffaManagementSoftwave.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffaManagementSoftwave
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

            ilkKomanda.Items.Clear();
            ikinciKomanda.Items.Clear();


            string query = "SELECT TeamName FROM Teams";


            SqlParameter[] parameters = new SqlParameter[] { };

            DbHelper connections = new DbHelper();
            DataTable result = connections.ExecuteReader(query, parameters);


            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {

                    ilkKomanda.Items.Add(row["TeamName"].ToString());
                    ikinciKomanda.Items.Add(row["TeamName"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Heç bir komanda tapılmadı.");
            }
        }
        private void home_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void elaveEt_Click(object sender, EventArgs e)
        {
            Team team = new Team()
            {
                TeamName = komandaAdi.Text,
                TeamScore = 0
            };


            string teamQuery = "INSERT INTO Teams (TeamName, TeamScore) VALUES (@TeamName, @TeamScore)";

            SqlParameter[] teamParameters = new SqlParameter[]
            {
               new SqlParameter("@TeamName", team.TeamName),
               new SqlParameter("@TeamScore", team.TeamScore)
            };

            DbHelper connections = new DbHelper();
            try
            {

                connections.ExecuteNonQuery(teamQuery, teamParameters);
                MessageBox.Show("Komanda uğurla qeydiyyatdan keçdi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
        }


        private void oyunElaveEt_Click(object sender, EventArgs e)
        {

            DateTime gameDate = gameTime.Value;
            string homeTeamName = ilkKomanda.Text;
            string awayTeamName = ikinciKomanda.Text;


            string homeTeamQuery = "SELECT TeamId FROM Teams WHERE TeamName = @TeamName";
            string awayTeamQuery = "SELECT TeamId FROM Teams WHERE TeamName = @TeamName";


            SqlParameter[] parametersHome = new SqlParameter[]
            {
                 new SqlParameter("@TeamName", homeTeamName)
            };
            SqlParameter[] parametersAway = new SqlParameter[]
            {
                 new SqlParameter("@TeamName", awayTeamName)
            };

            DbHelper connections = new DbHelper();


            int homeTeamId = Convert.ToInt32(connections.ExecuteScalar(homeTeamQuery, parametersHome));
            int awayTeamId = Convert.ToInt32(connections.ExecuteScalar(awayTeamQuery, parametersAway));


            string insertQuery = "INSERT INTO Games (HomeTeamId, AwayTeamId, GameDate) " +
                                 "VALUES (@HomeTeamId, @AwayTeamId, @GameDate)";


            SqlParameter[] insertParameters = new SqlParameter[]
            {
               new SqlParameter("@HomeTeamId", homeTeamId),
               new SqlParameter("@AwayTeamId", awayTeamId),
               new SqlParameter("@GameDate", gameDate)
            };


            connections.ExecuteNonQuery(insertQuery, insertParameters);

            MessageBox.Show("Oyun uğurla əlavə olundu!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result.Show();
            this.Hide();
        }

        private void home_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void turniket_Click(object sender, EventArgs e)
        {
            TurnirCedveli turnirCedveli = new TurnirCedveli();
            turnirCedveli.Show();
            this.Hide();
            

        }

    }
}
