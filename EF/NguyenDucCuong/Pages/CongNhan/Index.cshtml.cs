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
    public class IndexModel : PageModel
    {
        private readonly NguyenDucCuong_GKLan2.Data.NguyenDucCuong_GKLan2Context _context;

        public IndexModel(NguyenDucCuong_GKLan2.Data.NguyenDucCuong_GKLan2Context context)
        {
            _context = context;
        }

        public IList<CongNhan> CongNhan { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CongNhan != null)
            {
                CongNhan = await _context.CongNhan.ToListAsync();
            }
        }
    }
}
