namespace E_Commerce.API.Models
{
    public class Admin : User
    {
        public override string GetRole() => "Admin";

        // Admin-specific properties/methods
        public void ManageUsers() { /* logic here */ }
        public void ManageProducts() { /* logic here */ }
    }
}
