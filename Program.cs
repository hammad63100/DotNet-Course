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




// class Program{
//     public static void Main(){
//         Console.WriteLine("Welcome to My First VS Code .NET Project!");
//         const int a = 10;
//        // a = 20;
//         Console.WriteLine(a);

//     }
// }





//operator

// //preincrement
// class Program
// {
//     public static void Main()
//     {
//         int a = 10, b;
//         b = ++a; // Assigns the current value of a (10) to b, then increments a to 11
//         Console.WriteLine(b); // Outputs the value of b, which is 10
//         Console.WriteLine(a); 
//     }
// }
// 
// //postincrement
// class Program
// {
//     public static void Main()
//     {
//         int a = 10, b;
//         b = a++; // Assigns the current value of a (10) to b,
//         // then increments a to 11
//         Console.WriteLine(b); // Outputs the value of b, which is 10
//         Console.WriteLine(a); // Outputs the value of a, which is 11
//     }
// }




// //predecrement
// class Program
// {
//     public static void Main()
//     {
//         int a = 10, b;
//         b = --a; // Assigns the current value of a (10) to b, then increments a to 11
//         Console.WriteLine(b); // Outputs the value of b, which is 10
//         Console.WriteLine(a); 
//     }
// }




// //postdencrement
// class Program
// {
//     public static void Main()
//     {
//         int a = 10, b;
//         b = a--; // Assigns the current value of a (10) to b,
//         // then increments a to 11
//         Console.WriteLine(b); // Outputs the value of b, which is 10
//         Console.WriteLine(a); // Outputs the value of a, which is 11
//     }
// }




//  //assigment
// class Program
// {
//     public static void Main()
//     {
//         int a = 10;
//         a+=5;
//         a*=6;
//        // Console.WriteLine(b); // Outputs the value of b, which is 10
//         Console.WriteLine(a); // Outputs the value of a, which is 11
//     }
// }






//ternary operator
// class Program
// {
//     public static void Main()
//     {
//         int a = 10, b=50;
//         string s = (a > b)? "A is greater" : "B is greater";
//         Console.WriteLine(s); // Outputs the value of a, which is 11
//     }
// }



// // if 
// class Program{
//     public static void Main(){
//         int salary = 9000;
//         if(salary < 10000){
//            salary = salary + 1000;
//         }
//             Console.WriteLine(salary);            

//     }
// }




// // if else
// class Program{
//     public static void Main(){
//         int num = 6;
//         if(num%2 == 0)
//         {
//            Console.WriteLine("Even");
//         }
//         else{
//             Console.WriteLine("Odd");
//         }


//     }
// }




// // if else
// class Program{
//     public static void Main(){
//        string username = "xyz";
//        string password = "abc";
//         if(username.Equals("xyz") && password.Equals("abc"))
//         {
//            Console.WriteLine("Login Successfully");
//         }
//         else{
//             Console.WriteLine("Login Unsuccessfully");
//         }


//     }
// }





// // if else and elseif

// class Program
// {
//     public static void Main()
//     {
//         int a = 50, b = 30, c = 25;

//         if (a > b && a > c)
//         {
//             Console.WriteLine("A is greater");
//         }
//         else if (b > a && b > c)
//         {
//             Console.WriteLine("B is greater");
//         }
//         else
//         {
//             Console.WriteLine("C is greater");
//         }
//     }
// }




class Program
{
    public static void Main()
    {
        int a = 50, b = 30, c = 25;

        // First, find the maximum and minimum
        int max = Math.Max(a, Math.Max(b, c));
        int min = Math.Min(a, Math.Min(b, c));
        
        // The middle number will be the one that is not max or min
        int middle = a + b + c - max - min;

        Console.WriteLine("The middle number is: " + middle);
    }
}