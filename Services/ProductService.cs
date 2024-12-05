
// // Services/ProductService.cs
// namespace MyFirstProject.Services;

// using MyFirstProject.Models;

// public class ProductService
// {
//     private List<Product> _products = new();

//     public void AddProduct(Product product)
//     {
//         _products.Add(product);
//     }

//     public List<Product> GetAllProducts()
//     {
//         return _products;
//     }

//     public Product? GetProductById(int id)
//     {
//         return _products.FirstOrDefault(p => p.Id == id);
//     }
// }