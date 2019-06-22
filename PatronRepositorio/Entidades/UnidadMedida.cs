using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class UnidadMedida
    {
        [Key]
        public int IdUnidadMedida { get; set; }
        public string NombreUnidad { get; set; }

        public UnidadMedida()
        {
            IdUnidadMedida = 0;
            NombreUnidad = string.Empty;
        }
        public UnidadMedida(int idUnidadMedida, string nombreUnidad)
        {
            IdUnidadMedida = idUnidadMedida;
            NombreUnidad = nombreUnidad;
        }
    }
}
