using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EF_Core.Data;
using EF_Core.Models;

namespace EF_Core.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly EF_Core.Data.EF_CoreContext _context;

        public IndexModel(EF_Core.Data.EF_CoreContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
