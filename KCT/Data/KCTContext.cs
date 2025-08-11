using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KCT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace KCT.Data
{
    public class KCTContext :DbContext
    {
        public KCTContext (DbContextOptions<KCTContext> options)
            : base(options)
        {
        }

        public DbSet<KCT.Models.Student> Students { get; set; }

        public DbSet<KCT.Models.Registration> Registrations { get; set; }

    }
}
