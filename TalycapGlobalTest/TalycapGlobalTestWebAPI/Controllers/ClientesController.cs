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
    public class ClienteController : ControllerBase
    {
        private readonly TalycapGlobalDBContext _context;

        public ClienteController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            var ls = _context.Cliente.ToArray();
            return ls;
        }

        [HttpGet]
        [Route("api/Details/{Id}")]
        public Cliente Details(int Id)
        {
            var rs = _context.Cliente.Find(Id);
            return rs;
        }

        [HttpGet]
        [Route("api/Post/{json}")]
        public Cliente Post(string json)

        {
            var jsonstring = JsonSerializer.Deserialize<Cliente>(json);
            var rs = new Cliente();

            rs.Nit = jsonstring.Nit;
            rs.Nombre = jsonstring.Nombre;
            rs.Direccion = jsonstring.Direccion;
            rs.Telefono = jsonstring.Telefono;
            rs.Indicativo = jsonstring.Indicativo;
            rs.CiudadId = jsonstring.CiudadId;
            _context.Cliente.Add(rs);
            _context.SaveChanges();

            return rs;

        }

        [HttpGet]
        [Route("api/Put/{json}")]

        public Cliente Put(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Cliente>(json);
            var rs = new Cliente();

            rs.Id = jsonstring.Id;
            rs.Nit = jsonstring.Nit;
            rs.Nombre = jsonstring.Nombre;
            rs.Direccion = jsonstring.Direccion;
            rs.Telefono = jsonstring.Telefono;
            rs.Indicativo = jsonstring.Indicativo;
            rs.CiudadId = jsonstring.CiudadId;


            var sql = from p in _context.Cliente where p.Id == rs.Id select p;
            foreach (var rg in sql)
            {
                rg.Nit = rs.Nit;
                rg.Nombre = rs.Nombre;
                rg.Direccion = rs.Direccion;
                rg.Telefono = rs.Telefono;
                rg.CiudadId = rs.CiudadId;
                _context.SaveChanges();
            }

            return rs;
        }

        [HttpGet]
        [Route("api/Delete/{json}")]

        public Cliente Delete(string json)
        {
            var jsonstring = JsonSerializer.Deserialize<Cliente>(json);
            var rs = new Cliente();

            rs.Id = jsonstring.Id;
            rs.Nit = jsonstring.Nit;
            rs.Nombre = jsonstring.Nombre;
            rs.Direccion = jsonstring.Direccion;
            rs.Telefono = jsonstring.Telefono;
            rs.Indicativo = jsonstring.Indicativo;
            rs.CiudadId = jsonstring.CiudadId;

            _context.Cliente.Remove(rs);
            _context.SaveChanges();

            return rs;
        }


    }
}
