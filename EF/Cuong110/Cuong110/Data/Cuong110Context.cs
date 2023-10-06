using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cuong110.Models;

namespace Cuong110.Data
{
    public class Cuong110Context : DbContext
    {
        public Cuong110Context (DbContextOptions<Cuong110Context> options)
            : base(options)
        {
        }

        public DbSet<Cuong110.Models.Movie> Movie { get; set; } = default!;

        public DbSet<Cuong110.Models.CongNhan>? CongNhan { get; set; }

        public DbSet<Cuong110.Models.CaLam>? CaLam { get; set; }

        public DbSet<Cuong110.Models.CaDangKy>? CaDangKy { get; set; }
    }
}
