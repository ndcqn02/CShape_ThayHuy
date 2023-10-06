using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cuong110.Data;
using Cuong110.Models;

namespace Cuong110.Pages.CaLams
{
    public class EditModel : PageModel
    {
        private readonly Cuong110.Data.Cuong110Context _context;

        public EditModel(Cuong110.Data.Cuong110Context context)
        {
            _context = context;
        }

        [BindProperty]
        public CaLam CaLam { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CaLam == null)
            {
                return NotFound();
            }

            var calam =  await _context.CaLam.FirstOrDefaultAsync(m => m.Id == id);
            if (calam == null)
            {
                return NotFound();
            }
            CaLam = calam;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CaLam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaLamExists(CaLam.Id))
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

        private bool CaLamExists(int id)
        {
          return (_context.CaLam?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
