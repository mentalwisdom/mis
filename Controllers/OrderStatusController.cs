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
    public class OrderStatusController : Controller
    {
        private readonly MISDbContext _context;

        public OrderStatusController(MISDbContext context)
        {
            _context = context;
        }

        // GET: OrderStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrderStatuses.ToListAsync());
        }//ef

        // GET: OrderStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderStatus = await _context.OrderStatuses
                .FirstOrDefaultAsync(m => m.order_status_id == id);
            if (orderStatus == null)
            {
                return NotFound();
            }

            return View(orderStatus);
        }//ef

        // GET: OrderStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("order_status_id,order_status_name")] OrderStatus orderStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderStatus);
        }//ef

        // GET: OrderStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderStatus = await _context.OrderStatuses.FindAsync(id);
            if (orderStatus == null)
            {
                return NotFound();
            }
            return View(orderStatus);
        }

        // POST: OrderStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("order_status_id,order_status_name")] OrderStatus orderStatus)
        {
            if (id != orderStatus.order_status_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderStatusExists(orderStatus.order_status_id))
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
            return View(orderStatus);
        }//ef

        // GET: OrderStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderStatus = await _context.OrderStatuses
                .FirstOrDefaultAsync(m => m.order_status_id == id);
            if (orderStatus == null)
            {
                return NotFound();
            }

            return View(orderStatus);
        }//ef

        // POST: OrderStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderStatus = await _context.OrderStatuses.FindAsync(id);
            _context.OrderStatuses.Remove(orderStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//ef

        private bool OrderStatusExists(int id)
        {
            return _context.OrderStatuses.Any(e => e.order_status_id == id);
        }//ef
    }
}
