using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public string NombreMenu { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<MenuPerfil> MenuPerfiles { get; set; }
    }
}