using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class TipoMovimiento
    {
        public int TipoMovimientoID { get; set; }
        public string NombreTipo { get; set; }

        public virtual ICollection<Movimiento> Movimientos { get; set; }
    }
}