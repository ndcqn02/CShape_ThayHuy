using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCHelloWord.Models;

namespace MVCHelloWord.Data
{
    public class MVCHelloWordContext : DbContext
    {
        public MVCHelloWordContext (DbContextOptions<MVCHelloWordContext> options)
            : base(options)
        {
        }

        public DbSet<MVCHelloWord.Models.Movie> Movie { get; set; } = default!;
    }
}
