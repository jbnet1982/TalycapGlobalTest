using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalNetCore5App.Models
{
    public class ConsecutivoGuia
    {
        public int Id { get; set; }
        public int TipoEnvioId { get; set; }
        public string Consecutivo { get; set; }
    }
}
