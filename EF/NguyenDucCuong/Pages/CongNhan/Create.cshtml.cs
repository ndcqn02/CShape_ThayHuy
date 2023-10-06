using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NguyenDucCuong_GKLan2.Data;
using NguyenDucCuong_GKLan2.Models;

namespace NguyenDucCuong_GKLan2.Pages.CongNhan
{
    public class CreateModel : PageModel
    {
        private readonly NguyenDucCuong_GKLan2.Data.NguyenDucCuong_GKLan2Context _context;

        public CreateModel(NguyenDucCuong_GKLan2.Data.NguyenDucCuong_GKLan2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CongNhan CongNhan { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.CongNhan == null || CongNhan == null)
            {
                return Page();
            }

            _context.CongNhan.Add(CongNhan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
