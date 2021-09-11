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
    public class PaisController : ControllerBase
    {
        private readonly TalycapGlobalDBContext _context;


        public PaisController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Pai> Get()
        {
            var ls = _context.Pais.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Pai Details(int Id)
        {
            var rs = _context.Pais.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public Pai Post(string json)
  
        {
            
            var jsonstring = JsonSerializer.Deserialize<Pai>(json);
            var rs = new Pai();
            var ls = new List<Pai>();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.CodArea = "+" + jsonstring.CodArea;
            _context.Pais.Add(rs);
            _context.SaveChanges();

            return rs;
 
        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public Pai Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Pai>(json);
            var rs = new Pai();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.CodArea = "+" + jsonstring.CodArea;

            var sql = from p in _context.Pais where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                rg.CodArea = rs.CodArea;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public Pai Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Pai>(json);
            var rs = new Pai();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            rs.CodArea = "+" + jsonstring.CodArea;
            _context.Pais.Remove(rs);
            _context.SaveChanges();

            return rs;
        }

    }
}
