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
    public class TipoDocsController : ControllerBase
    {
        private readonly TalycapGlobalBDEntities _context;

        public TipoDocsController(TalycapGlobalBDEntities context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<TipoDoc> Get()
        {
            var ls = _context.TipoDocs.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public TipoDoc Details(int Id)
        {
            var rs = _context.TipoDocs.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public TipoDoc Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<TipoDoc>(json);
            var rs = new TipoDoc();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoDocs.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public TipoDoc Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoDoc>(json);
            var rs = new TipoDoc();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;

            var sql = from p in _context.TipoDocs where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nombre = rs.Nombre;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public TipoDoc Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<TipoDoc>(json);
            var rs = new TipoDoc();

            rs.Id = jsonstring.Id;
            rs.Nombre = jsonstring.Nombre;
            _context.TipoDocs.Remove(rs);
            _context.SaveChanges();

            return rs;
        }

    }
}
