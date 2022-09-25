using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimplonAcademy.Data;
using SimplonAcademy.Models;

namespace SimplonAcademy.Controllers
{
    public class FormationTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormationTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FormationTypes
        public async Task<IActionResult> Index()
        {
              return View(await _context.FormationTypes.ToListAsync());
        }

        // GET: FormationTypes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.FormationTypes == null)
            {
                return NotFound();
            }

            var formationType = await _context.FormationTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formationType == null)
            {
                return NotFound();
            }

            return View(formationType);
        }

        // GET: FormationTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormationTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] FormationType formationType)
        {
            if (ModelState.IsValid)
            {
                formationType.Id = Guid.NewGuid();
                _context.Add(formationType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formationType);
        }

        // GET: FormationTypes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.FormationTypes == null)
            {
                return NotFound();
            }

            var formationType = await _context.FormationTypes.FindAsync(id);
            if (formationType == null)
            {
                return NotFound();
            }
            return View(formationType);
        }

        // POST: FormationTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] FormationType formationType)
        {
            if (id != formationType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formationType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormationTypeExists(formationType.Id))
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
            return View(formationType);
        }

        // GET: FormationTypes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.FormationTypes == null)
            {
                return NotFound();
            }

            var formationType = await _context.FormationTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formationType == null)
            {
                return NotFound();
            }

            return View(formationType);
        }

        // POST: FormationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.FormationTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.formationTypes'  is null.");
            }
            var formationType = await _context.FormationTypes.FindAsync(id);
            if (formationType != null)
            {
                _context.FormationTypes.Remove(formationType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormationTypeExists(Guid id)
        {
          return _context.FormationTypes.Any(e => e.Id == id);
        }
    }
}
