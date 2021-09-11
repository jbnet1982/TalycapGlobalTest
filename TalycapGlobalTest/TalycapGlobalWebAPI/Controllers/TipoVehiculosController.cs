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
    public class TipoVehiculosController : Controller
    {
        private readonly TalycapGlobalBDEntities _context;

        public TipoVehiculosController(TalycapGlobalBDEntities context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TipoVehiculo> Get()
        {
            var ls = _context.TipoVehiculoes.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public TipoVehiculo Details(int Id)
        {
            var rs = _context.TipoVehiculoes.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public TipoVehiculo Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<TipoVehiculo>(json);
            var rs = new TipoVehiculo();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoVehiculoes.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public TipoVehiculo Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoVehiculo>(json);
            var rs = new TipoVehiculo();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;

            var sql = from p in _context.TipoVehiculoes where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public TipoVehiculo Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoVehiculo>(json);
            var rs = new TipoVehiculo();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoVehiculoes.Remove(rs);
            _context.SaveChanges();

            return rs;
        }
    }
}
