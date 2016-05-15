using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class Order : ContractBase
    {
        public int ID { get; set; }

        public int ClientID { get; set; }

        public string ReferenceNumber { get; set; }
    }
}
