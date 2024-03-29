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
    public class ProveedorTests
    {

        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Proveedor> repositorio;
            repositorio = new RepositorioBase<Proveedor>();
            Assert.IsTrue(repositorio.Guardar(new Proveedor()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Proveedor> repositorio;
            repositorio = new RepositorioBase<Proveedor>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Proveedor> repositorio = new RepositorioBase<Proveedor>();
            Proveedor proveedor = new Proveedor()
            {
                IdProveedor = 1,
                Persona_IdPersona = 1
            };

            Assert.IsTrue(repositorio.Modificar(proveedor));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Proveedor> repositorio;
            repositorio = new RepositorioBase<Proveedor>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Proveedor> repositorio;
            repositorio = new RepositorioBase<Proveedor>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}