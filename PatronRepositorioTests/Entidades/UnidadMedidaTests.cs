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
    public class UnidadMedidaTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<UnidadMedida> repositorio;
            repositorio = new RepositorioBase<UnidadMedida>();
            Assert.IsTrue(repositorio.Guardar(new UnidadMedida()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<UnidadMedida> repositorio;
            repositorio = new RepositorioBase<UnidadMedida>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<UnidadMedida> repositorio = new RepositorioBase<UnidadMedida>();
            UnidadMedida persona = new UnidadMedida()
            {
                IdUnidadMedida = 1,
                NombreUnidad = "Prueba"
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<UnidadMedida> repositorio;
            repositorio = new RepositorioBase<UnidadMedida>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<UnidadMedida> repositorio;
            repositorio = new RepositorioBase<UnidadMedida>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}