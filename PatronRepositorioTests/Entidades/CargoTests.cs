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
    public class CargoTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Cargo> repositorio;
            repositorio = new RepositorioBase<Cargo>();
            Assert.IsTrue(repositorio.Guardar(new Cargo()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Cargo> repositorio;
            repositorio = new RepositorioBase<Cargo>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Cargo> repositorio = new RepositorioBase<Cargo>();
            Cargo cargo = new Cargo()
            {
                IdCargo = 2,
                NombreCargo = "AnalistaRedes",
                Estado_IdEstado = 1

            };

            Assert.IsTrue(repositorio.Modificar(cargo));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Cargo> repositorio;
            repositorio = new RepositorioBase<Cargo>();

            Assert.IsNotNull(repositorio.Buscar(2));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Cargo> repositorio;
            repositorio = new RepositorioBase<Cargo>();
            Assert.IsTrue(repositorio.Eliminar(2));
        }
    }
}