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
    public class Usuario_Has_PermisoTests
    {

        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Usuario_Has_Permiso> repositorio;
            repositorio = new RepositorioBase<Usuario_Has_Permiso>();
            Assert.IsTrue(repositorio.Guardar(new Usuario_Has_Permiso()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Usuario_Has_Permiso> repositorio;
            repositorio = new RepositorioBase<Usuario_Has_Permiso>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuario_Has_Permiso> repositorio = new RepositorioBase<Usuario_Has_Permiso>();
            Usuario_Has_Permiso cargo = new Usuario_Has_Permiso()
            {
                Usuario_IdUsuario = 1,
                Permiso_IdPermiso = 1
            };

            Assert.IsTrue(repositorio.Modificar(cargo));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Usuario_Has_Permiso> repositorio;
            repositorio = new RepositorioBase<Usuario_Has_Permiso>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Usuario_Has_Permiso> repositorio;
            repositorio = new RepositorioBase<Usuario_Has_Permiso>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }
    }
}