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
    public class OperadorsController : Controller
    {
        private readonly TalycapGlobalDBContext _context;

        public OperadorsController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        // GET: Operadors
        public async Task<IActionResult> Index()
        {
            var talycapGlobalDBContext = _context.Operador.Include(o => o.tipoDoc);
            return View(await talycapGlobalDBContext.ToListAsync());
        }

        // GET: Operadors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _context.Operador
                .Include(o => o.tipoDoc)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }

        // GET: Operadors/Create
        public IActionResult Create()
        {
            ViewData["TipoDocId"] = new SelectList(_context.TipoDoc, "Id", "Id");
            return View();
        }

        // POST: Operadors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombres,NumDoc,TipoDocId")] Operador operador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(operador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoDocId"] = new SelectList(_context.TipoDoc, "Id", "Id", operador.TipoDocId);
            return View(operador);
        }

        // GET: Operadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _context.Operador.FindAsync(id);
            if (operador == null)
            {
                return NotFound();
            }
            ViewData["TipoDocId"] = new SelectList(_context.TipoDoc, "Id", "Id", operador.TipoDocId);
            return View(operador);
        }

        // POST: Operadors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombres,NumDoc,TipoDocId")] Operador operador)
        {
            if (id != operador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperadorExists(operador.Id))
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
            ViewData["TipoDocId"] = new SelectList(_context.TipoDoc, "Id", "Id", operador.TipoDocId);
            return View(operador);
        }

        // GET: Operadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _context.Operador
                .Include(o => o.tipoDoc)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }

        // POST: Operadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var operador = await _context.Operador.FindAsync(id);
            _context.Operador.Remove(operador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperadorExists(int id)
        {
            return _context.Operador.Any(e => e.Id == id);
        }
    }
}
