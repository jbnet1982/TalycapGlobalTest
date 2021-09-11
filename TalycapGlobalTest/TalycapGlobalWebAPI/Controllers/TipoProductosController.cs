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
    public class TipoProductosController : ControllerBase
    {
        private readonly TalycapGlobalBDEntities _context;

        public TipoProductosController(TalycapGlobalBDEntities context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TipoProducto> Get()
        {
            var ls = _context.TipoProductoes.ToArray();
            return ls;
        }
        
        [HttpGet]
        [Route("api/Details/{Id}")]
        public TipoProducto Details(int Id)
        {
            var rs = _context.TipoProductoes.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public TipoProducto Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<TipoProducto>(json);
            var rs = new TipoProducto();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoProductoes.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public TipoProducto Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoProducto>(json);
            var rs = new TipoProducto();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;

            var sql = from p in _context.TipoProductoes where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public TipoProducto Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoProducto>(json);
            var rs = new TipoProducto();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoProductoes.Remove(rs);
            _context.SaveChanges();

            return rs;
        }
    }
}
