using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KCT.Models;
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace KCT.Data
{
    public class KCTContext :DbContext
=======

namespace KCT.Data
{
    public class KCTContext : DbContext
>>>>>>> e921331a01c8b0482a7dbd1bc7ed060f1262c5d3
    {
        public KCTContext (DbContextOptions<KCTContext> options)
            : base(options)
        {
        }

<<<<<<< HEAD
        public DbSet<KCT.Models.Student> Students { get; set; }

        public DbSet<KCT.Models.Registration> Registrations { get; set; }

=======
        public DbSet<KCT.Models.StudentViewModel> StudentViewModel { get; set; } = default!;
>>>>>>> e921331a01c8b0482a7dbd1bc7ed060f1262c5d3
    }
}
