using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalTestWebAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Indicativo { get; set; }
        public Ciudad ciudad { get; set; }
        public int CiudadId { get; set; }
    

    }
}
