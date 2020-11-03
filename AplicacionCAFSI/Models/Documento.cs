using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Documento
    {
        public int DocumentoID { get; set; }
        public string NombreDocumento { get; set; }
        public byte DocCargue { get; set; }
        public int FuncionarioID { get; set; }
        public int MovimientoID { get; set; }
        public DateTime FechaCargue { get; set; }
        public int EstadoID { get; set; }
        public int UsuarioID { get; set; }

        //public virtual Funcionario Funcionario { get; set; }
        public virtual Movimiento Movimiento { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}