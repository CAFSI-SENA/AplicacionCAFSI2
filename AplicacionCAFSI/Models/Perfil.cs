using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Perfil
    {
        public int PerfilID { get; set; }
        public string NombrePerfil { get; set; }
        public int EstadoID { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
        public virtual ICollection<MenuPerfil> MenuPerfil { get; set; }
        public virtual ICollection<FormularioPerfil> FormularioPerfil { get; set; }
    }
}