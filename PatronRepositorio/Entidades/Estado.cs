using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estados { get; set; }

        public Estado()
        {
            IdEstado = 0;
            FechaInicio = DateTime.Now;
            FechaFin = DateTime.Now;
            Estados = string.Empty;

        }
        public Estado(int idEstado, DateTime fechaInicio, DateTime fechaFin, string estado)
        {
            IdEstado = idEstado;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Estados = estado ?? throw new ArgumentNullException(nameof(estado));
        }
    }
}
