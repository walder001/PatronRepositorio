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
    public class PermisoTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Permiso> repositorio;
            repositorio = new RepositorioBase<Permiso>();
            Assert.IsTrue(repositorio.Guardar(new Permiso()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Permiso> repositorio;
            repositorio = new RepositorioBase<Permiso>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Permiso> repositorio = new RepositorioBase<Permiso>();
            Permiso persona = new Permiso()
            {
                IdPermiso = 1,
                Descripcion = "Administrador",
                Funcionalidad = "Prueba",
               
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Permiso> repositorio;
            repositorio = new RepositorioBase<Permiso>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Permiso> repositorio;
            repositorio = new RepositorioBase<Permiso>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}