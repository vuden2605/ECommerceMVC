using System.ComponentModel.DataAnnotations;
namespace EcommerceMVC.Models {
    public class Product {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please enter a product name.")]
        public string ? Name { get; set; }
        public string ? Description { get; set; }
        public decimal Price { get; set; }
        public string ? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Please select a category.")]
        public Category Category { get; set; } = new Category();
        public Brand Brand { get; set; } = new Brand ();
    }
}