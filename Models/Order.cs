using System.ComponentModel.DataAnnotations;
namespace EcommerceMVC.Models {
    public class Order {
        [Key]
        public int OrderId { get; set; }
        public string ? Address { get; set; }
        public string ? Phone { get; set; }
        public decimal Total { get; set; }
        public string ? UserId { get; set; }
        public User User { get; set; } =new  User ();
        public DateTime CreatedDate { get; set; }=DateTime.UtcNow;
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();  
    }
}