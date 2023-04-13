using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyGlory
{
    class db_connect : IDisposable
    {
        private readonly MySqlConnection connection;

        public db_connect()
        {
            connection = new MySqlConnection("host=localhost;uid=root;pwd=root;database=trade1;");
            OpenConnect();
        }

        public void Dispose()
        {
            CloseConnect();
        }

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
