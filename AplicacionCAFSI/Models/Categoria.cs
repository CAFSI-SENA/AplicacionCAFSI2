using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string NombreCategoria { get; set; }
        public int EstadoID { get; set; }
        public DateTime FechaCreacion { get; set; }

        //public virtual Estado Estado { get; set; }
        public virtual ICollection<Activo> Activos { get; set; }
    }
}