using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class FormularioPerfil
    {
        public int PerfilID { get; set; }
        public int FormularioID { get; set; }
        public int EstadoID { get; set; }
        public DateTime FechaAsignacion { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual Formulario Formulario { get; set; }
        public virtual Estado Estado { get; set; }
    }
}