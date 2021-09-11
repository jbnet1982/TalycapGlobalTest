using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using TalycapGlobalWebAPI.Models;

namespace TalycapGlobalWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadosController : ControllerBase
    {
        private readonly TalycapGlobalDBContext _context;

        public EstadosController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Estado> Get()
        {
            var ls = _context.Estados.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Estado Details(int Id)
        {
            var rs = _context.Estados.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public Estado Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Estado>(json);
            var rs = new Estado();

            rs.Nombre = jsonstring.Nombre;
            _context.Estados.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public Estado Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Estado>(json);
            var rs = new Estado();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
          

            var sql = from p in _context.Estados where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Id = rs.Id;
                rg.Nombre = rs.Nombre;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public Estado Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Estado>(json);
            var rs = new Estado();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
           
            _context.Estados.Remove(rs);
            _context.SaveChanges();

            return rs;
        }
    }
}
