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
    public class ProductosController : ControllerBase
    {
        private readonly TalycapGlobalBDEntities _context;
        public ProductosController(TalycapGlobalBDEntities context)
        {
            _context = context;       
        }

        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            var ls = _context.Productoes.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Producto Details(int Id)
        {
            var rs = _context.Productoes.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public Producto Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Producto>(json);
            var rs = new Producto();

            rs.CodRef = jsonstring.CodRef;
            rs.Nombre = jsonstring.Nombre;
            rs.Descripcion = jsonstring.Descripcion;
            rs.TipoProductoId = jsonstring.TipoProductoId;
            rs.AlmacenId = jsonstring.AlmacenId;
            rs.Precio = jsonstring.Precio;
            _context.Productoes.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public Producto Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Producto>(json);
            var rs = new Producto();

            rs.Id = jsonstring.Id;
            rs.CodRef = jsonstring.CodRef;
            rs.Nombre = jsonstring.Nombre;
            rs.Descripcion = jsonstring.Descripcion;
            rs.TipoProductoId = jsonstring.TipoProductoId;
            rs.AlmacenId = jsonstring.AlmacenId;
            rs.Precio = jsonstring.Precio;

            var sql = from p in _context.Productoes where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.CodRef = rs.CodRef;
                rg.Nombre = rs.Nombre;
                rg.Descripcion = rs.Descripcion;
                rg.TipoProductoId = rs.TipoProductoId;
                rg.AlmacenId = rs.AlmacenId;
                rg.Precio = rs.Precio;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public Producto Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Producto>(json);
            var rs = new Producto();

            rs.Id = jsonstring.Id;
            rs.CodRef = jsonstring.CodRef;
            rs.Nombre = jsonstring.Nombre;
            rs.Descripcion = jsonstring.Descripcion;
            rs.TipoProductoId = jsonstring.TipoProductoId;
            rs.AlmacenId = jsonstring.AlmacenId;
            rs.Precio = jsonstring.Precio;
            _context.Productoes.Remove(rs);
            _context.SaveChanges();

            return rs;
        }
    }
}
