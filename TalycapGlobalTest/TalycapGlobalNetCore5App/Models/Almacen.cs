using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalNetCore5App.Models
{
    public class Almacen
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Ciudad ciudad { get; set; }
        public int CiudadId { get; set; }
        public TipoAlmacen tipoAlmacen { get; set; }
        public int TipoAlmacenId { get; set; }
    }
}
