namespace E_Commerce.API.Models
{
    public class Seller : User
    {
        public override string GetRole() => "Seller";

        // Seller-specific properties/methods
        public string StoreName { get; set; }
        public void ManageProducts() { /* logic here */ }
        public void ViewOrders() { /* logic here */ }
    }
}
