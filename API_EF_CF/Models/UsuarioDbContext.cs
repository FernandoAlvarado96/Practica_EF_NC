using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_EF_CF.Models
{
    public class UsuarioDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options)
        {
            
        }
    }

    public class Usuario
    {
        public int UsuarioId { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellidos { get; set; }

        public byte Edad { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }
    }
}
