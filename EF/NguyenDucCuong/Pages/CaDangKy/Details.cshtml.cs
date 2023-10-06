using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cuong110.Data;
using Cuong110.Models;

namespace Cuong110.Pages.CaDangKy
{
    public class DetailsModel : PageModel
    {
        private readonly Cuong110.Data.Cuong110Context _context;

        public DetailsModel(Cuong110.Data.Cuong110Context context)
        {
            _context = context;
        }

      public CaDangKy CaDangKy { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CaDangKy == null)
            {
                return NotFound();
            }

            var cadangky = await _context.CaDangKy.FirstOrDefaultAsync(m => m.Id == id);
            if (cadangky == null)
            {
                return NotFound();
            }
            else 
            {
                CaDangKy = cadangky;
            }
            return Page();
        }
    }
}
