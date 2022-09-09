using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeliculasCategoria.Models;

namespace PeliculasCategoria.Data
{
    public class PeliculasCategoriaContext : DbContext
    {
        public PeliculasCategoriaContext (DbContextOptions<PeliculasCategoriaContext> options)
            : base(options)
        {
        }

        public DbSet<PeliculasCategoria.Models.Categoria> Categoria { get; set; }
    }
}
