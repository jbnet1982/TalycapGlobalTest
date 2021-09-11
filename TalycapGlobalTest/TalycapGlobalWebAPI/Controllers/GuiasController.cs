using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalycapGlobalData;
using System.Text.Json;

namespace TalycapGlobalWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuiasController : ControllerBase
    {
        private readonly TalycapGlobalBDEntities _context;

        public GuiasController(TalycapGlobalBDEntities context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Guia> Get()
        {
            var ls = _context.Guias.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Guia Details(int Id)
        {
            var rs = _context.Guias.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public Guia Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Guia>(json);
            var rs = new Guia();

            rs.TipoEnvioId = jsonstring.TipoEnvioId;
            rs.NumGuia = jsonstring.NumGuia;
            rs.ClienteId = jsonstring.ClienteId;
            rs.PruductoId = jsonstring.PruductoId;
            rs.Cantidad = jsonstring.Cantidad;
            rs.PrecioUnit = jsonstring.PrecioUnit;
            rs.TotalNeto = jsonstring.TotalNeto;
            rs.PorcDesc = jsonstring.PorcDesc;
            rs.ValorDesc = jsonstring.ValorDesc;
            rs.TotalEnvio = jsonstring.TotalEnvio;
            rs.AlmacenId = jsonstring.AlmacenId;
            rs.VehiculoId = jsonstring.VehiculoId;
            rs.OperadorId = jsonstring.OperadorId;
            rs.FechaRegistro = jsonstring.FechaRegistro;
            rs.FechaEntrega = jsonstring.FechaEntrega;
            rs.EstadoId = jsonstring.EstadoId;
            rs.TipoEnvioId = jsonstring.TipoEnvioId;

            _context.Guias.Add(rs);
            _context.SaveChanges();

            return rs;

        }

    }
}
