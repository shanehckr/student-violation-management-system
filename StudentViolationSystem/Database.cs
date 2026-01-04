using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentViolationSystem
{
    internal class Database
    {
        private static string connStringing = "Server=localhost;Port=3306;Database=student_violation_monitoring_system_db;Uid=root;Password=0ms2026System;";
        

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStringing);
        }

    public static int GetCount(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connStringing))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

    }

}
