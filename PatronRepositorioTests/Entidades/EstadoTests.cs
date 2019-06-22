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
    public class EstadoTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Estado> repositorio;
            repositorio = new RepositorioBase<Estado>();
            Assert.IsTrue(repositorio.Guardar(new Estado()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Estado> repositorio;
            repositorio = new RepositorioBase<Estado>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Estado> repositorio = new RepositorioBase<Estado>();
            Estado persona = new Estado()
            {
                IdEstado = 1,
                FechaFin = DateTime.Now,
                FechaInicio = DateTime.Now,
                Estados = "Nuevo"
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Estado> repositorio;
            repositorio = new RepositorioBase<Estado>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Estado> repositorio;
            repositorio = new RepositorioBase<Estado>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}