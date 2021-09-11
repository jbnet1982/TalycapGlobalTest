using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalTestWebAPI.Models
{
    public class Guia
    {
        public int Id { get; set; }
        public string NumGuia { get; set; }
        public Cliente cliente { get; set; }
        public int ClienteId { get; set; }
        public Producto pruducto { get; set; }
        public int PruductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnit { get; set; }
        public decimal TotalNeto { get; set; }
        public decimal PorcDesc { get; set; }
        public decimal ValorDesc { get; set; }
        public decimal TotalEnvio { get; set; }
        public Almacen almacen { get; set; }
        public int AlmacenId { get; set; }
        public Vehiculo vehiculo { get; set; }
        public int VehiculoId { get; set; }
        public Operador operador { get; set; }
        public int OperadorId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaEntrega { get; set; }
        public Estado estado { get; set; }
        public int EstadoId { get; set; }
        public TipoEnvio tipoEnvio { get; set; }
        public int TipoEnvioId { get; set; }
    }
}
