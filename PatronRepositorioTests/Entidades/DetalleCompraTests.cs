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
    public class DetalleCompraTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<DetalleCompra> repositorio;
            repositorio = new RepositorioBase<DetalleCompra>();
            Assert.IsTrue(repositorio.Guardar(new DetalleCompra()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<DetalleCompra> repositorio;
            repositorio = new RepositorioBase<DetalleCompra>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<DetalleCompra> repositorio = new RepositorioBase<DetalleCompra>();
            DetalleCompra persona = new DetalleCompra()
            {
                IdDeatalleCompra = 1,
                Compra_IdCompra = 1,
                Producto_IdProducto = 1,
                Unidades = 0.0,
                CostoUnidad = 0.0,
                Total = 0.0
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<DetalleCompra> repositorio;
            repositorio = new RepositorioBase<DetalleCompra>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<DetalleCompra> repositorio;
            repositorio = new RepositorioBase<DetalleCompra>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}