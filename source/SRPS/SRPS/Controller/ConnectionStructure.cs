using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPS.Controller
{
    public enum monthInYear
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }


    public struct connectionSetting
    {
        public string server()
        {
            return "localhost";
        }

        public string database()
        {
            return "srps";
        }

        public string username()
        {
            return "root";
        }

        public string password()
        {
            return "123456";
        }

    }
}
