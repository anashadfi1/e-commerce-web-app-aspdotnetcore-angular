namespace E_Commerce.API.Models
{
    public class Buyer : User
    {
        public string ShippingAddress { get; set; }
        public override string GetRole() => "Buyer";
        // Buyer-specific properties/methods
        public void BrowseProducts() { /* logic here */ }
        public void PlaceOrder() { /* logic here */ }
        
    }
}
