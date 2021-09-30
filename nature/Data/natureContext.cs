using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using nature;

    public class natureContext : DbContext
    {
        public natureContext (DbContextOptions<natureContext> options)
            : base(options)
        {
        }

        public DbSet<nature.natureProgramme> natureProgramme { get; set; }
    }
