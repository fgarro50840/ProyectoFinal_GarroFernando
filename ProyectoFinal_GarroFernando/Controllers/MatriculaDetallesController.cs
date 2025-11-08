using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal_GarroFernando.Data;
using ProyectoFinal_GarroFernando.Models;

namespace ProyectoFinal_GarroFernando.Controllers
{
    public class MatriculaDetallesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatriculaDetallesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MatriculaDetalles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MatriculaDetalles.Include(m => m.Curso).Include(m => m.Matricula);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MatriculaDetalles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matriculaDetalle = await _context.MatriculaDetalles
                .Include(m => m.Curso)
                .Include(m => m.Matricula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matriculaDetalle == null)
            {
                return NotFound();
            }

            return View(matriculaDetalle);
        }

        // GET: MatriculaDetalles/Create
        public IActionResult Create()
        {
            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Codigo");
            ViewData["MatriculaId"] = new SelectList(_context.Matriculas, "Id", "Semestre");
            return View();
        }

        // POST: MatriculaDetalles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MatriculaId,CursoId,Grupo")] MatriculaDetalle matriculaDetalle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matriculaDetalle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Codigo", matriculaDetalle.CursoId);
            ViewData["MatriculaId"] = new SelectList(_context.Matriculas, "Id", "Semestre", matriculaDetalle.MatriculaId);
            return View(matriculaDetalle);
        }

        // GET: MatriculaDetalles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matriculaDetalle = await _context.MatriculaDetalles.FindAsync(id);
            if (matriculaDetalle == null)
            {
                return NotFound();
            }
            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Codigo", matriculaDetalle.CursoId);
            ViewData["MatriculaId"] = new SelectList(_context.Matriculas, "Id", "Semestre", matriculaDetalle.MatriculaId);
            return View(matriculaDetalle);
        }

        // POST: MatriculaDetalles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatriculaId,CursoId,Grupo")] MatriculaDetalle matriculaDetalle)
        {
            if (id != matriculaDetalle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matriculaDetalle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatriculaDetalleExists(matriculaDetalle.Id))
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
            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Codigo", matriculaDetalle.CursoId);
            ViewData["MatriculaId"] = new SelectList(_context.Matriculas, "Id", "Semestre", matriculaDetalle.MatriculaId);
            return View(matriculaDetalle);
        }

        // GET: MatriculaDetalles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matriculaDetalle = await _context.MatriculaDetalles
                .Include(m => m.Curso)
                .Include(m => m.Matricula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matriculaDetalle == null)
            {
                return NotFound();
            }

            return View(matriculaDetalle);
        }

        // POST: MatriculaDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matriculaDetalle = await _context.MatriculaDetalles.FindAsync(id);
            if (matriculaDetalle != null)
            {
                _context.MatriculaDetalles.Remove(matriculaDetalle);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatriculaDetalleExists(int id)
        {
            return _context.MatriculaDetalles.Any(e => e.Id == id);
        }
    }
}
