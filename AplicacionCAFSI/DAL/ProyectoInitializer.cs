using AplicacionCAFSI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionCAFSI.DAL
{
    public class ProyectoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProyectoContext>
    {
        protected override void Seed(ProyectoContext context)
        {
            var estados = new List<Estado>
            {
                 new Estado{NombreEstado="ACTIVO"},
                 new Estado{NombreEstado="ACTIVO NO"},
                 new Estado{NombreEstado="ELIMINADO"}
            };
            estados.ForEach(s => context.Estados.Add(s));
            context.SaveChanges();

            var generos = new List<Genero>
            {
                new Genero{NombreGenero="MASCULINO"},
                new Genero{NombreGenero="FEMENINO"}
            };
            generos.ForEach(s => context.Generos.Add(s));
            context.SaveChanges();

            var marcas = new List<Marca>
            {
                new Marca{NombreMarca="COMPAQ"},
                new Marca{NombreMarca="HP"},
                new Marca{NombreMarca="DELL"},
                new Marca{NombreMarca="LENOVO"}
            };
            marcas.ForEach(s => context.Marcas.Add(s));
            context.SaveChanges();

            var tipoactivos = new List<TipoActivo>
            {
                new TipoActivo{NombreTipo="COMPUTADOR",EstadoID=1},
                new TipoActivo{NombreTipo="VIDEOBEAM", EstadoID=1}
            };
            tipoactivos.ForEach(s => context.TipoActivos.Add(s));
            context.SaveChanges();

            var tipoidentificaciones = new List<TipoIdentificacion>
            {
                new TipoIdentificacion{NombreTipo="CEDULA CIUDADANIA",Sigla="CC",EstadoID=1},
                new TipoIdentificacion{NombreTipo="CEDULA EXTRANJERIA",Sigla="CE",EstadoID=1},
                new TipoIdentificacion{NombreTipo="TARJETA IDENTIDAD",Sigla="TI",EstadoID=1}
            };
            tipoidentificaciones.ForEach(s => context.TipoIdentificaciones.Add(s));
            context.SaveChanges();

            var tipomovimientos = new List<TipoMovimiento>
            {
                new TipoMovimiento{NombreTipo="ASIGNACION"},
                new TipoMovimiento{NombreTipo="PRESTAMO"}
            };
            tipomovimientos.ForEach(s => context.TipoMovimientos.Add(s));
            context.SaveChanges();

            var tiponovedades = new List<TipoNovedad>
            {
                new TipoNovedad{NombreTipo="BAJA",EstadoID=1},
                new TipoNovedad{NombreTipo="PERDIDA",EstadoID=1}
            };
            tiponovedades.ForEach(s => context.TipoNovedades.Add(s));
            context.SaveChanges();

            var areas = new List<Area>
            {
                new Area{NombreArea="AREA FINANCIERA",FechaCreacion=DateTime.Parse("12/04/2020"),EstadoID=1},
                new Area{NombreArea="AREA CONTRATOS",FechaCreacion=DateTime.Parse("20/04/2020"),EstadoID=1}
            };
            areas.ForEach(s => context.Areas.Add(s));
            context.SaveChanges();

            var categorias = new List<Categoria>
            {
                new Categoria{NombreCategoria="COMPUTO",EstadoID=1,FechaCreacion=DateTime.Parse("09/08/2020")},
                new Categoria{NombreCategoria="AUDIOVISUALES",EstadoID=1,FechaCreacion=DateTime.Parse("12/08/2020")}
            };
            categorias.ForEach(s => context.Categorias.Add(s));
            context.SaveChanges();

            var funcionarios = new List<Funcionario>
            {
                new Funcionario{Nombres="DEIVY ELIVER",Apellidos="RODRIGUEZ ORTEGA",TipoIdentificacionID=1,Identificacion="10696738",Vigente=Vigente.SI,AreaID=1,GeneroID=1,Telefono="3095584",Celular="3113214598",FechaCreacion=DateTime.Parse("13/10/2020")},
                new Funcionario{Nombres="MICHAEL STIVEN",Apellidos="DUQUE PALENCIA",TipoIdentificacionID=1,Identificacion="1054321876",Vigente=Vigente.SI,AreaID=2,GeneroID=1,Telefono="3023584",Celular="3140945984",FechaCreacion=DateTime.Parse("13/10/2020")}
            };
            funcionarios.ForEach(s => context.Funcionarios.Add(s));
            context.SaveChanges();

            var perfiles = new List<Perfil>
            {
                new Perfil{NombrePerfil="Auxiliar",EstadoID=1,FechaCreacion=DateTime.Parse("25/10/2020")},
                new Perfil{NombrePerfil="Admin ",EstadoID=1,FechaCreacion=DateTime.Parse("25/10/2020")},
                new Perfil{NombrePerfil="Bodega",EstadoID=1,FechaCreacion=DateTime.Parse("25/10/2020")}
            };
            perfiles.ForEach(s => context.Perfiles.Add(s));
            context.SaveChanges();

            var usuarios = new List<Usuario>
            {
                new Usuario{NombreUsuario="michael.duque",FuncionarioID=2,PerfilID=1,FechaCreacion=DateTime.Parse("31/10/2020")}
            };
            usuarios.ForEach(s => context.Usuarios.Add(s));
            context.SaveChanges();

            var activos = new List<Activo>
            {
                new Activo{NombreActivo="averiguar",EstadoID=1,CategoriaID=2,NumeroSerie="abcd1234",MarcaID=3,Modelo="PEPITO",TipoActivoID=2,FechaAdquisicion=DateTime.Parse("15/01/2020"),FechaCreacion=DateTime.Parse("01/05/2020")},
                new Activo{NombreActivo="averiguar2",EstadoID=1,CategoriaID=1,NumeroSerie="abcdab4",MarcaID=2,Modelo="PEREZ",TipoActivoID=1,FechaAdquisicion=DateTime.Parse("15/01/2020"),FechaCreacion=DateTime.Parse("01/05/2020")}
            };
            activos.ForEach(s => context.Activos.Add(s));
            context.SaveChanges();

            var movimientos = new List<Movimiento> 
            {
                new Movimiento{TipoMovimientoID=1,FuncionarioID=1,ActivoID=2,FechaInicio=DateTime.Parse("8/9/2020"),EstadoID=1},
                new Movimiento{TipoMovimientoID=2,FuncionarioID=2,ActivoID=1,FechaInicio=DateTime.Parse("11/9/2020"),EstadoID=1}
            };
            movimientos.ForEach(s => context.Movimientos.Add(s));
            context.SaveChanges();

            var novedades = new List<Novedad>
            {
                new Novedad{TipoNovedadID=2,ActivoID=1,FechaNovedad=DateTime.Parse("01/11/2020"),UsuarioID=1}
            };
            novedades.ForEach(s => context.Novedades.Add(s));
            context.SaveChanges();
        }

    }
}