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
    public class TipoEnvioController : Controller
    {
        private readonly TalycapGlobalDBContext _context;

        public TipoEnvioController(TalycapGlobalDBContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<TipoEnvio> Get()
        {
            var ls = _context.TipoEnvio.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public TipoEnvio Details(int Id)
        {
            var rs = _context.TipoEnvio.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public TipoEnvio Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<TipoEnvio>(json);
            var rs = new TipoEnvio();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoEnvio.Add(rs);
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

            var sql = from p in _context.TipoEnvio where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpGet]
        [Route("api/Delete/{json}")]

        public TipoEnvio Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoEnvio>(json);
            var rs = new TipoEnvio();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoEnvio.Remove(rs);
            _context.SaveChanges();

            return rs;
        }


    }
}
