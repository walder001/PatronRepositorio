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
    public class ImagenTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Imagen> repositorio;
            repositorio = new RepositorioBase<Imagen>();
            Assert.IsTrue(repositorio.Guardar(new Imagen()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Imagen> repositorio;
            repositorio = new RepositorioBase<Imagen>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Imagen> repositorio = new RepositorioBase<Imagen>();
            Imagen persona = new Imagen()
            {
                IdImagen = 1,
                RutaImagen = "Prueba"
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Imagen> repositorio;
            repositorio = new RepositorioBase<Imagen>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Imagen> repositorio;
            repositorio = new RepositorioBase<Imagen>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}