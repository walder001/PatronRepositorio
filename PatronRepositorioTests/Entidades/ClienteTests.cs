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
    public class ClienteTests
    {

        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Cliente> repositorio;
            repositorio = new RepositorioBase<Cliente>();
            Assert.IsTrue(repositorio.Guardar(new Cliente()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Cliente> repositorio;
            repositorio = new RepositorioBase<Cliente>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Cliente> repositorio = new RepositorioBase<Cliente>();
            Cliente persona = new Cliente()
            {
                ClienteId = 1,
                PersonaId = 1,
              


            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Cliente> repositorio;
            repositorio = new RepositorioBase<Cliente>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Cliente> repositorio;
            repositorio = new RepositorioBase<Cliente>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }
       
    }
}