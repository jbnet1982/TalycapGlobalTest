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
    public class ConsecutivoGuiasController : ControllerBase
    {
        private readonly TalycapGlobalBDEntities _context;

        public ConsecutivoGuiasController(TalycapGlobalBDEntities context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<ConsecutivoGuia> Get()
        {
            var ls = _context.ConsecutivoGuias.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public ConsecutivoGuia Details(int Id)
        {
            var rs = _context.ConsecutivoGuias.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public ConsecutivoGuia Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<ConsecutivoGuia>(json);
            var rs = new ConsecutivoGuia();

            rs.TipoEnvioId = jsonstring.TipoEnvioId;
            rs.Consecutivo = jsonstring.Consecutivo;
            _context.ConsecutivoGuias.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public ConsecutivoGuia Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<ConsecutivoGuia>(json);
            var rs = new ConsecutivoGuia();

            rs.TipoEnvioId = jsonstring.TipoEnvioId;
            rs.Consecutivo = jsonstring.Consecutivo;


            var sql = from p in _context.ConsecutivoGuias where p.TipoEnvioId == rs.TipoEnvioId select p;
            foreach (var rg in sql)
            {
                rg.Consecutivo = rs.Consecutivo;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public ConsecutivoGuia Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<ConsecutivoGuia>(json);
            var rs = new ConsecutivoGuia();

            rs.TipoEnvioId = jsonstring.TipoEnvioId;
            rs.Consecutivo = jsonstring.Consecutivo;

            _context.ConsecutivoGuias.Remove(rs);
            _context.SaveChanges();

            return rs;
        }
    }
}
