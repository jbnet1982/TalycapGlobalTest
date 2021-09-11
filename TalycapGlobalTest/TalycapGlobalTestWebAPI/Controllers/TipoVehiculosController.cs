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
    public class TipoVehiculosController : ControllerBase
    {
        private readonly TalycapGlobalDBContext _context;

        public TipoVehiculosController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TipoVehiculo> Get()
        {
            var ls = _context.TipoVehiculo.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public TipoVehiculo Details(int Id)
        {
            var rs = _context.TipoVehiculo.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public TipoVehiculo Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<TipoVehiculo>(json);
            var rs = new TipoVehiculo();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoVehiculo.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpGet]
        [Route("api/Put/{json}")]

        public TipoVehiculo Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoVehiculo>(json);
            var rs = new TipoVehiculo();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;

            var sql = from p in _context.TipoVehiculo where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpGet]
        [Route("api/Delete/{json}")]

        public TipoVehiculo Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoVehiculo>(json);
            var rs = new TipoVehiculo();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoVehiculo.Remove(rs);
            _context.SaveChanges();

            return rs;
        }
    }
}
