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
    public class TipoPersonaTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<TipoPersona> repositorio;
            repositorio = new RepositorioBase<TipoPersona>();
            Assert.IsTrue(repositorio.Guardar(new TipoPersona()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<TipoPersona> repositorio;
            repositorio = new RepositorioBase<TipoPersona>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TipoPersona> repositorio = new RepositorioBase<TipoPersona>();
            TipoPersona persona = new TipoPersona()
            {
                IdTipoPersona = 1,
                Nombre = "Prueba"
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<TipoPersona> repositorio;
            repositorio = new RepositorioBase<TipoPersona>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<TipoPersona> repositorio;
            repositorio = new RepositorioBase<TipoPersona>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}