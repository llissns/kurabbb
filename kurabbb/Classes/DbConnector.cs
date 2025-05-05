using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurabbb.Classes
{
    internal class DbConnector
    {
        private static string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19";

        public static NpgsqlConnection GetConnection()
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка подключения к базе данных: " + ex.Message);
            }
        }
    }
}
