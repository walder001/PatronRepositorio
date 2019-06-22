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
    public class TipoComprobanteTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<TipoComprobante> repositorio;
            repositorio = new RepositorioBase<TipoComprobante>();
            Assert.IsTrue(repositorio.Guardar(new TipoComprobante()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<TipoComprobante> repositorio;
            repositorio = new RepositorioBase<TipoComprobante>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TipoComprobante> repositorio = new RepositorioBase<TipoComprobante>();
            TipoComprobante persona = new TipoComprobante()
            {
                IdTipoComprobante = 1,
                NombreComprobante = "Prueba"
              
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<TipoComprobante> repositorio;
            repositorio = new RepositorioBase<TipoComprobante>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<TipoComprobante> repositorio;
            repositorio = new RepositorioBase<TipoComprobante>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}