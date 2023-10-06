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
    public class IndexModel : PageModel
    {
        private readonly Cuong110.Data.Cuong110Context _context;

        public IndexModel(Cuong110.Data.Cuong110Context context)
        {
            _context = context;
        }

        public IList<CaDangKy> CaDangKy { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CaDangKy != null)
            {
                CaDangKy = await _context.CaDangKy.ToListAsync();
            }
        }
    }
}
