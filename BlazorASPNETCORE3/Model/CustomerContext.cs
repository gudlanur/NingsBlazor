using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using BlazorASPNETCORE3.Model;

namespace BlazorASPNETCORE3.Model
{
    public class CustomerContext :DbContext
    {

        public CustomerContext()
        {

        }
        public CustomerContext(DbContextOptions options) :base(options)
        {

        }

       public DbSet<CustomerModel> CustomerTbl { get; set; }
    }
}
