using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MIS.Data;
using MIS.Models;

namespace mis.Controllers
{
    public class ProductController : Controller
    {
        private readonly MISDbContext _context;

        public ProductController(MISDbContext context)
        {
            _context = context;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            var mISDbContext = _context.Products.Include(p => p.productGroup);
            return View(await mISDbContext.ToListAsync());
        }//ef

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.productGroup)
                .FirstOrDefaultAsync(m => m.product_id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }//ef

        // GET: Product/Create
        public IActionResult Create()
        {
            ViewData["product_group_id"] = new SelectList(_context.ProductGroups, "product_group_id", "product_group_name");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("product_id,product_name,qty,price,product_group_id,pic")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["product_group_id"] = new SelectList(_context.ProductGroups, "product_group_id", "product_group_name");
            return View(product);
        }//ef

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["product_group_id"] = new SelectList(_context.ProductGroups, "product_group_id", "product_group_name");
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("product_id,product_name,qty,price,product_group_id,pic")] Product product)
        {
            if (id != product.product_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.product_id))
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
            ViewData["product_group_id"] = new SelectList(_context.ProductGroups, "product_group_id", "product_group_name");
            return View(product);
        }//ef

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.productGroup)
                .FirstOrDefaultAsync(m => m.product_id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }//ef

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//ef

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.product_id == id);
        }//ef
          //create a function/action to generate a data service 
        //data service API (Application Programming Interface)
        public IActionResult do1(){
            //just like to query the database and get all the data row from table product
            //turn the list from the memory into JSON format 
             var result = _context.Products.Select(apple => new {
                 name = apple.product_name,
                 price = apple.price,
                 group = apple.productGroup.product_group_name
             });
             return Json(result);

        }//ef
        
    }//ec
}//en
