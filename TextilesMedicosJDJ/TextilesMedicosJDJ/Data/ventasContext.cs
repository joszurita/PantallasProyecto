using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TextilesMedicosJDJ.Models;

namespace TextilesMedicosJDJ.Data
{
    public class ventasContext : DbContext
    {
        public ventasContext (DbContextOptions<ventasContext> options)
            : base(options)
        {
        }

        public DbSet<ventas> ventas { get; set; }

        public DbSet<Carrito> Carrito { get; set; }
    }
}
