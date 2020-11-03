using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.Models
{
    public class Estado
    {
        public int EstadoID { get; set; }
        public string NombreEstado { get; set; }

        //public virtual ICollection<Categoria> Categorias { get; set; }
        //public virtual ICollection<TipoActivo> TipoBajas { get; set; }
        //public virtual ICollection<Marca> Marcas { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<Novedad> Novedades { get; set; }
        //public virtual ICollection<TipoNovedad> TipoNovedades { get; set; }
        //public virtual ICollection<Movimiento> Movimientos { get; set; }
        public virtual ICollection<TipoMovimiento> TipoMovimientos { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        //public virtual ICollection<TipoIdentificacion> TipoIdentificaciones { get; set; }
        //public virtual ICollection<Genero> Generos { get; set; }
        public virtual ICollection<MenuPerfil> MenuPerfiles { get; set; }
        //public virtual ICollection<Perfil> Perfiles { get; set; }
        public virtual ICollection<FormularioPerfil> FormularioPerfiles { get; set; }
        //public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}