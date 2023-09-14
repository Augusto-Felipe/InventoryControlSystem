using InventoryControlSystem.Entities;

namespace InventoryControlSystem.Repositories
{
    internal class ProductRepository
    {
        private static ProductRepository instance;
        public static ProductRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductRepository();
                }
                return instance;
            }
        }

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
