using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services
{
    public class DealMsg : IDealMsg
    {
        public DealMsg(string somestr)
        {
            if (string.IsNullOrEmpty(somestr))
            {
                throw new Exception("需要构造函数传参");
            }
        }
        public int Deal()
        {
            return 100;
        }
    }
}
