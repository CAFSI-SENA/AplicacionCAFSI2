using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public byte Contrasenia { get; set; }
        public int FuncionarioID { get; set; }
        public int PerfilID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int EstadoID { get; set; }

        //public virtual Funcionario Funcionario { get; set; }
        public virtual Perfil Perfil { get; set; }
        //public virtual Estado Estado { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<Novedad> Novedades { get; set; }

    }
}