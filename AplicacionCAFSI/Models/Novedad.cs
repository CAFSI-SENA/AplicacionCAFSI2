using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Novedad
    {
        public int NovedadID { get; set; }
        public int TipoNovedadID { get; set; }
        public int ActivoID { get; set; }
        public DateTime FechaNovedad { get; set; }
        public string Observacion { get; set; }
        public int UsuarioID { get; set; }

        public virtual TipoNovedad TipoNovedad { get; set; }
        public virtual Activo Activo { get; set; }
        public virtual Usuario Usuario { get; set; }
        
    }
}