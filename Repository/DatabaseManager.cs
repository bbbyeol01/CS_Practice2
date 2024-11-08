using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace Coffee_Kiosk.Repository
{
    public class DatabaseManager
    {
        private MySqlConnection _connection = null;
        private string _connectionAddress = "";

        public DatabaseManager() {
          _connectionAddress = ConfigurationManager.AppSettings["DB_CONNECT_STRING"];
        }

        public  MySqlConnection GetConnection()
            {
                if (_connection == null || _connection.State == ConnectionState.Closed)
                {
                    _connection = new MySqlConnection(_connectionAddress);
                    _connection.Open();
                }
                return _connection;
            }
        }
}
