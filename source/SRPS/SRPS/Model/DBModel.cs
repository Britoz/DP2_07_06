using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPS.Model
{
    public abstract class DBModel
    {
        private MySqlConnection _connection;

        public MySqlConnection Connection { get => _connection; set => _connection = value; }

        public void GetConnectionString(string server, string database, string username, string password)
        {
            Connection = new MySqlConnection("server =" + server + ";database = "
                + database + ";username = " + username + ";password =" + password + ";");
        }
    }
}
