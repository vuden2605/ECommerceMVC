using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Required]
        [StringLength(100)]
        public string ? Name { get; set; }
        [StringLength(255)]
        public string ? Description { get; set; }
        public List<Product> Product { get; set; } = new List<Product> ();

    }
}