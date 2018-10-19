using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Intropix_Movies.Models;

namespace Intropix_Movies.Controllers
{
    public class TrailersController : Controller
    {
        private readonly Intropix_MoviesContext _context;

        public TrailersController(Intropix_MoviesContext context)
        {
            _context = context;
        }

        // GET: Trailers
        public async Task<IActionResult> Index(string trailerName , string film_location,string summary)
        {
            var movies = from m in _context.Trailers
                         select m;

            //Check if you should filter by Name (if it isn't empty)
            if (!String.IsNullOrEmpty(trailerName))
            {
                movies = movies.Where(s => s.Name.Contains(trailerName));
                 
            }

            //Check if you should filter by location (if it isn't empty)
            if (!String.IsNullOrEmpty(film_location))
            {
                movies = movies.Where(s => s.filming_location.Contains(film_location));
            }

            //Check if you should filter by summary (if it isn't empty)
            if (!String.IsNullOrEmpty(summary))
            {
                movies = movies.Where(s => s.Summary.Contains(summary));
            }

            return View(await movies.ToListAsync());
        }

        // GET: Trailers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trailers = await _context.Trailers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trailers == null)
            {
                return NotFound();
            }

            return View(trailers);
        }

        // GET: Trailers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trailers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Lenght,Source_link,Summary,Rating,filming_location,Studio_id")] Trailers trailers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trailers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trailers);
        }

        // GET: Trailers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trailers = await _context.Trailers.FindAsync(id);
            if (trailers == null)
            {
                return NotFound();
            }
            return View(trailers);
        }

        // POST: Trailers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Lenght,Source_link,Summary,Rating,filming_location,Studio_id")] Trailers trailers)
        {
            if (id != trailers.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trailers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrailersExists(trailers.ID))
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
            return View(trailers);
        }

        // GET: Trailers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trailers = await _context.Trailers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trailers == null)
            {
                return NotFound();
            }

            return View(trailers);
        }

        // POST: Trailers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trailers = await _context.Trailers.FindAsync(id);
            _context.Trailers.Remove(trailers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrailersExists(int id)
        {
            return _context.Trailers.Any(e => e.ID == id);
        }
    }
}
