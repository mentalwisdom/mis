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
    public class ProductOrderController : Controller
    {
        private readonly MISDbContext _context;

        public ProductOrderController(MISDbContext context)
        {
            _context = context;
        }

        // GET: ProductOrder
        public async Task<IActionResult> Index()
        {
            var mISDbContext = _context.ProductOrders.Include(p => p.orderStaus).Include(p => p.product);
            return View(await mISDbContext.ToListAsync());
        }//ef

        // GET: ProductOrder/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrder = await _context.ProductOrders
                .Include(p => p.orderStaus)
                .Include(p => p.product)
                .FirstOrDefaultAsync(m => m.product_order_id == id);
            if (productOrder == null)
            {
                return NotFound();
            }

            return View(productOrder);
        }//ef

        // GET: ProductOrder/Create
      
        public IActionResult Create()
        {
            ViewData["order_status_id"] = new SelectList(_context.OrderStatuses, "order_status_id", "order_status_name");
            ViewData["product_id"] = new SelectList(_context.Products, "product_id", "product_name");
            return View();
        }

        // POST: ProductOrder/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("product_order_id,product_id,qty,firstname,lastname,email,order_status_id")] ProductOrder productOrder)
        {
            //update product order status to the status "ordered"
            productOrder.order_status_id=1;
            if (ModelState.IsValid)
            {
                _context.Add(productOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["order_status_id"] = new SelectList(_context.OrderStatuses, "order_status_id", "order_status_name");
            ViewData["product_id"] = new SelectList(_context.Products, "product_id", "product_name");
            return View(productOrder);
        }//ef

        // GET: ProductOrder/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrder = await _context.ProductOrders.FindAsync(id);
            if (productOrder == null)
            {
                return NotFound();
            }
            ViewData["order_status_id"] = new SelectList(_context.OrderStatuses, "order_status_id", "order_status_name");
            ViewData["product_id"] = new SelectList(_context.Products, "product_id", "product_name");
            return View(productOrder);
        }

        // POST: ProductOrder/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("product_order_id,product_id,qty,firstname,lastname,email,order_status_id")] ProductOrder productOrder)
        {
            if (id != productOrder.product_order_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductOrderExists(productOrder.product_order_id))
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
            ViewData["order_status_id"] = new SelectList(_context.OrderStatuses, "order_status_id", "order_status_name");
            ViewData["product_id"] = new SelectList(_context.Products, "product_id", "product_name");
            return View(productOrder);
        }//ef

        // GET: ProductOrder/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrder = await _context.ProductOrders
                .Include(p => p.orderStaus)
                .Include(p => p.product)
                .FirstOrDefaultAsync(m => m.product_order_id == id);
            if (productOrder == null)
            {
                return NotFound();
            }

            return View(productOrder);
        }//ef

        // POST: ProductOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productOrder = await _context.ProductOrders.FindAsync(id);
            _context.ProductOrders.Remove(productOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//ef

        private bool ProductOrderExists(int id)
        {
            return _context.ProductOrders.Any(e => e.product_order_id == id);
        }//ef


        public IActionResult checkstatus(){
            return View("CheckStatus");
        }

        public IActionResult performstatuscheck(string first_name){
            //return Content("you have entered :"+ first_name);

            //search the product order based on the first name
            ProductOrder order= _context.ProductOrders
                                .Include(x=>x.orderStaus)
                                .Include(x=>x.product)
                                .FirstOrDefault(a => a.firstname==first_name);
            //if the function can not find any matches then it return nothing or null
            if(order == null){
                ViewBag.error = true;
                ViewBag.msg = "order not found";
            
            }
           else{
               ViewBag.error = false;
               ViewBag.full_name = order.firstname + " "+ order.lastname;
               ViewBag.product_name = order.product.product_name;
               ViewBag.order_status = order.orderStaus.order_status_name;
               ViewBag.qty = order.qty;
             
           }
             return  View("OrderStatus");

        }//ef

        //function to output order detail based on order_id
        //input: order_id
        //oput: order information detail

        [HttpGet]
        public IActionResult data1(int order_id){
            //work with the database to get order detail 
            if(order_id <= 0){
                return Content("order can not be found....");
            }
            //select * from productorder where product_order id = 'order-id'
            var result = _context.ProductOrders.FirstOrDefault(x=>x.product_order_id== order_id);
            return Json(result);
        }

        [HttpGet]
        public IActionResult data2(){
            var result = _context.ProductOrders
            .OrderBy(x=>x.qty)
            .Take(10);
            return Json(result);
        }
         [HttpGet]
        public IActionResult data3(){
            //perform data projection
            var result = _context.ProductOrders
                        .Select(order => new {
                            contact_email = order.email,
                            customer_name = order .firstname + " " + order.lastname,
                            product_name = order.product.product_name,
                            total = order.qty* order.product.price,
                            order_status = order.orderStaus.order_status_name
                        }).ToList();
            
            return Json(result);
        }

        public IActionResult data4(){
            //return raw data
            //return text Content()
            //return json Json()
            //return view with the data View(....)
            //return the table view that show order information including
            //customer name, product name, total and order_status
            //re order the product by order amount
            //the data will be displayed in the table format
            //select col1, col3, col4.. from productorder
            var result = _context.ProductOrders
                        .Select(a => new Report1Model{
                           name     =  a.product.product_name,
                           customer = a.firstname + " " + a.lastname,
                           status   = a.orderStaus.order_status_name,
                           total    = a.qty*a.product.price
                        }
                        )
                        .OrderByDescending(a => a.total)
                        
                        .ToList();

            //Hey man, I know that when you return the view along with result
            //you got another bag that i can put data. The name of that bag is call view bag
            ViewBag.total_order = result.Count;        
            ViewBag.message = "good";    
            return View("Report1",result);

        }


        
    }//ec
}//en
