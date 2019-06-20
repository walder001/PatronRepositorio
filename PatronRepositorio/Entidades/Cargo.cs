using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Cargo
    {
        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public int Estado_IdEstado { get; set; }

        public Cargo()
        {
            IdCargo = 0;
            NombreCargo = string.Empty;
            Estado_IdEstado = 0;
        }
        public Cargo(int idCargo, string nombreCargo, int estado_IdEstado)
        {
            IdCargo = idCargo;
            NombreCargo = nombreCargo;
            Estado_IdEstado = estado_IdEstado;
        }
    }
}
