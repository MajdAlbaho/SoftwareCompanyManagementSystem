using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SoftwareCompanyManagementSystem.Connection
{
    public static class ConnectionManager
    {
        public static string ConnectionString = 
            "Data Source=majd-pc;Initial Catalog=SoftwareCompany;User ID=sa;Password=P@ssw0rd";

        public static void ExecuteCommand(string command){
            

            using (var db = new SqlConnection(ConnectionString))
            {
                var cmd = new SqlCommand(command);
                cmd.Connection = db;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var data = reader["FirstName"];
                }
            }
        }
    }
}
