using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Activo
    {
        public int ActivoID { get; set; }
        public string NombreActivo { get; set; }
        public int EstadoID { get; set; }
        public int CategoriaID { get; set; }
        public string NumeroSerie { get; set; }
        public int MarcaID { get; set; }
        public string Modelo { get; set; }
        public int TipoActivoID { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual TipoActivo TipoActivo { get; set; }

        public virtual ICollection<Novedad> Novedades { get; set; }
        //public virtual ICollection<Movimiento> Movimientos { get; set; }
        public virtual ICollection<DetalleActivo> DetalleActivos { get; set; }
    }
}