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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = name.Text,
                LastName = lastname.Text,
                Email = gmail.Text,
                Password = password.Text,
            };
            string query = "INSERT INTO Users (Name, LastName, Email, Password) " +
                   "VALUES (@Name, @LastName, @Email, @Password)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", user.Name),
                new SqlParameter("@LastName", user.LastName),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@Password", user.Password)
            };
            DbHelper connections = new DbHelper();
            connections.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Sign Up Ugurla Basa Catdi\n");
        }

        
    }
}
