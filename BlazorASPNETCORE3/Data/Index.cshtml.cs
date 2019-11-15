using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlazorASPNETCORE3.Model;

namespace BlazorASPNETCORE3.Data
{
    public class IndexModel : PageModel
    {
        private readonly BlazorASPNETCORE3.Model.CustomerContext _context;

        public IndexModel(BlazorASPNETCORE3.Model.CustomerContext context)
        {
            _context = context;
        }

        public IList<CustomerModel> CustomerModel { get;set; }

        public async Task OnGetAsync()
        {
            CustomerModel = await _context.CustomerTbl.ToListAsync();
        }
    }
}
