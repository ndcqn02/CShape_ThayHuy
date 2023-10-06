using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenDucCuong_GKLan2.Models;

namespace NguyenDucCuong_GKLan2.Data
{
    public class NguyenDucCuong_GKLan2Context : DbContext
    {
        public NguyenDucCuong_GKLan2Context (DbContextOptions<NguyenDucCuong_GKLan2Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenDucCuong_GKLan2.Models.CongNhan> CongNhan { get; set; } = default!;
    }
}
