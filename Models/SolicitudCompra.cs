using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace efdemo.Models
{
    public class SolicitudCompra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Nomprod { get; set; }
        public string Fotoprod { get; set; }
        public string Descprod { get; set; }
        public string Precioprod { get; set; }
        public string Celular { get; set; }
        public string Lugar { get; set; }
        public string Nomcomp { get; set; }
        public string Categoriaprod { get; set; }
        public Usuario Usuario { get; set; }

        // Shadow property
        public int? UsuarioId { get; set; }

        public SolicitudCompra()
        {
            Fecha = DateTime.Now;
        }
    }
}