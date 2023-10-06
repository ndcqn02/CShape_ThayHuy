﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cuong110.Data;
using Cuong110.Models;

namespace Cuong110.Pages.CaDangKy
{
    public class EditModel : PageModel
    {
        private readonly Cuong110.Data.Cuong110Context _context;

        public EditModel(Cuong110.Data.Cuong110Context context)
        {
            _context = context;
        }

        [BindProperty]
        public CaDangKy CaDangKy { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CaDangKy == null)
            {
                return NotFound();
            }

            var cadangky =  await _context.CaDangKy.FirstOrDefaultAsync(m => m.Id == id);
            if (cadangky == null)
            {
                return NotFound();
            }
            CaDangKy = cadangky;
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

            _context.Attach(CaDangKy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaDangKyExists(CaDangKy.Id))
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

        private bool CaDangKyExists(int id)
        {
          return (_context.CaDangKy?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}