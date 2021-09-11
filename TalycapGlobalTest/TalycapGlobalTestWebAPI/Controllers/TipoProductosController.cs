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
    public class TipoProductosController : ControllerBase
    {
        private readonly TalycapGlobalDBContext _context;

        public TipoProductosController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TipoProducto> Get()
        {
            var ls = _context.TipoProducto.ToArray();
            return ls;
        }
        
        [HttpGet]
        [Route("api/Details/{Id}")]
        public TipoProducto Details(int Id)
        {
            var rs = _context.TipoProducto.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public TipoProducto Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<TipoProducto>(json);
            var rs = new TipoProducto();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoProducto.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpGet]
        [Route("api/Put/{json}")]

        public TipoProducto Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoProducto>(json);
            var rs = new TipoProducto();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;

            var sql = from p in _context.TipoProducto where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpGet]
        [Route("api/Delete/{json}")]

        public TipoProducto Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoProducto>(json);
            var rs = new TipoProducto();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoProducto.Remove(rs);
            _context.SaveChanges();

            return rs;
        }
    }
}
