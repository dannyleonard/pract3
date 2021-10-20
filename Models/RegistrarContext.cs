using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace efdemo.Models
{
    public class RegistrarContext : DbContext
    {
        public DbSet<RegistrarProducto> RegistrosProductos { get; set; }
        public DbSet<SolicitudCompra> SolicitudesCompras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public RegistrarContext(DbContextOptions dco) : base(dco) {

        }
    }
}