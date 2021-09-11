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
    public class DescuentosController : ControllerBase
    {
        private readonly TalycapGlobalBDEntities _context;

        public DescuentosController(TalycapGlobalBDEntities context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Descuento> Get()
        {
            var ls = _context.Descuentos.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Descuento Details(int Id)
        {
            var rs = _context.Descuentos.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public Descuento Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Descuento>(json);
            var rs = new Descuento();

            rs.Descripcion = jsonstring.Descripcion;
            rs.Valor = jsonstring.Valor;
            rs.CantidadMax = jsonstring.CantidadMax;
            rs.TipoEnvioId = jsonstring.TipoEnvioId;
            _context.Descuentos.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public Descuento Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Descuento>(json);
            var rs = new Descuento();

            rs.Id = jsonstring.Id;
            rs.Descripcion = jsonstring.Descripcion;
            rs.Valor = jsonstring.Valor;
            rs.CantidadMax = jsonstring.CantidadMax;
            rs.TipoEnvioId = jsonstring.TipoEnvioId;


            var sql = from p in _context.Descuentos where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Id = rs.Id;
                rg.Descripcion = rs.Descripcion;
                rg.Valor = rs.Valor;
                rg.CantidadMax = rs.CantidadMax;
                rg.TipoEnvioId = rs.TipoEnvioId;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public Descuento Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Descuento>(json);
            var rs = new Descuento();

            rs.Id = jsonstring.Id;
            rs.Descripcion = jsonstring.Descripcion;
            rs.Valor = jsonstring.Valor;
            rs.CantidadMax = jsonstring.CantidadMax;
            rs.TipoEnvioId = jsonstring.TipoEnvioId;

            _context.Descuentos.Remove(rs);
            _context.SaveChanges();

            return rs;
        }



    }
}
