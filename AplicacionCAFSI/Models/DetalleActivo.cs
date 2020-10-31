using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class DetalleActivo
    {
        public int DetalleID { get; set; }
        public int ActivoID { get; set; }
        public string MemoriaRAM { get; set; } //CAmbiar modelo Entidad
        public string SistemaOperativo { get; set; }
        public string Procesador { get; set; }
        public string DiscoDuro { get; set; } //CAmbiar modelo Entidad
        public int EstadoID { get; set; }

        public virtual Activo Activo { get; set; }
        public virtual Estado Estado { get; set; }
    }
}