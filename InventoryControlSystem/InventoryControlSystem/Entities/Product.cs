namespace InventoryControlSystem.Entities
{
    internal class Product
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Product()
        {

        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public void ListProducts(Product product)
        {

        }
    }
}
