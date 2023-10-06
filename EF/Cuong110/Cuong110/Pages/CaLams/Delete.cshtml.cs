using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cuong110.Data;
using Cuong110.Models;

namespace Cuong110.Pages.CaLams
{
    public class DeleteModel : PageModel
    {
        private readonly Cuong110.Data.Cuong110Context _context;

        public DeleteModel(Cuong110.Data.Cuong110Context context)
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

            var calam = await _context.CaLam.FirstOrDefaultAsync(m => m.Id == id);

            if (calam == null)
            {
                return NotFound();
            }
            else 
            {
                CaLam = calam;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CaLam == null)
            {
                return NotFound();
            }
            var calam = await _context.CaLam.FindAsync(id);

            if (calam != null)
            {
                CaLam = calam;
                _context.CaLam.Remove(CaLam);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
