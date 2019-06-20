using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public int Usuario_IdUsiario { get; set; }
        public DateTime FechaCompra { get; set; }
        public int Proveedor_IdProveedor { get; set; }
        public int TipoComprobante_IdComprobante { get; set; }
        public double CostoCompra { get; set; }
        public Compra()
        {
            IdCompra = 0;
            Usuario_IdUsiario = 0;
            FechaCompra = DateTime.Now;
            Proveedor_IdProveedor = 0;
            TipoComprobante_IdComprobante = 0;
            CostoCompra = 0.0;
        }
        public Compra(int idCompra, int usuario_IdUsiario, DateTime fechaCompra, int proveedor_IdProveedor, int tipoComprobante_IdComprobante, double costoCompra)
        {
            IdCompra = idCompra;
            Usuario_IdUsiario = usuario_IdUsiario;
            FechaCompra = fechaCompra;
            Proveedor_IdProveedor = proveedor_IdProveedor;
            TipoComprobante_IdComprobante = tipoComprobante_IdComprobante;
            CostoCompra = costoCompra;
        }
    }
}
