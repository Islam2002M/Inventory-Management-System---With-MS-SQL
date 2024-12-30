
using PublisherData;
using PublisherDomain;

namespace InventorySystem
{
    public class InventoryManager
    {
         private readonly InventoryDBContext _context;

        public InventoryManager()
        {
            _context = new InventoryDBContext();
        }

        public void AddProduct(string name, double price, Currency currency, int quantity)
        {
            var product = new Product
            {
                Name = name,
                Price = new Price(price, currency),
                Quantity = quantity
            };

            _context.Products.Add(product);
            _context.SaveChanges();
            Console.WriteLine("Product added successfully.");
        }

        public void ViewProducts()
        {
            var products = _context.Products.ToList();
            if (products.Any())
            {
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.WriteLine("No products available.");
            }
        }

        public void EditProduct(int id, string newName = null, double? newPrice = null, Currency? newCurrency = null, int? newQuantity = null)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                if (!string.IsNullOrEmpty(newName)) product.Name = newName;
                if (newPrice.HasValue && newCurrency.HasValue) product.Price = new Price(newPrice.Value, newCurrency.Value);
                if (newQuantity.HasValue) product.Quantity = newQuantity.Value;

                _context.SaveChanges();
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
    
}