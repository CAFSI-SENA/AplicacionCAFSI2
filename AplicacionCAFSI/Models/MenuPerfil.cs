using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class MenuPerfil
    {
        public int MenuPerfilID { get; set; }
        public int MenuID { get; set; }
        public int PerfilID { get; set; }
        public int EstadoID { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int MenuPadreID { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual Estado Estado { get; set; }
    }
}