using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _222LTC02_2050531200110_NguyenDucCuong.Models;

namespace _222LTC02_2050531200110_NguyenDucCuong.Data
{
    public class _222LTC02_2050531200110_NguyenDucCuongContext : DbContext
    {
        public _222LTC02_2050531200110_NguyenDucCuongContext (DbContextOptions<_222LTC02_2050531200110_NguyenDucCuongContext> options)
            : base(options)
        {
        }

        public DbSet<_222LTC02_2050531200110_NguyenDucCuong.Models.GioHang> GioHang { get; set; } = default!;

        public DbSet<_222LTC02_2050531200110_NguyenDucCuong.Models.NguoiMua>? NguoiMua { get; set; }

        public DbSet<_222LTC02_2050531200110_NguyenDucCuong.Models.ThucPham>? ThucPham { get; set; }
    }
}
