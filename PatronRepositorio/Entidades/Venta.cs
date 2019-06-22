using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        public int Usuario_IdUsuario { get; set; }
        public int TipoCompobante_IdTipoPersona { get; set; }
        public DateTime FechaVenta { get; set; }
        public double SubTotal { get; set; }
        public double ConstoVenta { get; set; }
        public Venta()
        {
            IdVenta = 0;
            Usuario_IdUsuario = 0;
            TipoCompobante_IdTipoPersona = 0;
            FechaVenta = DateTime.Now;
            SubTotal = 0.0;
            ConstoVenta = 0.0;
        }
        public Venta(int idVenta, int usuario_IdUsuario, int tipoCompobante_IdTipoPersona, DateTime fechaVenta, double subTotal, double constoVenta)
        {
            IdVenta = idVenta;
            Usuario_IdUsuario = usuario_IdUsuario;
            TipoCompobante_IdTipoPersona = tipoCompobante_IdTipoPersona;
            FechaVenta = fechaVenta;
            SubTotal = subTotal;
            ConstoVenta = constoVenta;
        }
    }

}
