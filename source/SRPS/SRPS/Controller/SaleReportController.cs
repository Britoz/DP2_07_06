using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPS.Model;

namespace SRPS.Controller
{
    public enum monthInYear
    {
        January, 
        February, 
        March, 
        April, 
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }


    public struct connectionSetting
    {
        public string server;
        public string database;
        public string username;
        public string password;

    }
    public class SaleReportController
    {
        
        SaleRecordModel model = new SaleRecordModel();
        connectionSetting connection = new connectionSetting();

        public SaleReportController()
        {
            connection.server = "localhost";
            connection.database = "srps";
            connection.username = "root";
            connection.password = "123456";
        }
        public List<SaleRecordModel> GetAllSaleRecord()
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();
            
            datas.GetConnectionString(connection.server,
                connection.database, connection.username, connection.password); //1
            
            return datas.GetALLSaleRecord();
        }

        public List<SaleRecordModel> GetALlSaleRecordByMonthAndYear(monthInYear choosing, int year)
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();

            datas.GetConnectionString(connection.server,
                connection.database, connection.username, connection.password); //1

            return datas.GetSaleByMonthInYear(choosing, year);
        }

        public SaleRecordModel GetValueByID(string id)
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();

            datas.GetConnectionString(connection.server,
                connection.database, connection.username, connection.password); //1

            return datas.GetSaleRecordByID(id);
        }
        public bool DeleteValue(SaleRecordModel deletData)
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();

            datas.GetConnectionString(connection.server,
                connection.database, connection.username, connection.password); //1

            return datas.GetDeleteData(deletData);
        }
        //edit
        public bool UpdateData(SaleRecordModel newData)
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();

            datas.GetConnectionString(connection.server,
                connection.database, connection.username, connection.password); ;

            return datas.GetUpdateValue(newData);
        }
    }
}
