using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPS.Model;

namespace SRPS.Controller
{
    class ProductController
    {
        public SalesProductModel GetCurrentInformation(string id)
        {
            ProductDBModel datas = new ProductDBModel();

            datas.GetConnectionString("localhost", "test", "root", ""); //1

            return datas.GetProductByID(id);
        }
    }
}
