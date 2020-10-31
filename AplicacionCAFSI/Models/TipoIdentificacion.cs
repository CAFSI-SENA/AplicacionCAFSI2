using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class TipoIdentificacion
    {
        public int TipoIdentificacionID { get; set; }
        public string NombreTipo { get; set; }
        public int EstadoID { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}