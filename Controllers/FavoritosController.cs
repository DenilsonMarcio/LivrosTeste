using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LivrosTeste.Models;

namespace LivrosTeste.Controllers
{
    public class FavoritosController : Controller
    {
        private readonly Context _context;

        public FavoritosController(Context context)
        {
            _context = context;
        }

        // GET: Favoritos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Favoritos.ToListAsync());
        }

        // GET: Favoritos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favoritos = await _context.Favoritos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favoritos == null)
            {
                return NotFound();
            }

            return View(favoritos);
        }

        // GET: Favoritos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Favoritos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFavorite_([Bind("Id,Genero,Titulo,Autor,Paginas,Ilustracao,SerieDescricao")] Favoritos favoritos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(favoritos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(favoritos);
        }

        // GET: Favoritos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favoritos = await _context.Favoritos.FindAsync(id);
            if (favoritos == null)
            {
                return NotFound();
            }
            return View(favoritos);
        }

        // POST: Favoritos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Genero,Titulo,Autor,Paginas,Ilustracao,SerieDescricao")] Favoritos favoritos)
        {
            if (id != favoritos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(favoritos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FavoritosExists(favoritos.Id))
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
            return View(favoritos);
        }

        // GET: Favoritos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favoritos = await _context.Favoritos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favoritos == null)
            {
                return NotFound();
            }

            return View(favoritos);
        }

        // POST: Favoritos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var favoritos = await _context.Favoritos.FindAsync(id);
            _context.Favoritos.Remove(favoritos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FavoritosExists(int id)
        {
            return _context.Favoritos.Any(e => e.Id == id);
        }
    }
}
