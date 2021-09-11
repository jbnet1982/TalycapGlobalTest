using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalycapGlobalNetCore5App.Models;
using TalycapGlobalWCF;
using Newtonsoft.Json;

namespace TalycapGlobalNetCore5App.Controllers
{
    public class GuiasController : Controller
    {
        // GET: GuiasController

        private readonly TalycapGlobalDBContext _context;
        ServiceClient ws = new ServiceClient();
        public GuiasController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var ls = ws.ListaGuiasAsync();
            return View(ls);
        }

        public ActionResult LogisticaTerrestre()
        {

            var ls = from l in _context.Guia where l.TipoEnvioId == 1 select l;
            return View(ls.ToList());

        }

        public ActionResult LogisticaMaritima()
        {

            var ls = from l in _context.Guia where l.TipoEnvioId == 2 select l;
            return View(ls.ToList());

        }


        // GET: GuiasController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rs = ws.GetGuiaAsync((int)id);

            return View(rs);
        }

        // GET: GuiasController/Create
        public ActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Cliente, "Id", "Id");
            ViewData["ProductpId"] = new SelectList(_context.Producto, "Id", "Id");
            ViewData["AlmacenId"] = new SelectList(_context.Almacen, "Id", "Id");
            ViewData["VehiculoId"] = new SelectList(_context.Vehiculo, "Id", "Id");
            ViewData["OperadorId"] = new SelectList(_context.Operador, "Id", "Id");
            ViewData["TipoEnvioId"] = new SelectList(_context.TipoEnvio, "Id", "Id");
            return View();
        }

        // POST: GuiasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Guia Guias)
        {
            try
            {
                var tipoenv = Guias.TipoEnvioId;
                var Cantidad = Guias.Cantidad;
                decimal ValDesc = 0;
                decimal PorcDesc = 0;
                decimal TotalEnvio = Guias.TotalEnvio;
                TalycapGlobalWCF.Guia rs = new TalycapGlobalWCF.Guia();
                var num = 1;
                var cons = "";

                decimal Precio = 0;
                var ProductoId = Guias.PruductoId;
                var sqlp = from p in _context.Producto where p.Id == ProductoId select p;
                foreach (var rg in sqlp)
                {
                    Precio = rg.precio;
                }

                decimal TotalNeto = Cantidad * Precio;
                TotalEnvio = Cantidad * Precio;

                var sql = from g in _context.Guia where g.TipoEnvioId == tipoenv  select g;
                foreach (var rg in sql)
                {
                    num += 1;
                }

                switch (num.ToString().Length)
                {
                    case 1:
                        cons = tipoenv.ToString() + "00000000" + num.ToString();
                        break;
                    case 2:
                        cons = tipoenv.ToString() + "0000000" + num.ToString();
                        break;
                    case 3:
                        cons = tipoenv.ToString() + "000000" + num.ToString();
                        break;
                    case 4:
                        cons = tipoenv.ToString() + "00000" + num.ToString();
                        break;
                    case 5:
                        cons = tipoenv.ToString() + "0000" + num.ToString();
                        break;
                    case 6:
                        cons = tipoenv.ToString() + "000" + num.ToString();
                        break;
                    case 7:
                        cons = tipoenv.ToString() + "00" + num.ToString();
                        break;
                    case 8:
                        cons = tipoenv.ToString() + "0" + num.ToString();
                        break;
                    case 9:
                        cons = tipoenv.ToString() + num.ToString();
                        break;
               

                }

                if (Cantidad >= 10)
                {
                    var sql2 = from d in _context.Descuentos where d.TipoEnvioId == tipoenv select d;
                    foreach (var rg in sql2)
                    {
                        PorcDesc = rg.Valor/100;
                        ValDesc = TotalEnvio * PorcDesc;
                        TotalEnvio = TotalEnvio - ValDesc;
                    }
                
                }

                rs.Id = 0;
                rs.NumGuia = cons;
                rs.ClienteId = Guias.ClienteId;
                rs.PruductoId = Guias.PruductoId;
                rs.Cantidad = Cantidad;
                rs.PrecioUnit = Precio;
                rs.TotalNeto = TotalNeto;
                rs.PorcDesc = PorcDesc;
                rs.ValorDesc = ValDesc;
                rs.TotalEnvio = TotalEnvio;
                rs.AlmacenId = Guias.AlmacenId;
                rs.VehiculoId = Guias.VehiculoId;
                rs.OperadorId = Guias.OperadorId;
                rs.FechaRegistro = System.DateTime.Now;
                rs.EstadoId = 1;
                rs.TipoEnvioId = Guias.TipoEnvioId;

                var json = JsonConvert.SerializeObject(rs).ToString();
                var res = ws.CreateGuiaAsync(json);

                var ConsG = new TalycapGlobalWCF.ConsecutivoGuia();
                ConsG.TipoEnvioId = tipoenv;
                ConsG.Consecutivo = cons;
                int gui = 0;
                var sqlcon = from c in _context.ConsecutivoGuia where c.Consecutivo == cons && c.TipoEnvioId == tipoenv select c;

           
                foreach (var rg in sqlcon)
                {
                    gui = 1;
                }

                if (gui == 0)
                {
                    json = JsonConvert.SerializeObject(ConsG).ToString();
                    var res2 = ws.CreateConsecutivoAsync(json);
                }
                else 
                {
                    json = JsonConvert.SerializeObject(ConsG).ToString();
                    var res2 = ws.EditConsecutivoAsync(json);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

 

       
    }
}
