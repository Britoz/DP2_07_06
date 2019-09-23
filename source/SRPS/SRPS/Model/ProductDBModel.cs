using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPS.Model
{
    class ProductDBModel : DBModel
    {
        
        public string modelId { get; set; }

        public SalesProductModel GetProductByID(string id)
        {
            
            SalesProductModel ldata = new SalesProductModel();
            string txt = "select * from product where id=" + id;
            MySqlCommand command = new MySqlCommand(txt, Connection);
            Connection.Open();
            MySqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                ldata.Id = r[0].ToString();
                ldata.Name = r[1].ToString();
                ldata.Serialnumber = Convert.ToInt32(r[2]);
                ldata.Quantity = Convert.ToInt32(r[4]);
                ldata.Unitprice = Convert.ToInt32(r[5]);
                
            }
            Connection.Close();
            return ldata;
        }
         

    }
}
