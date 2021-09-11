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
    public class CiudadController : ControllerBase
    {
        private readonly TalycapGlobalDBContext _context;

        public CiudadController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Ciudad> Get()
        {
            var ls = _context.Ciudad.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Ciudad Details(int Id)
        {
            var rs = _context.Ciudad.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public Ciudad Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Ciudad>(json);
            var rs = new Ciudad();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.RegionId = jsonstring.RegionId;
            _context.Ciudad.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpGet]
        [Route("api/Put/{json}")]

        public Ciudad Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Ciudad>(json);
            var rs = new Ciudad();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.RegionId = jsonstring.RegionId;


            var sql = from p in _context.Ciudad where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                rg.RegionId = rs.RegionId;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpGet]
        [Route("api/Delete/{json}")]

        public Ciudad Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Ciudad>(json);
            var rs = new Ciudad();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.RegionId = jsonstring.RegionId;

            _context.Ciudad.Remove(rs);
            _context.SaveChanges();

            return rs;
        }


    }
}
