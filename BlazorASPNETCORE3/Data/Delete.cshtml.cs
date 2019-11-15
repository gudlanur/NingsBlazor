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
    public class DeleteModel : PageModel
    {
        private readonly BlazorASPNETCORE3.Model.CustomerContext _context;

        public DeleteModel(BlazorASPNETCORE3.Model.CustomerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CustomerModel CustomerModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomerModel = await _context.CustomerTbl.FirstOrDefaultAsync(m => m.Id == id);

            if (CustomerModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomerModel = await _context.CustomerTbl.FindAsync(id);

            if (CustomerModel != null)
            {
                _context.CustomerTbl.Remove(CustomerModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
