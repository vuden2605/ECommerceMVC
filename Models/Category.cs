using System.ComponentModel.DataAnnotations;
namespace EcommerceMVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please enter a category name.")]
        [StringLength(100)]
        public string ? Name { get; set; }
        public string ? Description { get; set; }
        public List<Product>  Products { get; set; } = new List<Product>();
    }
}