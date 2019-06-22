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
    public class MarcaTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Marca> repositorio;
            repositorio = new RepositorioBase<Marca>();
            Assert.IsTrue(repositorio.Guardar(new Marca()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Marca> repositorio;
            repositorio = new RepositorioBase<Marca>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Marca> repositorio = new RepositorioBase<Marca>();
            Marca persona = new Marca()
            {
                IdMarca = 1,
                NombreMarca = "Prueba"
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Marca> repositorio;
            repositorio = new RepositorioBase<Marca>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Marca> repositorio;
            repositorio = new RepositorioBase<Marca>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}