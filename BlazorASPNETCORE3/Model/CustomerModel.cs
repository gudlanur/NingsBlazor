using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorASPNETCORE3.Model
{
    public class CustomerModel
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string Location { get; set; }

        public int CustomerOrder { get; set; }
    }
}
