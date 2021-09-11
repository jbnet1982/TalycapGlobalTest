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
    public class TipoDocController : ControllerBase
    {
        private readonly TalycapGlobalDBContext _context;

        public TipoDocController(TalycapGlobalDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<TipoDoc> Get()
        {
            var ls = _context.TipoDoc.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public TipoDoc Details(int Id)
        {
            var rs = _context.TipoDoc.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public TipoDoc Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<TipoDoc>(json);
            var rs = new TipoDoc();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoDoc.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpGet]
        [Route("api/Put/{json}")]

        public TipoDoc Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoDoc>(json);
            var rs = new TipoDoc();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;

            var sql = from p in _context.TipoDoc where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpGet]
        [Route("api/Delete/{json}")]

        public TipoDoc Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoDoc>(json);
            var rs = new TipoDoc();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoDoc.Remove(rs);
            _context.SaveChanges();

            return rs;
        }

    }
}
