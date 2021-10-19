using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API_EF_CF.Models;

namespace API_EF_CF.Models
{
    public class TipoUsuarioDbContext : DbContext
    {
        public TipoUsuario TipoUsuario { get; set; }

        public TipoUsuarioDbContext(DbContextOptions<TipoUsuarioDbContext> options) : base(options)
        {

        }

        public DbSet<API_EF_CF.Models.TipoUsuario> TipoUsuario_1 { get; set; }
    }

    public class TipoUsuario
    {
        public byte TipoUsuarioId { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; } = true;
    }
}
