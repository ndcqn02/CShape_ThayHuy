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
    public class NguoiMuasController : Controller
    {
        private readonly _222LTC02_2050531200110_NguyenDucCuongContext _context;

        public NguoiMuasController(_222LTC02_2050531200110_NguyenDucCuongContext context)
        {
            _context = context;
        }

        // GET: NguoiMuas
        public async Task<IActionResult> Index()
        {
              return _context.NguoiMua != null ? 
                          View(await _context.NguoiMua.ToListAsync()) :
                          Problem("Entity set '_222LTC02_2050531200110_NguyenDucCuongContext.NguoiMua'  is null.");
        }

        // GET: NguoiMuas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NguoiMua == null)
            {
                return NotFound();
            }

            var nguoiMua = await _context.NguoiMua
                .FirstOrDefaultAsync(m => m.NguoiMuaId == id);
            if (nguoiMua == null)
            {
                return NotFound();
            }

            return View(nguoiMua);
        }

        // GET: NguoiMuas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NguoiMuas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NguoiMuaId,Name,DOB,DiaChi")] NguoiMua nguoiMua)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguoiMua);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nguoiMua);
        }

        // GET: NguoiMuas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NguoiMua == null)
            {
                return NotFound();
            }

            var nguoiMua = await _context.NguoiMua.FindAsync(id);
            if (nguoiMua == null)
            {
                return NotFound();
            }
            return View(nguoiMua);
        }

        // POST: NguoiMuas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NguoiMuaId,Name,DOB,DiaChi")] NguoiMua nguoiMua)
        {
            if (id != nguoiMua.NguoiMuaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguoiMua);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoiMuaExists(nguoiMua.NguoiMuaId))
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
            return View(nguoiMua);
        }

        // GET: NguoiMuas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NguoiMua == null)
            {
                return NotFound();
            }

            var nguoiMua = await _context.NguoiMua
                .FirstOrDefaultAsync(m => m.NguoiMuaId == id);
            if (nguoiMua == null)
            {
                return NotFound();
            }

            return View(nguoiMua);
        }

        // POST: NguoiMuas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.NguoiMua == null)
            {
                return Problem("Entity set '_222LTC02_2050531200110_NguyenDucCuongContext.NguoiMua'  is null.");
            }
            var nguoiMua = await _context.NguoiMua.FindAsync(id);
            if (nguoiMua != null)
            {
                _context.NguoiMua.Remove(nguoiMua);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguoiMuaExists(int id)
        {
          return (_context.NguoiMua?.Any(e => e.NguoiMuaId == id)).GetValueOrDefault();
        }
    }
}
