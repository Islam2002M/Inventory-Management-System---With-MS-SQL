
using PublisherDomain;

namespace InventorySystem
{
     class Program
    {
        static void Main(string[] args)
        {
            var manager = new InventoryManager();
            int choice;

            do
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Edit Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        var name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        var price = double.Parse(Console.ReadLine());
                        Console.Write("Enter product currency (Dollar, Shekel, Dinar): ");
                        var currency = (Currency)Enum.Parse(typeof(Currency), Console.ReadLine());
                        Console.Write("Enter product quantity: ");
                        var quantity = int.Parse(Console.ReadLine());

                        manager.AddProduct(name, price, currency, quantity);
                        break;

                    case 2:
                        manager.ViewProducts();
                        break;

                    case 3:
                        Console.Write("Enter product ID to edit: ");
                        var id = int.Parse(Console.ReadLine());
                        Console.Write("Enter new name (leave blank to skip): ");
                        var newName = Console.ReadLine();
                        Console.Write("Enter new price (leave blank to skip): ");
                        var newPriceInput = Console.ReadLine();
                        double? newPrice = string.IsNullOrEmpty(newPriceInput) ? null : double.Parse(newPriceInput);
                        Console.Write("Enter new currency (leave blank to skip): ");
                        var newCurrencyInput = Console.ReadLine();
                        Currency? newCurrency = string.IsNullOrEmpty(newCurrencyInput) ? null : (Currency)Enum.Parse(typeof(Currency), newCurrencyInput);
                        Console.Write("Enter new quantity (leave blank to skip): ");
                        var newQuantityInput = Console.ReadLine();
                        int? newQuantity = string.IsNullOrEmpty(newQuantityInput) ? null : int.Parse(newQuantityInput);

                        manager.EditProduct(id, newName, newPrice, newCurrency, newQuantity);
                        break;

                    case 4:
                        Console.Write("Enter product ID to delete: ");
                        var deleteId = int.Parse(Console.ReadLine());
                        manager.DeleteProduct(deleteId);
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 5);
        }
    }

}
