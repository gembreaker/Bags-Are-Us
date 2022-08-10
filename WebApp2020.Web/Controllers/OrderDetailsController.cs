using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp2020.Shared.Models;

using System.Security.Claims;

using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace WebApp2020.Web.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly WebApp2020DbContext _context;
        private readonly IConfiguration _configuration;

        public OrderDetailsController(WebApp2020DbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // GET: OrderDetails
        [Authorize]
        public async Task<IActionResult> Index()
        {
            // Get the user's details
            var user = HttpContext.User;

            // if user is logged in, set user id, email 
            if (user.Identity.IsAuthenticated)
            {
                // Get user's role
                var userRole = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value;

                // Get the current user's ID
                var userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

                // Find the current user's bookings (don't show for other people) and include the film and/or film showing details           
                var webApp2020DbContext = _context.OrderDetails.Include(o => o.PaymentType).Include(o => o.Product).Include(o => o.User).Where(o => o.CustomerId == userId);

                if (userRole == _configuration["ApplicationUsers:Roles:AdminRole"])
                {
                    webApp2020DbContext = _context.OrderDetails.Include(o => o.PaymentType).Include(o => o.Product).Include(o => o.User); // Complete the code (same as previous but no WHERE);
                }

                return View(await webApp2020DbContext.ToListAsync());
            }
            else // user not logged in, should not be able to see bookings
            {
                // Not authorised, go back to films page
                return RedirectToAction("Index", "ProductDetails");
            }
        }

        // GET: OrderDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetails = await _context.OrderDetails
                .Include(o => o.PaymentType)
                .Include(o => o.Product)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (orderDetails == null)
            {
                return NotFound();
            }

            return View(orderDetails);
        }

        // GET: OrderDetails/Create
        public IActionResult Create(int ProductCode)
        {
            ViewData["PaymentTypeId"] = new SelectList(_context.PaymentType, "PaymentTypeId", "ExpirationDate");
            ViewData["ProductCode"] = new SelectList(_context.ProductDetails, "ProductCode", "ProductName");
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "Id");

            var order = new OrderDetails
            {
                DateOrdered = DateTime.Now,
                DatePurchased = DateTime.Now,
                Product = _context.ProductDetails.Where(p => p.ProductCode == ProductCode).Include(p => p.BagType).Include(p => p.Colour).Include(p => p.Range).FirstOrDefault(),
            };

            // Get the user's details
            var user = HttpContext.User;

            // If user if logged in, set user id, email
            if(user.Identity.IsAuthenticated)
            {
                order.CustomerId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            }

            return View(order);
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,CustomerId,PaymentTypeId,DateOrdered,DatePurchased,Quantity,ProductCode")] OrderDetails orderDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PaymentTypeId"] = new SelectList(_context.PaymentType, "PaymentTypeId", "ExpirationDate", orderDetails.PaymentTypeId);
            ViewData["ProductCode"] = new SelectList(_context.ProductDetails, "ProductCode", "ProductName", orderDetails.ProductCode);
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "Id", orderDetails.CustomerId);
            return View(orderDetails);
        }

        // GET: OrderDetails/Edit/5
        [Authorize(Policy = "IsAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetails = await _context.OrderDetails.FindAsync(id);
            if (orderDetails == null)
            {
                return NotFound();
            }
            ViewData["PaymentTypeId"] = new SelectList(_context.PaymentType, "PaymentTypeId", "ExpirationDate", orderDetails.PaymentTypeId);
            ViewData["ProductCode"] = new SelectList(_context.ProductDetails, "ProductCode", "ProductName", orderDetails.ProductCode);
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "Id", orderDetails.CustomerId);
            return View(orderDetails);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Policy = "IsAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,CustomerId,PaymentTypeId,DateOrdered,DatePurchased,Quantity,ProductCode")] OrderDetails orderDetails)
        {
            if (id != orderDetails.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderDetailsExists(orderDetails.OrderId))
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
            ViewData["PaymentTypeId"] = new SelectList(_context.PaymentType, "PaymentTypeId", "ExpirationDate", orderDetails.PaymentTypeId);
            ViewData["ProductCode"] = new SelectList(_context.ProductDetails, "ProductCode", "ProductName", orderDetails.ProductCode);
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "Id", orderDetails.CustomerId);
            return View(orderDetails);
        }

        // GET: OrderDetails/Delete/5
        [Authorize(Policy = "IsAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetails = await _context.OrderDetails
                .Include(o => o.PaymentType)
                .Include(o => o.Product)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (orderDetails == null)
            {
                return NotFound();
            }

            return View(orderDetails);
        }

        // POST: OrderDetails/Delete/5
        [Authorize(Policy = "IsAdmin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderDetails = await _context.OrderDetails.FindAsync(id);
            _context.OrderDetails.Remove(orderDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderDetailsExists(int id)
        {
            return _context.OrderDetails.Any(e => e.OrderId == id);
        }
    }
}
