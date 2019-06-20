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
    public class ProveedorTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Proveedor> repositorio;
            repositorio = new RepositorioBase<Proveedor>();
            Assert.IsTrue(repositorio.Guardar(new Proveedor()));
        }
    }
}