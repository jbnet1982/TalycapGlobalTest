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
    public class VehiculosController : Controller
    {
        private readonly TalycapGlobalBDEntities _context;

        public VehiculosController(TalycapGlobalBDEntities context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Vehiculo> Get()
        {
            var ls = _context.Vehiculoes.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Vehiculo Details(int Id)
        {
            var rs = _context.Vehiculoes.Find(Id);
            return rs;
        }

        [HttpPost]
        [Route("api/Post/{json}")]
        public Vehiculo Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Vehiculo>(json);
            var rs = new Vehiculo();

            rs.Descripcion = jsonstring.Descripcion;
            rs.Matricula = jsonstring.Matricula;
            rs.TipoVehiculoId = jsonstring.TipoVehiculoId;
            _context.Vehiculoes.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpPut]
        [Route("api/Put/{json}")]

        public Vehiculo Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Vehiculo>(json);
            var rs = new Vehiculo();

            rs.Id = jsonstring.Id;
            rs.Descripcion = jsonstring.Descripcion;
            rs.Matricula = jsonstring.Matricula;
            rs.TipoVehiculoId = jsonstring.TipoVehiculoId;


            var sql = from p in _context.Vehiculoes where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Id = rs.Id;
                rg.Descripcion = rs.Descripcion;
                rg.Matricula = rs.Matricula;
                rg.TipoVehiculoId = rs.TipoVehiculoId;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpDelete]
        [Route("api/Delete/{json}")]

        public Vehiculo Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Vehiculo>(json);
            var rs = new Vehiculo();

            rs.Id = jsonstring.Id;
            rs.Descripcion = jsonstring.Descripcion;
            rs.Matricula = jsonstring.Matricula;
            rs.TipoVehiculoId = jsonstring.TipoVehiculoId;

            _context.Vehiculoes.Remove(rs);
            _context.SaveChanges();

            return rs;
        }

    }
}
