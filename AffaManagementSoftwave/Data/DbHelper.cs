using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffaManagementSoftwave.Data
{
    internal class DbHelper
    {
        string connectionString = "Data Source=HASANOV\\SQLEXPRESS;Initial Catalog=AffaManagement;Integrated Security=True;";
        public void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (var cmd = new SqlCommand(query, sqlConnection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Xəta baş verdi: " + ex.Message);
                }
            }
        }

        public DataTable ExecuteReader(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (var cmd = new SqlCommand(query, sqlConnection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (var sqlReader = cmd.ExecuteReader())
                        {
                            dataTable.Load(sqlReader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Xəta baş verdi: " + ex.Message);
                }
            }
            return dataTable;
        }
        public object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                
                command.Parameters.AddRange(parameters);

                try
                {
                    
                    connection.Open();

                    
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Xəta baş verdi: " + ex.Message);
                    return null;  
                }
            }
        }
    }
}
