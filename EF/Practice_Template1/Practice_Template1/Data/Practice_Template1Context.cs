using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practice_Template1.Models;

namespace Practice_Template1.Data
{
    public class Practice_Template1Context : DbContext
    {
        public Practice_Template1Context (DbContextOptions<Practice_Template1Context> options)
            : base(options)
        {
        }

        public DbSet<Practice_Template1.Models.Product> Product { get; set; } = default!;

        public DbSet<Practice_Template1.Models.Category> Category { get; set; } = default!;
    }
}
