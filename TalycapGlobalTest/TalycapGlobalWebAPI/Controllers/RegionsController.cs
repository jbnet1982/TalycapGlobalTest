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
    public class Regions : ControllerBase
    {
        private readonly TalycapGlobalBDEntities _context;

        public Regions(TalycapGlobalBDEntities context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Region> Get()
        {
            var ls = _context.Regions.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Region Details(int Id)
        {
            var rs = _context.Regions.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public Region Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Region>(json);
            var rs = new Region();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.PaisId = jsonstring.PaisId;
            _context.Regions.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public Region Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Region>(json);
            var rs = new Region();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.PaisId = jsonstring.PaisId;


            var sql = from p in _context.Regions where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                rg.PaisId = rs.PaisId;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public Region Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Region>(json);
            var rs = new Region();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.PaisId = jsonstring.PaisId;

            _context.Regions.Remove(rs);
            _context.SaveChanges();

            return rs;
        }


    }
}
