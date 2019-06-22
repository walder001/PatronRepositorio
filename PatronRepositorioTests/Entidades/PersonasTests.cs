using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class PersonasTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Assert.IsTrue(repositorio.Guardar(new Personas()));
        }
     
        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Personas> repositorio = new RepositorioBase<Personas>();
            Personas persona = new Personas()
            {
                IdPersona = 1,
                DNI = 1,
                Nombre = "nombre2",
                Materno = "prueba2",
                Paterno = "prueba",
                FechaNacimiento = DateTime.Now,
                Telefono = "222222",
                Correo = "Prueba@",
                Sexo = "M",
                Direccion = "prueba",
                Imagen_IdImagen = 0,
                TipoPersona_IdPersona = 1
            };

            Assert.IsTrue(repositorio.Modificar(persona));

          
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }



    }
}