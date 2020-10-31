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

        public virtual ICollection<Categoria> Categoria { get; set; }
        public virtual ICollection<TipoActivo> TipoBaja { get; set; }
        public virtual ICollection<Marca> Marca { get; set; }
        public virtual ICollection<Documento> Documento { get; set; }
        public virtual ICollection<Novedad> Novedad { get; set; }
        public virtual ICollection<TipoNovedad> TipoNovedad { get; set; }
        public virtual ICollection<Movimiento> Movimiento { get; set; }
        public virtual ICollection<TipoMovimiento> TipoMovimiento { get; set; }
        public virtual ICollection<Area> Area { get; set; }
        public virtual ICollection<TipoIdentificacion> TipoIdentificacion { get; set; }
        public virtual ICollection<Genero> Genero { get; set; }
        public virtual ICollection<MenuPerfil> MenuPerfil { get; set; }
        public virtual ICollection<Perfil> Perfil { get; set; }
        public virtual ICollection<FormularioPerfil> FormularioPerfil { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}