using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenDucCuong_GKLan2.Data;
using NguyenDucCuong_GKLan2.Models;

namespace NguyenDucCuong_GKLan2.Pages.CongNhan
{
    public class EditModel : PageModel
    {
        private readonly NguyenDucCuong_GKLan2.Data.NguyenDucCuong_GKLan2Context _context;

        public EditModel(NguyenDucCuong_GKLan2.Data.NguyenDucCuong_GKLan2Context context)
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

            var congnhan =  await _context.CongNhan.FirstOrDefaultAsync(m => m.Id == id);
            if (congnhan == null)
            {
                return NotFound();
            }
            CongNhan = congnhan;
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

            _context.Attach(CongNhan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CongNhanExists(CongNhan.Id))
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

        private bool CongNhanExists(int id)
        {
          return (_context.CongNhan?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
