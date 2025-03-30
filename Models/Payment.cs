using System.ComponentModel.DataAnnotations;
namespace EcommerceMVC.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        [StringLength(100)]
        public string ? PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public int OrderId { get; set; }
        public Order Order { get; set; } =  new Order();
    }
}