using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LaptopStore.Data;
using LaptopStore.Models;
using LaptopStore.Repositories;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace LaptopStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(
            IProductsRepository productsRepository,
            ILogger<ProductsController> logger)
        {
            _productsRepository = productsRepository ?? throw new ArgumentNullException(nameof(productsRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            
            _logger.LogInformation("In the products controller constructor");
        }

        private void setCartItemCount()
        {
            var cartItemCount = HttpContext.Session.GetInt32("CartItemCount");
            ViewData["CartItemCount"] = cartItemCount == null ? 0 : cartItemCount.Value;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            setCartItemCount();
            return View(await _productsRepository.GetAllAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? productId)
        {
            setCartItemCount();
            if (productId == null)
            {
                return NotFound();
            }

            var product = await _productsRepository.FindAsync(productId.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            setCartItemCount();
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Brand,Price,Thumbnail")] Product product)
        {
            setCartItemCount();
            if (ModelState.IsValid)
            {
                _productsRepository.Add(product);
                await _productsRepository.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? productId)
        {
            setCartItemCount();
            if (productId == null)
            {
                return NotFound();
            }

            var product = await _productsRepository.FindAsync(productId.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Brand,Price,Thumbnail")] Product product)
        {
            setCartItemCount();
            if (id != product.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _productsRepository.Update(product);
                    await _productsRepository.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _productsRepository.ExistsByIdAsync(product.ID))
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
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? productId)
        {
            setCartItemCount();
            if (productId == null)
            {
                return NotFound();
            }

            var product = await _productsRepository.FindAsync(productId.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            setCartItemCount();
            await _productsRepository.RemoveByIdAsync(id);
            await _productsRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
