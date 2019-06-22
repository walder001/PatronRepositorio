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
    public class ProductoTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Producto> repositorio;
            repositorio = new RepositorioBase<Producto>();
            Assert.IsTrue(repositorio.Guardar(new Producto()));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Producto> repositorio;
            repositorio = new RepositorioBase<Producto>();
            Assert.IsNotNull(repositorio.GetList(p => true));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Producto> repositorio = new RepositorioBase<Producto>();
            Producto persona = new Producto()
            {
                IdProdicto = 1,
                Nombre = "Prueba",
                Descripcion = "Prueba",
                FechaFabricacion = DateTime.Now,
                 CostoCompra = 0.0,
                 Stock = 0.0,
                 UnidadMedida_IdUnidadMendida = 1,
                 Imagen_IdImagen = 1,
                 Categoria_IdCategoria = 1,
                 Marca_IdMarca = 1,
                 Modelo_IdModelo = 1

               
            };

            Assert.IsTrue(repositorio.Modificar(persona));


        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Producto> repositorio;
            repositorio = new RepositorioBase<Producto>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Producto> repositorio;
            repositorio = new RepositorioBase<Producto>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

    }
}