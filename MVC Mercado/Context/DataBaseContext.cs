using MVC_Mercado.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVC_Mercado.Context
{
    public class SCContext : DbContext
    {
        public SCContext(DbContextOptions<SCContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
    }
}
