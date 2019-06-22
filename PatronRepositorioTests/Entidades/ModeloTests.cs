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
    public class ModeloTests
    {

        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Modelo> repositorio;
            repositorio = new RepositorioBase<Modelo>();
            Assert.IsTrue(repositorio.Guardar(new Modelo()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Modelo> repositorio;
            repositorio = new RepositorioBase<Modelo>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Modelo> repositorio = new RepositorioBase<Modelo>();
            Modelo persona = new Modelo()
            {
                IdModelo = 1,
                NombreModelo = "Prueba"
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Modelo> repositorio;
            repositorio = new RepositorioBase<Modelo>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Modelo> repositorio;
            repositorio = new RepositorioBase<Modelo>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }
    }
}