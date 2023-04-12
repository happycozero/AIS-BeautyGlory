using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyGlory
{
    class db_connect
    {
        
        MySqlConnection connection = new MySqlConnection("host=localhost;uid=root;pwd=;database=trade1;");
        //MySqlConnection connection = new MySqlConnection("host=localhost;uid=root;pwd=root;database=trade;");

        public void OpenConnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnect()
        {
            return connection;
        }
    }
}
