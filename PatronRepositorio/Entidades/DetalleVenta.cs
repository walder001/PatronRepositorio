using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
   public class DetalleVenta
    {
        [Key]
        public int IdDetalleVenta { get; set; }
        public int Venta_IdVenta { get; set; }
        public int Producto_IdProducto { get; set; }
        public double Unidades { get; set; }
        public double CostoUnidades { get; set; }
        public double DescuentoUnidad { get; set; }
        public double Total { get; set; }
        public DetalleVenta()
        {
            IdDetalleVenta = 0;
            Venta_IdVenta = 0;
            Producto_IdProducto = 0;
            Unidades = 0.0;
            CostoUnidades = 0.0;
            DescuentoUnidad = 0.0;
            Total = 0.0;
        }

        public DetalleVenta(int idDetalleVenta, int venta_IdVenta, int producto_IdProducto, double unidades, double costoUnidades, double descuentoUnidad, double total)
        {
            IdDetalleVenta = idDetalleVenta;
            Venta_IdVenta = venta_IdVenta;
            Producto_IdProducto = producto_IdProducto;
            Unidades = unidades;
            CostoUnidades = costoUnidades;
            DescuentoUnidad = descuentoUnidad;
            Total = total;
        }
    }
}
