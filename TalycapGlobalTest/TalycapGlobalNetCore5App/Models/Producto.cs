using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalycapGlobalNetCore5App.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string CodRef { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Almacen almacen { get; set; }
        public int AlmacenId { get; set; }
        public TipoProducto tipoProducto { get; set; }
        public int TipoProductoId { get; set; }
        public decimal precio { get; set; }

    }
}
