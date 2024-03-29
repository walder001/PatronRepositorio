﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Usuario> repositorio;
            repositorio = new RepositorioBase<Usuario>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
            Usuario persona = new Usuario()
            {
                IdUsuario = 1,
                Empleado_IdEmpleado = 1,
                NombreUsuario = "Prueba",
                Clave = "123"
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Usuario> repositorio;
            repositorio = new RepositorioBase<Usuario>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Usuario> repositorio;
            repositorio = new RepositorioBase<Usuario>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}