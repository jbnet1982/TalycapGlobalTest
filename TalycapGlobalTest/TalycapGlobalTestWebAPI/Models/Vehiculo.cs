using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalTestWebAPI.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Matricula { get; set; }
        public TipoVehiculo tipoVehiculo { get; set; }
        public int TipoVehiculoId { get; set; }
    }
}
