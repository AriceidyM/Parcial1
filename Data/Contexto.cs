using Microsoft.EntityFrameworkCore;
using rParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rParcial.Data
{
    public class Contexto: DbContext
    {
        public DbSet<Usuarios> usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=.\SqlExpress;Database=ParcialDb;trusted_Connection =true"));
        }
    }
}
