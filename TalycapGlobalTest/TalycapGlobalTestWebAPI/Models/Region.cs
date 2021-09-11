using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalTestWebAPI.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Pai Pais { get; set; }
        public int PaisId { get; set; }
    }
}
