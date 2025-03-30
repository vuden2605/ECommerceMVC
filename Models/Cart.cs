using System.ComponentModel.DataAnnotations;
namespace EcommerceMVC.Models
{
    public class Cart
    {   
        [Key]
        public int CartId { get; set; }
        public string ? UserId { get; set; }
        public User User {get; set; } = new User ();
        public List<CartItem> Items { get; set; } = new List<CartItem>();
    }

    
}