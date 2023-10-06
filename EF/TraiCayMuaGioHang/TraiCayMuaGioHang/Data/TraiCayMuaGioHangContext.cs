using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TraiCayMuaGioHang.Models;

namespace TraiCayMuaGioHang.Data
{
    public class TraiCayMuaGioHangContext : DbContext
    {
        public TraiCayMuaGioHangContext (DbContextOptions<TraiCayMuaGioHangContext> options)
            : base(options)
        {
        }

        public DbSet<TraiCayMuaGioHang.Models.TraiCay> TraiCay { get; set; } = default!;
    }
}
