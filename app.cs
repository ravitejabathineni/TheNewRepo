using System;
using System.Collections.Generic;

namespace InventoryApp
{
    // Base Class demonstrating Encapsulation
    public class Product
    {
        // Auto-implemented properties
        public string Name { get; set; }
        public double Price { get; set; }

        // Constructor
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Virtual method to allow Polymorphism
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product: {Name} | Price: ${Price:F2}");
        }
    }

    // Derived Class demonstrating Inheritance
    public class Electronics : Product
    {
        public int WarrantyMonths { get; set; }

        // Constructor chaining using 'base'
        public Electronics(string name, double price, int warrantyMonths) 
            : base(name, price)
        {
            WarrantyMonths = warrantyMonths;
        }

        // Method Overriding (Polymorphism)
        public override void DisplayDetails()
        {
            Console.WriteLine($"[Electronics] {Name} | Price: ${Price:F2} | Warranty: {WarrantyMonths} months");
        }
    }

    class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Inventory Management Sample ===");

            // Creating a generic List collection to store products
            List<Product> inventory = new List<Product>
            {
                new Product("Coffee Mug", 12.99),
                new Electronics("Smartphone", 799.99, 24),
                new Product("Notebook", 4.50),
                new Electronics("Headphones", 149.99, 12)
            };

            // Iterating over the collection using a foreach loop
            foreach (Product item in inventory)
            {
                // Calls the overridden method dynamically at runtime
                item.DisplayDetails();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
