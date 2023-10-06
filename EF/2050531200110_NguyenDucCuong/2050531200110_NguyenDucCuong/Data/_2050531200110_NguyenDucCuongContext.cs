using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2050531200110_NguyenDucCuong.Models;

namespace _2050531200110_NguyenDucCuong.Data
{
    public class _2050531200110_NguyenDucCuongContext : DbContext
    {
        public _2050531200110_NguyenDucCuongContext (DbContextOptions<_2050531200110_NguyenDucCuongContext> options)
            : base(options)
        {
        }

        public DbSet<_2050531200110_NguyenDucCuong.Models.Product> Product { get; set; } = default!;

        public DbSet<_2050531200110_NguyenDucCuong.Models.Category>? Category { get; set; }

        public DbSet<_2050531200110_NguyenDucCuong.Models.Cart>? Cart { get; set; }
    }
}
