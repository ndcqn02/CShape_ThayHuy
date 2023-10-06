using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TraiCayMuaGioHang.Data;
using TraiCayMuaGioHang.Models;

namespace TraiCayMuaGioHang.Controllers
{
    public class TraiCaysController : Controller
    {
        private readonly TraiCayMuaGioHangContext _context;

        public TraiCaysController(TraiCayMuaGioHangContext context)
        {
            _context = context;
        }

        // GET: TraiCays
        public async Task<IActionResult> Index()
        {
              return _context.TraiCay != null ? 
                          View(await _context.TraiCay.ToListAsync()) :
                          Problem("Entity set 'TraiCayMuaGioHangContext.TraiCay'  is null.");
        }

        // GET: TraiCays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TraiCay == null)
            {
                return NotFound();
            }

            var traiCay = await _context.TraiCay
                .FirstOrDefaultAsync(m => m.Id == id);
            if (traiCay == null)
            {
                return NotFound();
            }

            return View(traiCay);
        }

        // GET: TraiCays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TraiCays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Quantity,Price")] TraiCay traiCay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(traiCay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(traiCay);
        }

        // GET: TraiCays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TraiCay == null)
            {
                return NotFound();
            }

            var traiCay = await _context.TraiCay.FindAsync(id);
            if (traiCay == null)
            {
                return NotFound();
            }
            return View(traiCay);
        }

        // POST: TraiCays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Quantity,Price")] TraiCay traiCay)
        {
            if (id != traiCay.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(traiCay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TraiCayExists(traiCay.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(traiCay);
        }

        // GET: TraiCays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TraiCay == null)
            {
                return NotFound();
            }

            var traiCay = await _context.TraiCay
                .FirstOrDefaultAsync(m => m.Id == id);
            if (traiCay == null)
            {
                return NotFound();
            }

            return View(traiCay);
        }

        // POST: TraiCays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TraiCay == null)
            {
                return Problem("Entity set 'TraiCayMuaGioHangContext.TraiCay'  is null.");
            }
            var traiCay = await _context.TraiCay.FindAsync(id);
            if (traiCay != null)
            {
                _context.TraiCay.Remove(traiCay);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TraiCayExists(int id)
        {
          return (_context.TraiCay?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
