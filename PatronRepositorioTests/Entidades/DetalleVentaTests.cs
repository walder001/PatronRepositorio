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
    public class DetalleVentaTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<DetalleVenta> repositorio;
            repositorio = new RepositorioBase<DetalleVenta>();
            Assert.IsTrue(repositorio.Guardar(new DetalleVenta()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<DetalleVenta> repositorio;
            repositorio = new RepositorioBase<DetalleVenta>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<DetalleVenta> repositorio = new RepositorioBase<DetalleVenta>();
            DetalleVenta persona = new DetalleVenta()
            {
                IdDetalleVenta = 1,
                Venta_IdVenta = 1, Producto_IdProducto = 1,
                Unidades = 0.0,
                CostoUnidades = 0.0, DescuentoUnidad = 0.0,
                Total = 0.0
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<DetalleVenta> repositorio;
            repositorio = new RepositorioBase<DetalleVenta>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<DetalleVenta> repositorio;
            repositorio = new RepositorioBase<DetalleVenta>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}