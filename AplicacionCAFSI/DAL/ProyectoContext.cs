using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using AplicacionCAFSI.Models;

namespace AplicacionCAFSI.DAL
{
    public class ProyectoContext : DbContext
    {
        public ProyectoContext() : base("ProyectoContext")
        {            
        }
        public DbSet<Activo> Activos { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetalleActivo> DetalleActivos { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<FormularioPerfil> FormularioPerfiles { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuPerfil> MenuPerfiles { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<Novedad> Novedades { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<TipoActivo> TipoActivos { get; set; }
        public DbSet<TipoIdentificacion> TipoIdentificaciones { get; set; }
        public DbSet<TipoMovimiento> TipoMovimientos { get; set; }
        public DbSet<TipoNovedad> TipoNovedades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}