using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcommerceMVC.Data;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Identity;

namespace EcommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly EcommerceDbContext _context;

        public ProductController(EcommerceDbContext context)
        {
            _context = context;
        }

        // GET: Product
        public async Task<IActionResult> Index(int? CategoryId, string? Name, int? Page) {
            var totalItems = await _context.Products.CountAsync();
            var products = await _context.Products
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();
            var products = CategoryId == null 
                ? await _context.Products.ToListAsync() 
                : await _context.Products.Where(p => p.CategoryId == CategoryId).ToListAsync();

            products = Name == null ? products:products.Where(p =>p.Name !=null && p.Name.Contains(Name)).ToList();
            return View(products);
        }
        // GET: Product/Details/5
        public async Task<IActionResult> Details (int? id) {
            if (id == null) {
                return NotFound();
            }
            var product =await _context.Products.FirstOrDefaultAsync (p=>p.ProductId ==id);
            if (product == null) { 
                return NotFound();
            }
            return View(product);
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
