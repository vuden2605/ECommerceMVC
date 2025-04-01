using EcommerceMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Components
{
    public class CategoryViewComponent : ViewComponent {
        public readonly EcommerceDbContext _context;
        public CategoryViewComponent(EcommerceDbContext context) {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync() {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
    }
}