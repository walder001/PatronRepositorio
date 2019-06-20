using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public int Empleado_IdEmpleado { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }

        public Usuario()
        {
            IdUsuario = 0;
            Empleado_IdEmpleado = 0;
            NombreUsuario = string.Empty;
            Clave = string.Empty;

        }
        public Usuario(int idUsuario, int empleado_IdEmpleado, string nombreUsuario, string clave)
        {
            IdUsuario = idUsuario;
            Empleado_IdEmpleado = empleado_IdEmpleado;
            NombreUsuario = nombreUsuario;
            Clave = clave;
        }
    }
}
