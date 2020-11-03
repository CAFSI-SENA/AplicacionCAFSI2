using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Formulario
    {
        public int FormularioID { get; set; }
        public string NombreFormulario { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<FormularioPerfil> FormularioPerfiles { get; set; }
    }
}