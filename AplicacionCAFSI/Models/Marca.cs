using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Marca
    {
        public int MarcaID { get; set; }
        public string NombreMarca { get; set; }
        public int EstadoID { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual ICollection<Activo> Activo { get; set; }
    }
}