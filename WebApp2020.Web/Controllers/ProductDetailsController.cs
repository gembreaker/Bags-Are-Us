using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp2020.Shared.Models;

using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.Extensions.Configuration;

using WebApp2020.Shared.ViewModels;
using WebApp2020.Shared.Queryables;

using Microsoft.AspNetCore.Authorization;

namespace WebApp2020.Web.Controllers
{
    public class ProductDetailsController : Controller
    {
        private readonly WebApp2020DbContext _context;
        private readonly IConfiguration _config;

        public ProductDetailsController(WebApp2020DbContext context, IConfiguration configuration)
        {
            _context = context;
            _config = configuration;
        }

        // GET: ProductDetails
        public async Task<IActionResult> Index()
        {
            var webApp2020DbContext = _context.ProductDetails.Include(p => p.BagType).Include(p => p.Colour).Include(p => p.Range).AsQueryable();

            // Create a new FilmFilterViewModel object for the user to specify the filtering and paging criteria
            ProductsFilterViewModel productsFilter = new ProductsFilterViewModel();

            // Count the film records
            productsFilter.RecordCount = await webApp2020DbContext.CountAsync();

            // Apply the paging (fetch range) criteria to the films
            webApp2020DbContext = ProductFilterQueries.ApplyQueryFetchRange(webApp2020DbContext, productsFilter);

            // Send the Paging and Filtering view model, FilmFilterViewModel, (filmsFilter variable) to the view
            ViewData["ProductsFilter"] = productsFilter;

            return View(await webApp2020DbContext.ToListAsync());
        }

        // POST: ProductDetails
        [HttpPost]
        public async Task<IActionResult> Index(ProductsFilterViewModel productsFilter)
        {
            var webApp2020DbContext = _context.ProductDetails.Include(p => p.BagType).Include(p => p.Colour).Include(p => p.Range).AsQueryable();

            // Apply the filter criteria to the products
            webApp2020DbContext = ProductFilterQueries.ApplyQueryFilter(webApp2020DbContext, productsFilter);

            // Count the film records
            productsFilter.RecordCount = await webApp2020DbContext.CountAsync();

            // Update the current page if necessary
            if (productsFilter.PageNumber > productsFilter.PageCount)
                productsFilter.PageNumber = 1;

            // Apply the sorting functionality
            webApp2020DbContext = ProductFilterQueries.ApplyQuerySort(webApp2020DbContext, productsFilter);

            // Apply the paging (fetch range) criteria to the films
            webApp2020DbContext = ProductFilterQueries.ApplyQueryFetchRange(webApp2020DbContext, productsFilter);

            // Send the Paging and Filtering view model, FilmFilterViewModel, (filmsFilter variable) to the view
            ViewData["ProductsFilter"] = productsFilter;

            return View(await webApp2020DbContext.ToListAsync());
        }

        // GET: ProductDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productDetails = await _context.ProductDetails
                .Include(p => p.BagType)
                .Include(p => p.Colour)
                .Include(p => p.Range)
                .FirstOrDefaultAsync(m => m.ProductCode == id);
            if (productDetails == null)
            {
                return NotFound();
            }

            return View(productDetails);
        }

        // GET: ProductDetails/Create
        [Authorize(Policy = "IsAdmin")]
        public IActionResult Create()
        {
            ViewData["BagTypeId"] = new SelectList(_context.BagType, "BagTypeId", "BagType1");
            ViewData["ColourId"] = new SelectList(_context.Colour, "ColourId", "ColourName");
            ViewData["RangeId"] = new SelectList(_context.RangeType, "RangeId", "RangeName");
            return View();
        }

        // POST: ProductDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Policy = "IsAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductCode,ProductName,Description,ColourId,ProductImage,Price,RangeId,BagTypeId,ProductImageFile")] ProductDetails productDetails)
        {
            if (ModelState.IsValid)
            {
                // Upload spec image files UploadPoster function
                // If upload successful random file name created security
                // Set ProductImage properties to new random file name
                productDetails.ProductImage = await UploadPosterImage(productDetails.ProductImageFile, productDetails.ProductImage);

                _context.Add(productDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BagTypeId"] = new SelectList(_context.BagType, "BagTypeId", "BagType1", productDetails.BagTypeId);
            ViewData["ColourId"] = new SelectList(_context.Colour, "ColourId", "ColourName", productDetails.ColourId);
            ViewData["RangeId"] = new SelectList(_context.RangeType, "RangeId", "RangeName", productDetails.RangeId);
            return View(productDetails);
        }

        // GET: ProductDetails/Edit/5
        [Authorize(Policy = "IsAdmin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productDetails = await _context.ProductDetails.FindAsync(id);
            if (productDetails == null)
            {
                return NotFound();
            }
            ViewData["BagTypeId"] = new SelectList(_context.BagType, "BagTypeId", "BagType1", productDetails.BagTypeId);
            ViewData["ColourId"] = new SelectList(_context.Colour, "ColourId", "ColourName", productDetails.ColourId);
            ViewData["RangeId"] = new SelectList(_context.RangeType, "RangeId", "RangeName", productDetails.RangeId);
            return View(productDetails);
        }

        // POST: ProductDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Policy = "IsAdmin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductCode,ProductName,Description,ColourId,ProductImage,Price,RangeId,BagTypeId,ProductImageFile")] ProductDetails productDetails)
        {
            if (id != productDetails.ProductCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    productDetails.ProductImage = await UploadPosterImage(productDetails.ProductImageFile, productDetails.ProductImage);

                    _context.Update(productDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductDetailsExists(productDetails.ProductCode))
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
            ViewData["BagTypeId"] = new SelectList(_context.BagType, "BagTypeId", "BagType1", productDetails.BagTypeId);
            ViewData["ColourId"] = new SelectList(_context.Colour, "ColourId", "ColourName", productDetails.ColourId);
            ViewData["RangeId"] = new SelectList(_context.RangeType, "RangeId", "RangeName", productDetails.RangeId);
            return View(productDetails);
        }

        // GET: ProductDetails/Delete/5
        [Authorize(Policy = "IsAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productDetails = await _context.ProductDetails
                .Include(p => p.BagType)
                .Include(p => p.Colour)
                .Include(p => p.Range)
                .FirstOrDefaultAsync(m => m.ProductCode == id);
            if (productDetails == null)
            {
                return NotFound();
            }

            return View(productDetails);
        }

        // POST: ProductDetails/Delete/5
        [Authorize(Policy = "IsAdmin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productDetails = await _context.ProductDetails.FindAsync(id);
            _context.ProductDetails.Remove(productDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductDetailsExists(int id)
        {
            return _context.ProductDetails.Any(e => e.ProductCode == id);
        }

        private async Task<string> UploadPosterImage(IFormFile posterFile, string currentPosterFile)
        {
            // Check if poster file to upload has been specified
            if (posterFile != null && !string.IsNullOrEmpty(posterFile.FileName))
            {
                try
                {
                    //// Ideally some server-side validation should also be carried out
                    //// E.g. check extension again, file size not more than max etc.
                    //// See: https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation


                    // Generate a new random file name - never use a user file name in case it is malicious
                    // See more: https://docs.microsoft.com/en-us/aspnet/core/mvc/models/file-uploads?view=aspnetcore-2.2#security-considerations
                    string randomFileName = Path.GetRandomFileName();

                    // Set the file extension to the same as the original file, otherwise it may not be displayed in the browser
                    randomFileName = Path.ChangeExtension(randomFileName, Path.GetExtension(posterFile.FileName));


                    // Combine the random file name with the path of the folder dedicated for storing poster images
                    // The path is stored in the appsettings.json file
                    string savedFileName = Path.Combine(_config["StoredFilesPath:StoredProductImagesPath"], randomFileName);


                    // Copy the file with the new file name to the folder dedicated for storing poster images
                    using (var stream = System.IO.File.Create(savedFileName))
                    {
                        await posterFile.CopyToAsync(stream);
                    }

                    // return the random file name so this can be stored in the database
                    return randomFileName;
                }
                catch (Exception ex) when (ex is FileNotFoundException || ex is UnauthorizedAccessException)
                {
                    // an error has occurred, rethrow the error to the calling function
                    throw;
                }
            }

            // return the current poster file name, i.e. original nane before update
            return currentPosterFile;
        }
    }
}