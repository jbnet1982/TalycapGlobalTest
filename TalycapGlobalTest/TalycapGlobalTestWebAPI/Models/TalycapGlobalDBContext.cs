using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalTestWebAPI.Models
{
    public partial class TalycapGlobalDBContext: DbContext
    {
        public TalycapGlobalDBContext(DbContextOptions<TalycapGlobalDBContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<TipoAlmacen> TipoAlmacen { get; set; }
        public virtual DbSet<TipoEnvio> TipoEnvio { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
        public virtual DbSet<TipoDoc> TipoDoc { get; set; }
        public virtual DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Operador> Operador { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
        public virtual DbSet<Descuento> Descuentos { get; set; }
        public virtual DbSet<ConsecutivoGuia> ConsecutivoGuia { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Guia> Guia { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-VKBJDBVK;Database=TalycapGlobalBD;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

    }
}
