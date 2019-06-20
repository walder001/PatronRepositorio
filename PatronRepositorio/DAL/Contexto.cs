using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Personas> Personas { get; set; }
       public DbSet<Proveedor> Proveedors { get; set; }
        //public DbSet<Empleado> Empleados { get; set; }
        public Contexto() : base("DbPatronRepositorio")
        {

        }

    }
}
