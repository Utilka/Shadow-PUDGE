#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shadow_PUDGE.Data;
using Shadow_PUDGE.Models;

namespace Shadow_PUDGE.Controllers
{
    public class ProductCollectionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductCollectionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductCollections
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductCollections.ToListAsync());
        }

        // GET: ProductCollections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCollection = await _context.ProductCollections
                .Include(p => p.Collection_products).ThenInclude(x => x.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productCollection == null)
            {
                return NotFound();
            }

            return View(productCollection);
        }

        // GET: ProductCollections/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductCollections/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,CreatedAt")] ProductCollection productCollection)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productCollection);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productCollection);
        }

        // GET: ProductCollections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCollection = await _context.ProductCollections.FindAsync(id);
            if (productCollection == null)
            {
                return NotFound();
            }
            return View(productCollection);
        }

        // POST: ProductCollections/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,CreatedAt")] ProductCollection productCollection)
        {
            if (id != productCollection.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productCollection);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductCollectionExists(productCollection.Id))
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
            return View(productCollection);
        }

        // GET: ProductCollections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCollection = await _context.ProductCollections
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productCollection == null)
            {
                return NotFound();
            }

            return View(productCollection);
        }

        // POST: ProductCollections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productCollection = await _context.ProductCollections.FindAsync(id);
            _context.ProductCollections.Remove(productCollection);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductCollectionExists(int id)
        {
            return _context.ProductCollections.Any(e => e.Id == id);
        }
    }
}
