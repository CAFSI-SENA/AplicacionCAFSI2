using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Genero
    {
        public int GeneroID { get; set; }
        public string NombreGenero { get; set; }
        public int EstadoID { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}