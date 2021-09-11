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
    public class CiudadsController : ControllerBase
    {
        private readonly TalycapGlobalBDEntities _context;

        public CiudadsController(TalycapGlobalBDEntities context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Ciudad> Get()
        {
            var ls = _context.Ciudads.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Ciudad Details(int Id)
        {
            var rs = _context.Ciudads.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public Ciudad Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Ciudad>(json);
            var rs = new Ciudad();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.RegionId = jsonstring.RegionId;
            _context.Ciudads.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public Ciudad Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Ciudad>(json);
            var rs = new Ciudad();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.RegionId = jsonstring.RegionId;


            var sql = from p in _context.Ciudads where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                rg.RegionId = rs.RegionId;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public Ciudad Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Ciudad>(json);
            var rs = new Ciudad();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.RegionId = jsonstring.RegionId;

            _context.Ciudads.Remove(rs);
            _context.SaveChanges();

            return rs;
        }


    }
}
