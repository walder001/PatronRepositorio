using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Marca
    {
        [Key]
        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
        public Marca()
        {
            IdMarca = 0;
            NombreMarca = string.Empty;
        }
        public Marca(int idMarca, string nombreMarca)
        {
            IdMarca = idMarca;
            NombreMarca = nombreMarca ?? throw new ArgumentNullException(nameof(nombreMarca));
        }
    }
}
