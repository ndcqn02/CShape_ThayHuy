using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenDucCuong_GKLan2.Data;
using NguyenDucCuong_GKLan2.Models;

namespace NguyenDucCuong_GKLan2.Pages.CongNhan
{
    public class DeleteModel : PageModel
    {
        private readonly NguyenDucCuong_GKLan2.Data.NguyenDucCuong_GKLan2Context _context;

        public DeleteModel(NguyenDucCuong_GKLan2.Data.NguyenDucCuong_GKLan2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public CongNhan CongNhan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CongNhan == null)
            {
                return NotFound();
            }

            var congnhan = await _context.CongNhan.FirstOrDefaultAsync(m => m.Id == id);

            if (congnhan == null)
            {
                return NotFound();
            }
            else 
            {
                CongNhan = congnhan;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CongNhan == null)
            {
                return NotFound();
            }
            var congnhan = await _context.CongNhan.FindAsync(id);

            if (congnhan != null)
            {
                CongNhan = congnhan;
                _context.CongNhan.Remove(CongNhan);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
