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
    public class OperadoresController : Controller
    {
        private readonly TalycapGlobalDBContext _context;

        public OperadoresController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Operador> Get()
        {
            var ls = _context.Operador.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Operador Details(int Id)
        {
            var rs = _context.Operador.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public Operador Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Operador>(json);
            var rs = new Operador();

            rs.Nombres = jsonstring.Nombres;
            rs.NumDoc = jsonstring.NumDoc;
            rs.TipoDocId = jsonstring.TipoDocId;
            _context.Operador.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpGet]
        [Route("api/Put/{json}")]

        public Operador Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Operador>(json);
            var rs = new Operador();

            rs.Id = jsonstring.Id;
            rs.Nombres = jsonstring.Nombres;
            rs.NumDoc = jsonstring.NumDoc;
            rs.TipoDocId = jsonstring.TipoDocId;


            var sql = from p in _context.Operador where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Id = rs.Id;
                rg.Nombres = rs.Nombres;
                rg.NumDoc = rs.NumDoc;
                rg.TipoDocId = rs.TipoDocId;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpGet]
        [Route("api/Delete/{json}")]

        public Operador Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Operador>(json);
            var rs = new Operador();

            rs.Id = jsonstring.Id;
            rs.Nombres = jsonstring.Nombres;
            rs.NumDoc = jsonstring.NumDoc;
            rs.TipoDocId = jsonstring.TipoDocId;

            _context.Operador.Remove(rs);
            _context.SaveChanges();

            return rs;
        }

    }
}
