using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class DetalleCompra
    {
        [Key]
        public int IdDeatalleCompra { get; set; }
        public int Compra_IdCompra { get; set; }
        public int Producto_IdProducto { get; set; }
        public double Unidades { get; set; }
        public double CostoUnidad { get; set; }
        public double Total { get; set; }

        public DetalleCompra()
        {
            IdDeatalleCompra = 0;
            Compra_IdCompra = 0;
            Producto_IdProducto = 0;
            Unidades = 0.0;
            CostoUnidad = 0.0;
            Total = 0.0;
        }
        public DetalleCompra(int idDeatalleCompra, int compra_IdCompra, int producto_IdProducto, double unidades, double costoUnidad, double total)
        {
            IdDeatalleCompra = idDeatalleCompra;
            Compra_IdCompra = compra_IdCompra;
            Producto_IdProducto = producto_IdProducto;
            Unidades = unidades;
            CostoUnidad = costoUnidad;
            Total = total;
        }
    }
}
