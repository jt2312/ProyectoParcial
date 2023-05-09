using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial1.Models;

namespace MvcUsuario.Data
{
    public class MvcUsuarioContext : DbContext
    {
        public MvcUsuarioContext (DbContextOptions<MvcUsuarioContext> options)
            : base(options)
        {
        }

        public DbSet<Parcial1.Models.Usuario> Usuario { get; set; } = default!;

        
    }
}
