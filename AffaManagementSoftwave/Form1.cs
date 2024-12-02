using System.Data.SqlClient;
using System.Data;
using AffaManagementSoftwave.Data;

namespace AffaManagementSoftwave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "admin")
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Hide();
            }
            else
            {
                string query = "SELECT * FROM Users WHERE email = @Email AND password = @Password";

                DbHelper connections = new DbHelper();

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Email", username),
            new SqlParameter("@Password", password)
                };

                try
                {
                    DataTable dataTables = connections.ExecuteReader(query, parameters);

                    if (dataTables.Rows.Count > 0)
                    {
                        UserPanel userPanel = new UserPanel();
                        userPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Gmail və ya parol yanlışdır.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xəta baş verdi: " + ex.Message);
                }
            }
        }


    }
}
