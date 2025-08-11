using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KCT.Models;

namespace KCT.Data
{
    public class KCTContext : DbContext
    {
        public KCTContext (DbContextOptions<KCTContext> options)
            : base(options)
        {
        }

        public DbSet<KCT.Models.StudentViewModel> StudentViewModel { get; set; } = default!;
    }
}
