using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogging.Internal
{
        internal class DatabaseLogging : ILog
        {
        string connectionString = ConfigurationManager.ConnectionStrings["LogDB"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();

        string sql = "INSERT INTO Log (Message, Level, Date) VALUES (@message, @level, @date)";
        SqlCommand command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@message", log.Message);
        command.Parameters.AddWithValue("@level", log.Level);
        command.Parameters.AddWithValue("@date", log.Date);

        command.ExecuteNonQuery();

        connection.Close();
}
