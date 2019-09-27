using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPS.Controller;

namespace SRPS.Model
{
    class SaleRecordDBModel:DBModel
    {
        //get all sale record in database and return a list of SaleRecordModel, then controller can
        //use it whenever it wants
        //using this function to reduce the task
        public SaleRecordModel dbSingleDataComment(string data)
        {
            //result
            SaleRecordModel result = new SaleRecordModel();
            //command
            MySqlCommand command = new MySqlCommand(data, Connection);
            Connection.Open();
            MySqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                result.TotalPrice = (int)r[2];
                result.StaffName = r[3].ToString();
                result.Date = r[4].ToString();
                result.Time = r[5].ToString();
            }
            Connection.Close();

            return result;
        }
        //get list data by comment
        public List<SaleRecordModel> dbListDataComment(string data)
        {
            //result
            List<SaleRecordModel> datas = new List<SaleRecordModel>();
            //command
            MySqlCommand command = new MySqlCommand(data, Connection);
            Connection.Open();
            MySqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                //save to a SaleRecordModel form before are
                SaleRecordModel sale = new SaleRecordModel();
                sale.Id = r[0].ToString();
                sale.TotalPrice = (int)r[2];
                sale.StaffName = r[3].ToString();
                sale.Date = r[4].ToString();
                sale.Time = r[5].ToString();

                datas.Add(sale);
            }
            Connection.Close();

            return datas;
        }

        public List<SaleRecordModel> GetALLSaleRecord()
        {
            //since this is a lot of sales record, use list
            string txt = "select * from salesrecord";

            return dbListDataComment(txt);
        }

        public List<SaleRecordModel> GetSaleByMonthInYear(monthInYear month, int year)
        {
            int lMonth = (int)month;
            //result

            string txt = "SELECT * FROM `salesrecord` WHERE MONTH(date) = "+lMonth+" and Year(date) = "+year+"";
            
            return dbListDataComment(txt);
        }
        

        public SaleRecordModel GetSaleRecordByID(string id)
        {
            string txt = "select * from salesrecord where id=" + id;

            return dbSingleDataComment(txt);
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

        public bool GetDeleteData(SaleRecordModel data)
        {
            SaleRecordModel ldata = new SaleRecordModel();
            //since this is a lot of sales record, use list
            string deleteQuery = "DELETE FROM `salesrecord` WHERE id = " + data.Id;
            MySqlCommand command = new MySqlCommand(deleteQuery, Connection);
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
            r.Close();
            command.ExecuteNonQuery();
                Connection.Close();
                return true;
        }
    }
}
