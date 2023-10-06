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
    public class GioHangsController : Controller
    {
        private readonly _222LTC02_2050531200110_NguyenDucCuongContext _context;

        public GioHangsController(_222LTC02_2050531200110_NguyenDucCuongContext context)
        {
            _context = context;
        }

        // GET: GioHangs
        public async Task<IActionResult> Index()
        {
            var _222LTC02_2050531200110_NguyenDucCuongContext = _context.GioHang.Include(g => g.ThucPham);
            return View(await _222LTC02_2050531200110_NguyenDucCuongContext.ToListAsync());
        }

        // GET: GioHangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.GioHang == null)
            {
                return NotFound();
            }

            var gioHang = await _context.GioHang
                .Include(g => g.ThucPham)
                .FirstOrDefaultAsync(m => m.GioHangId == id);
            if (gioHang == null)
            {
                return NotFound();
            }

            return View(gioHang);
        }

        // GET: GioHangs/Create
        public IActionResult Create()
        {
            ViewData["ThucPhamId"] = new SelectList(_context.Set<ThucPham>(), "ThucPhamId", "ThucPhamId");
            return View();
        }

        // POST: GioHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GioHangId,Quantity,TotalPrice,ThucPhamId,NguoiMuaId")] GioHang gioHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gioHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ThucPhamId"] = new SelectList(_context.Set<ThucPham>(), "ThucPhamId", "ThucPhamId", gioHang.ThucPhamId);
            return View(gioHang);
        }

        // GET: GioHangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.GioHang == null)
            {
                return NotFound();
            }

            var gioHang = await _context.GioHang.FindAsync(id);
            if (gioHang == null)
            {
                return NotFound();
            }
            ViewData["ThucPhamId"] = new SelectList(_context.Set<ThucPham>(), "ThucPhamId", "ThucPhamId", gioHang.ThucPhamId);
            return View(gioHang);
        }

        // POST: GioHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GioHangId,Quantity,TotalPrice,ThucPhamId,NguoiMuaId")] GioHang gioHang)
        {
            if (id != gioHang.GioHangId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gioHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GioHangExists(gioHang.GioHangId))
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
            ViewData["ThucPhamId"] = new SelectList(_context.Set<ThucPham>(), "ThucPhamId", "ThucPhamId", gioHang.ThucPhamId);
            return View(gioHang);
        }

        // GET: GioHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.GioHang == null)
            {
                return NotFound();
            }

            var gioHang = await _context.GioHang
                .Include(g => g.ThucPham)
                .FirstOrDefaultAsync(m => m.GioHangId == id);
            if (gioHang == null)
            {
                return NotFound();
            }

            return View(gioHang);
        }

        // POST: GioHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.GioHang == null)
            {
                return Problem("Entity set '_222LTC02_2050531200110_NguyenDucCuongContext.GioHang'  is null.");
            }
            var gioHang = await _context.GioHang.FindAsync(id);
            if (gioHang != null)
            {
                _context.GioHang.Remove(gioHang);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GioHangExists(int id)
        {
          return (_context.GioHang?.Any(e => e.GioHangId == id)).GetValueOrDefault();
        }
    }
}
