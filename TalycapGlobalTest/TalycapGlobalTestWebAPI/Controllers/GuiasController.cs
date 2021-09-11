using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalycapGlobalTestWebAPI.Models;
using System.Text.Json;


namespace TalycapGlobalTestWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuiaController : ControllerBase
    {
        private readonly TalycapGlobalDBContext _context;

        public GuiaController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Guia> Get()
        {
            var ls = _context.Guia.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Guia Details(int Id)
        {
            var rs = _context.Guia.Find(Id);
            return rs;
        }

        [HttpGet]
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

            _context.Guia.Add(rs);
            _context.SaveChanges();

            return rs;

        }

    }
}
