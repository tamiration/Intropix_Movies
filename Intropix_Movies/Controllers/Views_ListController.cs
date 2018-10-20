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
    public class Views_ListController : Controller
    {
        private readonly Intropix_MoviesContext _context;

        public Views_ListController(Intropix_MoviesContext context)
        {
            _context = context;
        }

        // GET: Views_List
        public async Task<IActionResult> Index()
        {
            return View(await _context.Views_List.ToListAsync());
        }

        // GET: Views_List/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var views_List = await _context.Views_List
                .FirstOrDefaultAsync(m => m.ID == id);
            if (views_List == null)
            {
                return NotFound();
            }

            return View(views_List);
        }

        // GET: Views_List/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Views_List/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,user_id,movie_id,timestamp")] Views_List views_List)
        {
            if (ModelState.IsValid)
            {
                _context.Add(views_List);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(views_List);
        }

        // GET: Views_List/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var views_List = await _context.Views_List.FindAsync(id);
            if (views_List == null)
            {
                return NotFound();
            }
            return View(views_List);
        }

        // POST: Views_List/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,user_id,movie_id,timestamp")] Views_List views_List)
        {
            if (id != views_List.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(views_List);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Views_ListExists(views_List.ID))
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
            return View(views_List);
        }

        // GET: Views_List/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var views_List = await _context.Views_List
                .FirstOrDefaultAsync(m => m.ID == id);
            if (views_List == null)
            {
                return NotFound();
            }

            return View(views_List);
        }

        // POST: Views_List/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var views_List = await _context.Views_List.FindAsync(id);
            _context.Views_List.Remove(views_List);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Views_ListExists(int id)
        {
            return _context.Views_List.Any(e => e.ID == id);
        }
    }
}
