using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TalycapGlobalNetCore5App.Models;

namespace TalycapGlobalNetCore5App.Controllers
{
    public class AlmacensController : Controller
    {
        private readonly TalycapGlobalDBContext _context;

        public AlmacensController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        // GET: Almacens
        public async Task<IActionResult> Index()
        {
            var talycapGlobalDBContext = _context.Almacen.Include(a => a.ciudad).Include(a => a.tipoAlmacen);
            return View(await talycapGlobalDBContext.ToListAsync());
        }

        // GET: Almacens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen
                .Include(a => a.ciudad)
                .Include(a => a.tipoAlmacen)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (almacen == null)
            {
                return NotFound();
            }

            return View(almacen);
        }

        // GET: Almacens/Create
        public IActionResult Create()
        {
            ViewData["CiudadId"] = new SelectList(_context.Ciudad, "Id", "Id");
            ViewData["TipoAlmacenId"] = new SelectList(_context.TipoAlmacen, "Id", "Id");
            return View();
        }

        // POST: Almacens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,CiudadId,TipoAlmacenId")] Almacen almacen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(almacen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CiudadId"] = new SelectList(_context.Ciudad, "Id", "Id", almacen.CiudadId);
            ViewData["TipoAlmacenId"] = new SelectList(_context.TipoAlmacen, "Id", "Id", almacen.TipoAlmacenId);
            return View(almacen);
        }

        // GET: Almacens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen.FindAsync(id);
            if (almacen == null)
            {
                return NotFound();
            }
            ViewData["CiudadId"] = new SelectList(_context.Ciudad, "Id", "Id", almacen.CiudadId);
            ViewData["TipoAlmacenId"] = new SelectList(_context.TipoAlmacen, "Id", "Id", almacen.TipoAlmacenId);
            return View(almacen);
        }

        // POST: Almacens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,CiudadId,TipoAlmacenId")] Almacen almacen)
        {
            if (id != almacen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(almacen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlmacenExists(almacen.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CiudadId"] = new SelectList(_context.Ciudad, "Id", "Id", almacen.CiudadId);
            ViewData["TipoAlmacenId"] = new SelectList(_context.TipoAlmacen, "Id", "Id", almacen.TipoAlmacenId);
            return View(almacen);
        }

        // GET: Almacens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen
                .Include(a => a.ciudad)
                .Include(a => a.tipoAlmacen)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (almacen == null)
            {
                return NotFound();
            }

            return View(almacen);
        }

        // POST: Almacens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var almacen = await _context.Almacen.FindAsync(id);
            _context.Almacen.Remove(almacen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlmacenExists(int id)
        {
            return _context.Almacen.Any(e => e.Id == id);
        }
    }
}
