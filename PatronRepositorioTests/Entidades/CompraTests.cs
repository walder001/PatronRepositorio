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
    public class CompraTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Compra> repositorio;
            repositorio = new RepositorioBase<Compra>();
            Assert.IsTrue(repositorio.Guardar(new Compra()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Compra> repositorio;
            repositorio = new RepositorioBase<Compra>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Compra> repositorio = new RepositorioBase<Compra>();
            Compra persona = new Compra()
            {
               IdCompra = 1,
               Usuario_IdUsiario = 1,
               FechaCompra = DateTime.Now,
               Proveedor_IdProveedor = 1,
               TipoComprobante_IdComprobante = 1,
               CostoCompra = 1.1
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Compra> repositorio;
            repositorio = new RepositorioBase<Compra>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Compra> repositorio;
            repositorio = new RepositorioBase<Compra>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}