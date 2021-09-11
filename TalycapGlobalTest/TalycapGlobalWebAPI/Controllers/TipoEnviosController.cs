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
    public class TipoEnviosController : Controller
    {
        private readonly TalycapGlobalBDEntities _context;

        public TipoEnviosController(TalycapGlobalBDEntities context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<TipoEnvio> Get()
        {
            var ls = _context.TipoEnvios.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public TipoEnvio Details(int Id)
        {
            var rs = _context.TipoEnvios.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public TipoEnvio Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<TipoEnvio>(json);
            var rs = new TipoEnvio();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoEnvios.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public TipoEnvio Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoEnvio>(json);
            var rs = new TipoEnvio();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;

            var sql = from p in _context.TipoEnvios where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public TipoEnvio Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoEnvio>(json);
            var rs = new TipoEnvio();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoEnvios.Remove(rs);
            _context.SaveChanges();

            return rs;
        }


    }
}
