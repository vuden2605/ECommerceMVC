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
            int pageSize = 12;
            int pageNumber = Page ?? 1; 
            var query= _context.Products.AsQueryable();
            if (CategoryId.HasValue) {
                query=query.Where(p => p.CategoryId==CategoryId);
            }
            if(!string.IsNullOrEmpty(Name)){
                query=query.Where(p => p.Name != null && p.Name.Contains(Name));
            }
            int totalItems= await query.CountAsync();
            var products= await query.Skip((pageNumber-1)*pageSize).Take(pageSize).ToListAsync();
            ViewBag.totalItems=totalItems;
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
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
