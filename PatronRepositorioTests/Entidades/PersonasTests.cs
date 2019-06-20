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
    public class PersonasTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Assert.IsTrue(repositorio.Guardar(new Personas()));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Assert.IsTrue(repositorio.Modificar<Personas>(new Personas(2,"Walder","De Jesus","Reyes",DateTime.Now,"8091232123","Walder@walder.com","M",1,"Libertad",1)));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();

            Assert.IsNotNull(repositorio.Buscar<Personas>(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }
        
    }
}