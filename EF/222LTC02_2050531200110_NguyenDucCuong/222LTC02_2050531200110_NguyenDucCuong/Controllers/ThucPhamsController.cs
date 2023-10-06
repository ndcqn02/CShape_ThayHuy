using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _222LTC02_2050531200110_NguyenDucCuong.Data;
using _222LTC02_2050531200110_NguyenDucCuong.Models;

namespace _222LTC02_2050531200110_NguyenDucCuong.Controllers
{
    public class ThucPhamsController : Controller
    {
        private readonly _222LTC02_2050531200110_NguyenDucCuongContext _context;

        public ThucPhamsController(_222LTC02_2050531200110_NguyenDucCuongContext context)
        {
            _context = context;
        }

        // GET: ThucPhams
        public async Task<IActionResult> Index(string searchString)
        {
            //return _context.ThucPham != null ? 
            //            View(await _context.ThucPham.ToListAsync()) :
            //            Problem("Entity set '_222LTC02_2050531200110_NguyenDucCuongContext.ThucPham'  is null.");

            ViewData["CurrentFilter"] = searchString;
            var products = from s in _context.ThucPham
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString));
            }
            return View(await products.AsNoTracking().ToListAsync());


        }

        // GET: ThucPhams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ThucPham == null)
            {
                return NotFound();
            }

            var thucPham = await _context.ThucPham
                .FirstOrDefaultAsync(m => m.ThucPhamId == id);
            if (thucPham == null)
            {
                return NotFound();
            }

            return View(thucPham);
        }

        // GET: ThucPhams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ThucPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ThucPhamId,Name,Price,Description,Image,DOB")] ThucPham thucPham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thucPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thucPham);
        }

        // GET: ThucPhams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ThucPham == null)
            {
                return NotFound();
            }

            var thucPham = await _context.ThucPham.FindAsync(id);
            if (thucPham == null)
            {
                return NotFound();
            }
            return View(thucPham);
        }

        // POST: ThucPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ThucPhamId,Name,Price,Description,Image,DOB")] ThucPham thucPham)
        {
            if (id != thucPham.ThucPhamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thucPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThucPhamExists(thucPham.ThucPhamId))
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
            return View(thucPham);
        }

        // GET: ThucPhams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ThucPham == null)
            {
                return NotFound();
            }

            var thucPham = await _context.ThucPham
                .FirstOrDefaultAsync(m => m.ThucPhamId == id);
            if (thucPham == null)
            {
                return NotFound();
            }

            return View(thucPham);
        }

        // POST: ThucPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ThucPham == null)
            {
                return Problem("Entity set '_222LTC02_2050531200110_NguyenDucCuongContext.ThucPham'  is null.");
            }
            var thucPham = await _context.ThucPham.FindAsync(id);
            if (thucPham != null)
            {
                _context.ThucPham.Remove(thucPham);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThucPhamExists(int id)
        {
          return (_context.ThucPham?.Any(e => e.ThucPhamId == id)).GetValueOrDefault();
        }
    }
}
