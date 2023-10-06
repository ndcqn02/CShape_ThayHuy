﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cuong110.Data;
using Cuong110.Models;

namespace Cuong110.Pages.CaDangKy
{
    public class CreateModel : PageModel
    {
        private readonly Cuong110.Data.Cuong110Context _context;

        public CreateModel(Cuong110.Data.Cuong110Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CaDangKy CaDangKy { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.CaDangKy == null || CaDangKy == null)
            {
                return Page();
            }

            _context.CaDangKy.Add(CaDangKy);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
