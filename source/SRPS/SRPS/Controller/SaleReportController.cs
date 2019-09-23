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
        public List<SaleRecordModel> GetAllSaleRecord()
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();
            
            datas.GetConnectionString("localhost", "test", "root", ""); //1
            
            return datas.GetALLSaleRecord();
        }

        public SaleRecordModel GetValueByID(string id)
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();

            datas.GetConnectionString("localhost", "test", "root", ""); //1

            return datas.GetSaleRecordByID(id);
        }

        //edit
       public bool UpdateData(SaleRecordModel newData)
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();
            datas.GetConnectionString("localhost", "test", "root", "");

            return datas.GetUpdateValue(newData);
        }
    }
}
