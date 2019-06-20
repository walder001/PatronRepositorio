using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Usuario_Has_Permiso
    {
        public int Usuario_IdUsuario { get; set; }
        public int Permiso_IdPermiso { get; set; }

        public Usuario_Has_Permiso()
        {
            Usuario_IdUsuario = 0;
            Permiso_IdPermiso = 0;
        }
        public Usuario_Has_Permiso(int usuario_IdUsuario, int permiso_IdPermiso)
        {
            Usuario_IdUsuario = usuario_IdUsuario;
            Permiso_IdPermiso = permiso_IdPermiso;
        }
    }
}
