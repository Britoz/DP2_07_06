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
        public List<SaleRecordModel> GetAllSaleRecord()
        {
            SaleRecordDBModel datas = new SaleRecordDBModel();
            datas.GetConnectionString("localhost", "srps", "root", "");
            List<SaleRecordModel> listdata = datas.GetALLSaleRecord();
            
            return listdata;
        }
    }
}
