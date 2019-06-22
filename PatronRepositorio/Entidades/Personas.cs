using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{

    public class Personas
    {
        [Key]
        public int IdPersona { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Materno { get; set; }
        public string Paterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public int Imagen_IdImagen { get; set; }
        public string Direccion { get; set; }
        public int TipoPersona_IdPersona { get; set; }

        public Personas()
        {
            {
                DNI = 1;
                Nombre = string.Empty;
                Materno = string.Empty;
                Paterno = string.Empty;
                FechaNacimiento = DateTime.Now;
                Telefono = string.Empty;
                Correo = string.Empty;
                Sexo = string.Empty;
                Imagen_IdImagen = 0;
                Direccion = string.Empty;
                TipoPersona_IdPersona = 0;
            }
        }

        public Personas(int dNI, string nombre, string materno, string paterno, DateTime fechaNacimiento, string telefono, string correo, string sexo, int imagen_IdImagen, string direccion, int tipoPersona_IdPersona)
        {
            DNI = dNI;
            Nombre = nombre;
            Materno = materno;
            Paterno = paterno;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Correo = correo;
            Sexo = sexo;
            Imagen_IdImagen = imagen_IdImagen;
            Direccion = direccion;
            TipoPersona_IdPersona = tipoPersona_IdPersona;
        }

    }
}
