using System.ComponentModel.DataAnnotations;
namespace EcommerceMVC.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Product  Product { get; set; } = new();   
        public Order Order { get; set; } = new();
    }
}