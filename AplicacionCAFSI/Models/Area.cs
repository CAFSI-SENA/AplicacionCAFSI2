using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Area
    {
        public int AreaID { get; set; }
        public string NombreArea { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int EstadoID { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual ICollection<Funcionario> Funcionario { get; set; }
        public virtual ICollection<Activo> Activo { get; set; }
    }
}