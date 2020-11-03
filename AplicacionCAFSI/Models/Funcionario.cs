using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public enum Vigente
    {
        SI,NO
    }
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int TipoIdentificacionID { get; set; }
        public string Identificacion { get; set; }
        public Vigente Vigente { get; set; }
        public int AreaID { get; set; }
        public int GeneroID { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual TipoIdentificacion TipoIdentificacion { get; set; }
        public virtual Area Area { get; set; }
        public virtual Genero Genero { get; set; }

        //public virtual ICollection<Movimiento> Movimientos { get; set; }
        //public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}