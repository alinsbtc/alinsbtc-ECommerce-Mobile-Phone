using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_Commerce_Mobile_Phone.Data;

namespace E_Commerce_Mobile_Phone.Controllers
{
    public class DbCategoriesController : Controller
    {
        private readonly EcAlinContext _context;

        public DbCategoriesController(EcAlinContext context)
        {
            _context = context;
        }

        // GET: DbCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.DbCategories.ToListAsync());
        }

        // GET: DbCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbCategory = await _context.DbCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dbCategory == null)
            {
                return NotFound();
            }

            return View(dbCategory);
        }

        // GET: DbCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DbCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Link,Level,Parentid,Orders,Color,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Trash,Access,Status,Metakey,Metadesc")] DbCategory dbCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dbCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dbCategory);
        }

        // GET: DbCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbCategory = await _context.DbCategories.FindAsync(id);
            if (dbCategory == null)
            {
                return NotFound();
            }
            return View(dbCategory);
        }

        // POST: DbCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Link,Level,Parentid,Orders,Color,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,Trash,Access,Status,Metakey,Metadesc")] DbCategory dbCategory)
        {
            if (id != dbCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dbCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DbCategoryExists(dbCategory.Id))
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
            return View(dbCategory);
        }

        // GET: DbCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbCategory = await _context.DbCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dbCategory == null)
            {
                return NotFound();
            }

            return View(dbCategory);
        }

        // POST: DbCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dbCategory = await _context.DbCategories.FindAsync(id);
            if (dbCategory != null)
            {
                _context.DbCategories.Remove(dbCategory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DbCategoryExists(int id)
        {
            return _context.DbCategories.Any(e => e.Id == id);
        }
    }
}
