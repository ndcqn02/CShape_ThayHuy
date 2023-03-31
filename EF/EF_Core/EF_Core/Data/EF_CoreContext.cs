using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EF_Core.Models;

namespace EF_Core.Data
{
    public class EF_CoreContext : DbContext
    {
        public EF_CoreContext (DbContextOptions<EF_CoreContext> options)
            : base(options)
        {
        }

        public DbSet<EF_Core.Models.Student> Student { get; set; } = default!;
    }
}
