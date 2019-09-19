using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPS.Model
{
    class SaleRecordDBModel
    {

        private MySqlConnection _connection;

        public void GetConnectionString(string server, string database, string username, string password)
        {
            _connection = new MySqlConnection("server ="+server+";database = "
                +database+";username = "+username+";password ="+password+";");
        }

        public List<SaleRecordModel> GetALLSaleRecord()
        {
            List<SaleRecordModel> listData = new List<SaleRecordModel>();
            string txt = "select * from salesrecord";
            MySqlCommand command = new MySqlCommand(txt, _connection);
            _connection.Open();
            MySqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                SaleRecordModel sale = new SaleRecordModel();
                sale.Id = r[0].ToString();
                sale.TotalPrice = (int)r[2];
                sale.StaffName = r[3].ToString();
                sale.Date = r[4].ToString();
                sale.Time = r[5].ToString();

                listData.Add(sale);

            }
            _connection.Close();

            return listData;
        }
    }
}
