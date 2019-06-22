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
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Usuario_Has_Permiso> Usuario_Has_Permisos { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<TipoPersona> TipoPersonas { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Imagen> Imagens { get; set; }
        public DbSet<TipoComprobante> TipoComprobantes { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<UnidadMedida> UnidadMedidas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }

        public Contexto() : base("DbPatronRepositorio")
        {

        }

    }
}
