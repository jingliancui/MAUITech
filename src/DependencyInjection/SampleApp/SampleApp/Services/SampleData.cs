using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services
{
    public class SampleData : ISampleData
    {
        public List<string> RetrieveData()
        {
            var list = new List<string> 
            {
                "数据1",
                "数据2",
                "数据3",
                "数据4",
            };

            return list;
        }
    }
}
