using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPS.Model;

namespace SRPS.Controller
{

    
    public class SaleReportController
    {
        SaleRecordModel model = new SaleRecordModel();
        connectionSetting connection = new connectionSetting();

        public SaleReportController()
        {
        }
        
        public List<SaleRecordModel> GetAllSaleRecord()
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();
            
            datas.GetConnectionString(connection.server(),
                connection.database(), connection.username(), connection.password()); //1
            
            return datas.GetALLSaleRecord();
        }

        public List<SaleRecordModel> GetALlSaleRecordByMonthAndYear(monthInYear choosing, int year)
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();

            datas.GetConnectionString(connection.server(),
                connection.database(), connection.username(), connection.password()); //1

            return datas.GetSaleByMonthInYear(choosing, year);
        }

        //it basically to send the request to Model, then model will get all value that controller ask about
        // weekly
        public List<SaleRecordModel> GetAllSaleRecordByWeekAndYear(int week, int year)
        {
            //we have to make the connection between controller and model first
            SaleRecordDBModel datas = new SaleRecordDBModel();

            //then we can make the connection of Model to database
            datas.GetConnectionString(connection.server(),
                connection.database(), connection.username(), connection.password()); //1

            //get the response from Model about the week in year
            return datas.GetSaleByWeekInYear(week, year);

        }

        public SaleRecordModel GetValueByID(string id)
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();

            datas.GetConnectionString(connection.server(),
                connection.database(), connection.username(), connection.password()); //1

            return datas.GetSaleRecordByID(id);
        }
        public bool DeleteValue(SaleRecordModel deletData)
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();

            datas.GetConnectionString(connection.server(),
                connection.database(), connection.username(), connection.password()); //1

            return datas.GetDeleteData(deletData);
        }
        //edit
        public bool UpdateData(SaleRecordModel newData)
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();

            datas.GetConnectionString(connection.server(),
                connection.database(), connection.username(), connection.password());

            return datas.GetUpdateValue(newData);
        }
    }
}
