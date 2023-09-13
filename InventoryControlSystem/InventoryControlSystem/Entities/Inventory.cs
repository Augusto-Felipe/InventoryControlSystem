namespace InventoryControlSystem.Entities
{
    internal class Inventory
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public List<Product> ListProducts()
        {
            return Products;
        }
    }
}
