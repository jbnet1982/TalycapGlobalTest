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
    public class TipoAlmacenController : ControllerBase
    {
        private readonly TalycapGlobalBDEntities _context;

        public TipoAlmacenController(TalycapGlobalBDEntities context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TipoAlmacen> Get()
        {
            var ls = _context.TipoAlmacens.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public TipoAlmacen Details(int Id)
        {
            var rs = _context.TipoAlmacens.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public TipoAlmacen Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<TipoAlmacen>(json);
            var rs = new TipoAlmacen();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoAlmacens.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpGet]
        [Route("api/Put/{json}")]

        public TipoAlmacen Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoAlmacen>(json);
            var rs = new TipoAlmacen();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;

            var sql = from p in _context.TipoAlmacens where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpGet]
        [Route("api/Delete/{json}")]

        public TipoAlmacen Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoAlmacen>(json);
            var rs = new TipoAlmacen();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoAlmacens.Remove(rs);
            _context.SaveChanges();

            return rs;
        }

    }
}
