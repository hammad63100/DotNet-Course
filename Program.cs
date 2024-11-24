// // Program.cs
// using MyFirstProject.Models;
// using MyFirstProject.Services;

// namespace MyFirstProject;

// class Program
// {
//     static async Task Main(string[] args)
//     {
//         Console.WriteLine("Welcome to My First VS Code .NET Project!");

//         var productService = new ProductService();
        
//         // Add some products
//         productService.AddProduct(new Product { Id = 1, Name = "Laptop", Price = 999.99m });
//         productService.AddProduct(new Product { Id = 2, Name = "Mouse", Price = 29.99m });

//         // Display all products
//         var products = productService.GetAllProducts();
//         foreach (var product in products)
//         {
//             Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
//         }

//         // Example of using async/await
//         await Task.Delay(1000); // Simulating some async work
//         Console.WriteLine("\nProcessing complete!");

//         Console.WriteLine("\nPress any key to exit...");
//         Console.ReadKey();
//     }
// }




class Program{
    public static void Main(){
        Console.WriteLine("Welcome to My First VS Code .NET Project!");
        const int a = 10;
       // a = 20;
        Console.WriteLine(a);
        
    }
}