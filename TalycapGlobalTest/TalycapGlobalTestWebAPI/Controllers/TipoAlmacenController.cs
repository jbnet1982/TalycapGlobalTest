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
    public class TipoAlmacenController : ControllerBase
    {
        private readonly TalycapGlobalDBContext _context;

        public TipoAlmacenController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TipoAlmacen> Get()
        {
            var ls = _context.TipoAlmacen.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public TipoAlmacen Details(int Id)
        {
            var rs = _context.TipoAlmacen.Find(Id);
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
            _context.TipoAlmacen.Add(rs);
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

            var sql = from p in _context.TipoAlmacen where p.Id == rs.Id select p;
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
            _context.TipoAlmacen.Remove(rs);
            _context.SaveChanges();

            return rs;
        }

    }
}
