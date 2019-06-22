using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Permiso
    {
        [Key]
        public int IdPermiso { get; set; }
        public string Descripcion { get; set; }
        public string Funcionalidad { get; set; }
        public Permiso()
        {
            IdPermiso = 0;
            Descripcion = string.Empty;
            Funcionalidad = string.Empty;
        }
        public Permiso(int idPermiso, string descripcion, string funcionalidad)
        {
            IdPermiso = idPermiso;
            Descripcion = descripcion;
            Funcionalidad = funcionalidad;
        }
    }
}
