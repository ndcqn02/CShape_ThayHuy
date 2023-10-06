using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DucCuong.Models;

namespace DucCuong.Data
{
    public class DucCuongContext : DbContext
    {
        public DucCuongContext (DbContextOptions<DucCuongContext> options)
            : base(options)
        {
        }

        public DbSet<DucCuong.Models.Product> Product { get; set; } = default!;

        public DbSet<DucCuong.Models.Category>? Category { get; set; }
    }
}
