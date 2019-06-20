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
    public class UsuarioTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Usuario> repositorio;
            repositorio = new RepositorioBase<Usuario>();
            Assert.IsTrue(repositorio.Guardar(new Usuario()));


        }
        
    }
}