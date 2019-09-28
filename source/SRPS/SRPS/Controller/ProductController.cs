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
        connectionSetting connection = new connectionSetting();

        public ProductController()
        {
            connection.server = "localhost";
            connection.database = "srps";
            connection.username = "root";
            connection.password = "";
        }

        public SalesProductModel GetCurrentInformation(string id)
        {
            ProductDBModel datas = new ProductDBModel();

            datas.GetConnectionString(connection.server, 
                connection.database, connection.username, connection.password); //1

            return datas.GetProductByID(id);
        }
    }
}
