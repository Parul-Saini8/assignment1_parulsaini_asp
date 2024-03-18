using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImperialRulers.Data;
using ImperialRulers.Models;

namespace ImperialRulers.Controllers
{
    public class RulersController : Controller
    {
        private readonly ImperialRulersContext _context;

        public RulersController(ImperialRulersContext context)
        {
            _context = context;
        }

        // GET: Rulers
        // GET: Movies
        public async Task<IActionResult> Index(string RulerTypes, string searchString)
        {
            // Use LINQ to get a list of distinct ruler types.
            IQueryable<string> genreQuery = from m in _context.Ruler
                                            orderby m.Types
                                            select m.Types;

            var rulers = from m in _context.Ruler
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                rulers = rulers.Where(s => s.BrandName.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(RulerTypes))
            {
                rulers = rulers.Where(x => x.Types == RulerTypes);
            }

            var rulerTypesVM = new RulerTypesViewModel
            {
                Types = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Rulers = await rulers.ToListAsync()
            };

            return View(rulerTypesVM); // Fixed the variable name here
        }


        // GET: Rulers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruler = await _context.Ruler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ruler == null)
            {
                return NotFound();
            }

            return View(ruler);
        }

        // GET: Rulers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rulers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BrandName,ManufactureDate,Types,Price,Length,Material,Rating")] Ruler ruler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ruler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ruler);
        }

        // GET: Rulers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruler = await _context.Ruler.FindAsync(id);
            if (ruler == null)
            {
                return NotFound();
            }
            return View(ruler);
        }

        // POST: Rulers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BrandName,ManufactureDate,Types,Price,Length,Material")] Ruler ruler)
        {
            if (id != ruler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ruler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RulerExists(ruler.Id))
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
            return View(ruler);
        }

        // GET: Rulers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruler = await _context.Ruler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ruler == null)
            {
                return NotFound();
            }

            return View(ruler);
        }

        // POST: Rulers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ruler = await _context.Ruler.FindAsync(id);
            _context.Ruler.Remove(ruler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RulerExists(int id)
        {
            return _context.Ruler.Any(e => e.Id == id);
        }
    }
}