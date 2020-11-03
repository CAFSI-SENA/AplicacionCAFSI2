using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Movimiento
    {
        public int MovimientoID { get; set; }
        public int TipoMovimientoID { get; set; }
        public int FuncionarioID { get; set; }
        public int ActivoID { get; set; }
        public DateTime FechaInicio { get; set; } 
        public DateTime FechaFin { get; set; }
        public string Observacion { get; set; }
        public int EstadoID { get; set; }

        public virtual TipoMovimiento TipoMovimiento { get; set; }
        //public virtual Funcionario Funcionario { get; set; }
        //public virtual Activo Activo { get; set; }
        //public virtual Estado Estado { get; set; }
    }
}