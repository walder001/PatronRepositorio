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
    public class EmpleadoTests
    {

        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Empleado> repositorio;
            repositorio = new RepositorioBase<Empleado>();
            Assert.IsTrue(repositorio.Guardar(new Empleado()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Empleado> repositorio;
            repositorio = new RepositorioBase<Empleado>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Empleado> repositorio = new RepositorioBase<Empleado>();
            Empleado persona = new Empleado()
            {
               IdEmpleado = 1,
               Persona_IdPersona = 1
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Empleado> repositorio;
            repositorio = new RepositorioBase<Empleado>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Empleado> repositorio;
            repositorio = new RepositorioBase<Empleado>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}