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
    public class AlmacensController : ControllerBase
    {
        private readonly TalycapGlobalBDEntities _context;

        public AlmacensController(TalycapGlobalBDEntities context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Almacen> Get()
        {
            var ls = _context.Almacens.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Almacen Details(int Id)
        {
            var rs = _context.Almacens.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public Almacen Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Almacen>(json);
            var rs = new Almacen();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.TipoAlmacenId = jsonstring.TipoAlmacenId;
            rs.CiudadId = jsonstring.CiudadId;
            _context.Almacens.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public Almacen Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Almacen>(json);
            var rs = new Almacen();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.TipoAlmacenId = jsonstring.TipoAlmacenId;
            rs.CiudadId = jsonstring.CiudadId;


            var sql = from p in _context.Almacens where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                rg.TipoAlmacenId = rs.TipoAlmacenId;
                rg.CiudadId = rs.CiudadId;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public Almacen Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Almacen>(json);
            var rs = new Almacen();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.TipoAlmacenId = jsonstring.TipoAlmacenId;
            rs.CiudadId = jsonstring.CiudadId;

            _context.Almacens.Remove(rs);
            _context.SaveChanges();

            return rs;
        }

    }
}
