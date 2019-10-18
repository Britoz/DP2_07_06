using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPS.Controller;

namespace SRPS.Model
{
    class ProductDBModel : DBModel
    {
        public ConnectionStructor connection = new ConnectionStructor();
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

        public bool AddProduct(SalesProductModel data)
        {
            try
            {
                string txt = "INSERT INTO `product`(`name`, `serialnumber`, `description`, `quantity`, `priceperunit`, `dateimport`) "
                + "VALUES (@name, @serialnumber, @description,@quantity,@priceperunit,@dateimport)";
                MySqlCommand command = new MySqlCommand(txt, Connection);
                Connection.Open();
                command.Parameters.AddWithValue("@name", data.Name);
                command.Parameters.AddWithValue("@serialnumber", data.Serialnumber);
                command.Parameters.AddWithValue("@description", data.Description);
                command.Parameters.AddWithValue("@quantity", data.Quantity);
                command.Parameters.AddWithValue("@priceperunit", data.Unitprice);
                command.Parameters.AddWithValue("@dateimport", data.DateImport);
                command.ExecuteNonQuery();
                Connection.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        //check  if the name exist
        public bool CheckVisibleName(string name)
        {
            GetConnectionString(connection.server(),
                connection.database(), connection.username(), connection.password());

            SalesProductModel ldata = new SalesProductModel();
            string txt = "select * from product where name='" + name+"'";
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

            if (name != ldata.Name)
            {
                return false;
            }
            return true;
        }

        //check  if the serialnumber exist
        public bool CheckVisibleSerialnumber(string serialnumber)
        {
            GetConnectionString(connection.server(),
                connection.database(), connection.username(), connection.password());

            SalesProductModel ldata = new SalesProductModel();
            string txt = "select * from product where serialnumber=" + serialnumber;
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

            if (Convert.ToInt32(serialnumber) != ldata.Serialnumber)
            {
                return false;
            }
            return true;
        }
    }
}
