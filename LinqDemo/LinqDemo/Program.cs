using System;
using System.Collections.Generic;
using System.Linq;  // Required for LINQ

// Define the Product class
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        // Step 1: Create a list of products
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 800 },
            new Product { Name = "Smartphone", Price = 500 },
            new Product { Name = "Tablet", Price = 300 },
            new Product { Name = "Headphones", Price = 100 },
            new Product { Name = "Smartwatch", Price = 200 }
        };

        // Step 2: Use LINQ to filter and sort products by price (ascending)
        var filteredProducts = products
            .Where(p => p.Price > 200)  // Filter: Price > 200
            .OrderBy(p => p.Price);     // Order: Ascending

        // Step 3: Display the filtered products (Ascending order)
        Console.WriteLine("Filtered Products (Price > 200, Ordered by Price Ascending):");
        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"{product.Name} - ${product.Price}");
        }

        // Step 4: Use LINQ to filter and sort products by price (descending)
        var filteredProductsDesc = products
            .Where(p => p.Price > 200)
            .OrderByDescending(p => p.Price);  // Order: Descending

        // Step 5: Display the filtered products (Descending order)
        Console.WriteLine("\nFiltered Products (Price > 200, Ordered by Price Descending):");
        foreach (var product in filteredProductsDesc)
        {
            Console.WriteLine($"{product.Name} - ${product.Price}");
        }
    }
}
