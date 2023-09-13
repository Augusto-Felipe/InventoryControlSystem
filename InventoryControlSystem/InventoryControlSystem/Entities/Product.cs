namespace InventoryControlSystem.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Product()
        {

        }

        public Product(string name)
        {
            Id = GenerateRandomId();
            Name = name;
        }

        private int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}
