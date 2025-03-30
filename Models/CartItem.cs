namespace EcommerceMVC.Models {
   public class CartItem
    {   
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string ? ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; } = new();
    }
}