using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlazorASPNETCORE3.Model;

namespace BlazorASPNETCORE3.Data
{
    public class EditModel : PageModel
    {
        private readonly BlazorASPNETCORE3.Model.CustomerContext _context;

        public EditModel(BlazorASPNETCORE3.Model.CustomerContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CustomerModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerModelExists(CustomerModel.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CustomerModelExists(int id)
        {
            return _context.CustomerTbl.Any(e => e.Id == id);
        }
    }
}
