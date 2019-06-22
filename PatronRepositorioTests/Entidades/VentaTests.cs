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
    public class VentaTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Venta> repositorio;
            repositorio = new RepositorioBase<Venta>();
            Assert.IsTrue(repositorio.Guardar(new Venta()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Venta> repositorio;
            repositorio = new RepositorioBase<Venta>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Venta> repositorio = new RepositorioBase<Venta>();
            Venta persona = new Venta()
            {
                IdVenta = 1,
                Usuario_IdUsuario = 1,
                TipoCompobante_IdTipoPersona = 1,
                FechaVenta = DateTime.Now,
                SubTotal = 0.0,
                ConstoVenta = 0.0


            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Venta> repositorio;
            repositorio = new RepositorioBase<Venta>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Venta> repositorio;
            repositorio = new RepositorioBase<Venta>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }
        [TestMethod()]
        public void Guardarr()
        {
            RepositorioBase<Venta> repositorio;
            repositorio = new RepositorioBase<Venta>();
            Assert.IsTrue(repositorio.Guardar(new Venta()));
        }

        [TestMethod()]
        public void GetListt()
        {
            RepositorioBase<Venta> repositorio;
            repositorio = new RepositorioBase<Venta>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTestt()
        {
            RepositorioBase<Venta> repositorio = new RepositorioBase<Venta>();
            Venta persona = new Venta()
            {
                IdVenta = 1,
                Usuario_IdUsuario = 1,
                TipoCompobante_IdTipoPersona = 1,
                FechaVenta = DateTime.Now,
                SubTotal = 0.0,
                ConstoVenta = 0.0


            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscarr()
        {
            RepositorioBase<Venta> repositorio;
            repositorio = new RepositorioBase<Venta>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminarr()
        {
            RepositorioBase<Venta> repositorio;
            repositorio = new RepositorioBase<Venta>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}