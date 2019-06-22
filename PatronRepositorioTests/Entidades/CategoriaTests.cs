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
    public class CategoriaTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Categoria> repositorio;
            repositorio = new RepositorioBase<Categoria>();
            Assert.IsTrue(repositorio.Guardar(new Categoria()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Categoria> repositorio;
            repositorio = new RepositorioBase<Categoria>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Categoria> repositorio = new RepositorioBase<Categoria>();
            Categoria persona = new Categoria()
            {
                IdCategoria = 1,
                NombreCategoria = "Prueba",
                Descripcion = "Prueba"
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Categoria> repositorio;
            repositorio = new RepositorioBase<Categoria>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Categoria> repositorio;
            repositorio = new RepositorioBase<Categoria>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}