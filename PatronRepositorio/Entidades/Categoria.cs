using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
        public Categoria()
        {
            IdCategoria = 0;
            NombreCategoria = string.Empty;
            Descripcion =string.Empty;
        }
        public Categoria(int idCategoria, string nombreCategoria, string descripcion)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria ?? throw new ArgumentNullException(nameof(nombreCategoria));
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
        }

    }

}
