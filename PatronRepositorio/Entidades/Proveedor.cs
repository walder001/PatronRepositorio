using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }
        public int Persona_IdPersona { get; set; }
        public Proveedor()
        {
            IdProveedor = 0;
            Persona_IdPersona = 0;

        }
        public Proveedor(int idProveedor, int persona_IdPersona)
        {
            IdProveedor = idProveedor;
            Persona_IdPersona = persona_IdPersona;
        }
    }
}
