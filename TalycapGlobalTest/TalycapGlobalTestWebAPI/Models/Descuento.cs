using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalTestWebAPI.Models
{
    public class Descuento
    {
        public int Id { get; set; }
        public string Descripcion{ get; set; }
        public decimal Valor { get; set; }
        public int CantidadMax { get; set; }
        public TipoEnvio tipoEnvio { get; set; }
        public int TipoEnvioId { get; set; }
    }
}
