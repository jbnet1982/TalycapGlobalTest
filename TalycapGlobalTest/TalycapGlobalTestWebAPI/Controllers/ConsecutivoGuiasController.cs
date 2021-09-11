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
    public class ConsecutivoGuiaController : ControllerBase
    {
        private readonly TalycapGlobalDBContext _context;

        public ConsecutivoGuiaController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<ConsecutivoGuia> Get()
        {
            var ls = _context.ConsecutivoGuia.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public ConsecutivoGuia Details(int Id)
        {
            var rs = _context.ConsecutivoGuia.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public ConsecutivoGuia Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<ConsecutivoGuia>(json);
            var rs = new ConsecutivoGuia();

            rs.TipoEnvioId = jsonstring.TipoEnvioId;
            rs.Consecutivo = jsonstring.Consecutivo;
            _context.ConsecutivoGuia.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpGet]
        [Route("api/Put/{json}")]

        public ConsecutivoGuia Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<ConsecutivoGuia>(json);
            var rs = new ConsecutivoGuia();

            rs.TipoEnvioId = jsonstring.TipoEnvioId;
            rs.Consecutivo = jsonstring.Consecutivo;


            var sql = from p in _context.ConsecutivoGuia where p.TipoEnvioId == rs.TipoEnvioId select p;
            foreach (var rg in sql)
            {
                rg.Consecutivo = rs.Consecutivo;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpGet]
        [Route("api/Delete/{json}")]

        public ConsecutivoGuia Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<ConsecutivoGuia>(json);
            var rs = new ConsecutivoGuia();

            rs.TipoEnvioId = jsonstring.TipoEnvioId;
            rs.Consecutivo = jsonstring.Consecutivo;

            _context.ConsecutivoGuia.Remove(rs);
            _context.SaveChanges();

            return rs;
        }
    }
}
