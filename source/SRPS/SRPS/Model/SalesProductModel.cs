using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPS.Model
{
    class SalesProductModel
    {
        private string _id;
        private string _name;
        private int _serialnumber;
        private int _quantity;
        private int _unitprice;

        public SalesProductModel() { }
        public SalesProductModel(string id, string name, int serialnumber, int quantity,int unitprice )
        {
            _id = id;
            _name = name;
            _serialnumber = serialnumber;
            _quantity = quantity;
            _unitprice = unitprice;
        }
        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Serialnumber { get => _serialnumber; set => _serialnumber = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public int Unitprice { get => _unitprice; set => _unitprice = value; }
    }
}
