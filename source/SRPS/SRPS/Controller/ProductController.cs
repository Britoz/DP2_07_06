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
        ConnectionStructor connection = new ConnectionStructor();

        public ProductController()
        {
        }

        public SalesProductModel GetCurrentInformation(string id)
        {
            ProductDBModel datas = new ProductDBModel();

            datas.GetConnectionString(connection.server(), 
                connection.database(), connection.username(), connection.password()); //1

            return datas.GetProductByID(id);
        }

        public bool AddProduct(SalesProductModel data)
        {
            ProductDBModel datas = new ProductDBModel();

            datas.GetConnectionString(connection.server(),
                connection.database(), connection.username(), connection.password()); //1

            return datas.AddProduct(data);
        }
    }
}
