using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Coffee_Kiosk.Repository
{
    public class DatabaseManager
    {
        private readonly string _server = "localhost";
        private readonly int _port = 3306;
        private readonly string _database = "coffeeshop";
        private readonly string _id = "root";
        private readonly string _pw = "12345";
        private MySqlConnection _connection = null;
        private string _connectionAddress = "";

        public DatabaseManager() {
          _connectionAddress = $"Server={_server};Port={_port};Database={_database};Uid={_id};Pwd={_pw}";
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
