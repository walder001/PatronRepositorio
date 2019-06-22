using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public int Estado_IdEstado { get; set; }
        public int Cargao_IdCargo { get; set; }
        public int Persona_IdPersona { get; set; }
        public Empleado()
        {
            IdEmpleado = 0;
            Estado_IdEstado = 0;
            Cargao_IdCargo = 0;
            Persona_IdPersona = 0;


        }

        public Empleado(int idEmpleado, int estado_IdEstado, int cargao_IdCargo, int persona_IdPersona)
        {
            IdEmpleado = idEmpleado;
            Estado_IdEstado = estado_IdEstado;
            Cargao_IdCargo = cargao_IdCargo;
            Persona_IdPersona = persona_IdPersona;
        }
    }
}
