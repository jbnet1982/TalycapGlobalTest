using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalNetCore5App.Models
{
    public class Operador
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string NumDoc { get; set; }
        public TipoDoc tipoDoc { get; set; }
        public int TipoDocId { get; set; }

    }
}
