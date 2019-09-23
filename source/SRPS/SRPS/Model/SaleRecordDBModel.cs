using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPS.Model
{
    class SaleRecordDBModel:DBModel
    {
        public List<SaleRecordModel> GetALLSaleRecord()
        {
            //since this is a lot of sales record, so I use list
            List<SaleRecordModel> listData = new List<SaleRecordModel>();
            string txt = "select * from salesrecord";
            MySqlCommand command = new MySqlCommand(txt, Connection);
            Connection.Open();
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
            Connection.Close();

            return listData;
        }

        public SaleRecordModel GetSaleRecordByID(string id)
        {
            SaleRecordModel ldata = new SaleRecordModel();
            string txt = "select * from salesrecord where id=" + id;
            MySqlCommand command = new MySqlCommand(txt, Connection);
            Connection.Open();
            MySqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                id = r[0].ToString();
                ldata.TotalPrice = (int)r[2];
                ldata.StaffName = r[3].ToString();
                ldata.Date = r[4].ToString();
                ldata.Time = r[5].ToString();

            }
            Connection.Close();
            return ldata;
        }

        public bool GetUpdateValue(SaleRecordModel data)
        {
            SaleRecordModel ldata = new SaleRecordModel();
            
            string txt = "UPDATE `salesrecord` SET "+
                "`totalprice`="+data.TotalPrice+",`staffname`='"+data.StaffName+"'"
                +",`date`='"+data.Date+"',`time`='"+data.Time+"' WHERE id="+data.Id;
            MySqlCommand command = new MySqlCommand(txt, Connection);
            Connection.Open();
            MySqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                ldata.Id = r[0].ToString();
                ldata.TotalPrice = (int)r[2];
                ldata.StaffName = r[3].ToString();
                ldata.Date = r[4].ToString();
                ldata.Time = r[5].ToString();

            }
            Connection.Close();
            return true;
        }
    }
}
