using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
   public class Producto
    {
        [Key]
        public int IdProdicto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion  { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public double CostoCompra { get; set; }
        public double Stock { get; set; }
        public int UnidadMedida_IdUnidadMendida { get; set; }
        public int Imagen_IdImagen { get; set; }
        public int Categoria_IdCategoria { get; set; }
        public int Marca_IdMarca { get; set; }
        public int Modelo_IdModelo  { get; set; }

        public Producto()
        {
            IdProdicto = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            FechaFabricacion = DateTime.Now;
            CostoCompra = 0.0;
            Stock = 0.0;
            UnidadMedida_IdUnidadMendida = 0;
            Imagen_IdImagen = 0;
            Categoria_IdCategoria = 0;
            Marca_IdMarca = 0;
            Modelo_IdModelo = 0;
        }
        public Producto(int idProdicto, string nombre, string descripcion, DateTime fechaFabricacion, double costoCompra, double stock, int unidadMedida_IdUnidadMendida, int imagen_IdImagen, int categoria_IdCategoria, int marca_IdMarca, int modelo_IdModelo)
        {
            IdProdicto = idProdicto;
            Nombre = nombre;
            Descripcion = descripcion;
            FechaFabricacion = fechaFabricacion;
            CostoCompra = costoCompra;
            Stock = stock;
            UnidadMedida_IdUnidadMendida = unidadMedida_IdUnidadMendida;
            Imagen_IdImagen = imagen_IdImagen;
            Categoria_IdCategoria = categoria_IdCategoria;
            Marca_IdMarca = marca_IdMarca;
            Modelo_IdModelo = modelo_IdModelo;
        }
    }

}

