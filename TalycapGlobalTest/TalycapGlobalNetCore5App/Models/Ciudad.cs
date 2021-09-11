using System;


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalNetCore5App.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Region region { get; set; }
        public int RegionId { get; set; }

    }
}
