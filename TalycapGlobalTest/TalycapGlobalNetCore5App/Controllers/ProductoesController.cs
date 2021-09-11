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
    public class ProductoesController : Controller
    {
        private readonly TalycapGlobalDBContext _context;

        public ProductoesController(TalycapGlobalDBContext context)
        {
            _context = context;
        }

        // GET: Productoes
        public async Task<IActionResult> Index()
        {
            var talycapGlobalDBContext = _context.Producto.Include(p => p.almacen).Include(p => p.tipoProducto);
            return View(await talycapGlobalDBContext.ToListAsync());
        }

        // GET: Productoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.almacen)
                .Include(p => p.tipoProducto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productoes/Create
        public IActionResult Create()
        {
            ViewData["AlmacenId"] = new SelectList(_context.Almacen, "Id", "Id");
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "Id", "Id");
            return View();
        }

        // POST: Productoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CodRef,Nombre,Descripcion,AlmacenId,TipoProductoId,precio")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlmacenId"] = new SelectList(_context.Almacen, "Id", "Id", producto.AlmacenId);
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "Id", "Id", producto.TipoProductoId);
            return View(producto);
        }

        // GET: Productoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["AlmacenId"] = new SelectList(_context.Almacen, "Id", "Id", producto.AlmacenId);
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "Id", "Id", producto.TipoProductoId);
            return View(producto);
        }

        // POST: Productoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodRef,Nombre,Descripcion,AlmacenId,TipoProductoId,precio")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
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
            ViewData["AlmacenId"] = new SelectList(_context.Almacen, "Id", "Id", producto.AlmacenId);
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "Id", "Id", producto.TipoProductoId);
            return View(producto);
        }

        // GET: Productoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.almacen)
                .Include(p => p.tipoProducto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.Id == id);
        }
    }
}
