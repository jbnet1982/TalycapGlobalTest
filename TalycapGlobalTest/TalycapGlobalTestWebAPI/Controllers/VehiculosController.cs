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
    public class VehiculosController : Controller
    {
        private readonly TalycapGlobalDBContext _context;

        public VehiculosController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Vehiculo> Get()
        {
            var ls = _context.Vehiculo.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Vehiculo Details(int Id)
        {
            var rs = _context.Vehiculo.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public Vehiculo Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Vehiculo>(json);
            var rs = new Vehiculo();

            rs.Descripcion = jsonstring.Descripcion;
            rs.Matricula = jsonstring.Matricula;
            rs.TipoVehiculoId = jsonstring.TipoVehiculoId;
            _context.Vehiculo.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpGet]
        [Route("api/Put/{json}")]

        public Vehiculo Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Vehiculo>(json);
            var rs = new Vehiculo();

            rs.Id = jsonstring.Id;
            rs.Descripcion = jsonstring.Descripcion;
            rs.Matricula = jsonstring.Matricula;
            rs.TipoVehiculoId = jsonstring.TipoVehiculoId;


            var sql = from p in _context.Vehiculo where p.Id == rs.Id select p;
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

            _context.Vehiculo.Remove(rs);
            _context.SaveChanges();

            return rs;
        }

    }
}
