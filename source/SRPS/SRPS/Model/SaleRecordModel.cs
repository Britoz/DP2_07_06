using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPS.Model
{
    public class SaleRecordModel
    {
        //variable
        private string _id;
        private int _totalPrice;
        private string _staffName;
        private string _date;
        private string _time;

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public int TotalPrice
        {
            get
            {
                return _totalPrice;
            }

            set
            {
                _totalPrice = value;
            }
        }

        public string StaffName
        {
            get
            {
                return _staffName;
            }

            set
            {
                _staffName = value;
            }
        }

        public string Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }

        public string Time
        {
            get
            {
                return _time;
            }

            set
            {
                _time = value;
            }
        }

        //properties

        //constructor
        public SaleRecordModel()
        {

        }

        public SaleRecordModel(string id, string staffName,int totalPrice, string date, string time)
        {
            StaffName = staffName;
            TotalPrice = totalPrice;
            Date = date;
            Time = time;
        }
    }
}
