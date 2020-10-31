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
            var generos = new List<Genero>
            {
                new Genero{NombreGenero="MASCULINO"},
                new Genero{NombreGenero="FEMENINO"}
            };
            var marcas = new List<Marca>
            {
                new Marca{NombreMarca="COMPAQ"},
                new Marca{NombreMarca="HP"},
                new Marca{NombreMarca="DELL"},
                new Marca{NombreMarca="LENOVO"}
            };
            var activos = new List<Activo>
            {
                new Activo{NombreActivo="averiguar",EstadoID=1,CategoriaID=2,NumeroSerie="abcd1234",MarcaID=3,Modelo=""}
            };
        }

    }
}