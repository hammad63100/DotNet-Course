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




//  //assignments
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


// middle number find
//class Program
// {
//     public static void Main()
//     {
//         int a = 50, b = 30, c = 25;

//         if ((a > b && a < c) || (a < b && a > c))
//         {
//             Console.WriteLine("A is the middle number: {0}", a);
//         }
//         else if ((b > a && b < c) || (b < a && b > c))
//         {
//             Console.WriteLine("B is the middle number: {0}", b);
//         }
//         else
//         {
//             Console.WriteLine("C is the middle number: {0}", c);
//         }
//     }
// }







//nested if else

// class Program
// {
//     public static void Main()
//     {
//         int a = 50, b = 70, c = 25;

//         if (a > b )
//         {
//             if(a > c){
//             Console.WriteLine("A is greater");
//             }
//             else{  
//                 Console.WriteLine("C is greater");
//             }
//         }
//         else
//         {
//             if (b > c){
//                 Console.WriteLine("B is greater");
//             }
//             else{
//             Console.WriteLine("C is greater");
//             }
//         }
//     }
// }











//if if if 

// class Program{
//     public static void Main(){
//         int a = 50;
//         if(a%3 == 0){
//             Console.WriteLine("Models 50 by 3");
//         }
//         if(a%5 == 0){
//             Console.WriteLine("Models 50 by 5");
//         }
//         if(a%7 == 0){
//             Console.WriteLine("Models 50 by 7");
//         }
//         if(a%8 == 0){
//             Console.WriteLine("Models 50 by 8");
//         }
//         if(a%2 == 0){
//             Console.WriteLine("Modals 50 by 2");
//         }
//     }
// }



// //switch

// class Program{
//     public static void Main(){
//         char ch = 'A';
//         switch(ch){
//             case 'A':
//             case 'E':
//             case 'I':
//             case 'O':
//             case 'U':
//                 Console.WriteLine("Vowel");
//             break;
//         default:
//         Console.WriteLine("Consonant");
//         break;

//     }
// }
// }





// //nested switch

// class Program
// {
//     public static void Main()
//     {
//         int age = 25;
//         string gender = "Male";
//         switch (age)
//         {
//             case 10:
//                 switch (gender)
//                 {
//                     case "Male":
//                         Console.WriteLine("Boy");
//                         break;
//                     default:
//                         Console.WriteLine("Girl");
//                         break;
//                 }
//                 break;
//             case 25:
//                 switch (gender)
//                 {
//                     case "Male":
//                         Console.WriteLine("Male");
//                         break;
//                     default:
//                         Console.WriteLine("Female");
//                         break;
//                 }
//                 break;

//             default:
//                 Console.WriteLine("Mention Age");
//                 break;

//         }
//     }
// }



// function overloading

// class Addition{
//     void add(int x, int y){
//         Console.WriteLine("Sum of two integers: "+(x+y));
//     }
//     void add(int x, int y, int z){
//         Console.WriteLine("Sum of three integers: "+(x+y+z));
//     }
//     void add(float x, int y){
//         Console.WriteLine("Sum of two integers: "+(x+y));
//     }
//     void add(int x, float y){
//         Console.WriteLine("Sum of two integers: "+(x+y));
//     }
//     void add(float x, float y){
//         Console.WriteLine("Sum of two integers: "+(x+y));
//     }

//     public static void Main(){
//         Addition obj = new Addition();
//         obj.add(10, 20);
//         obj.add(10, 20,30);
//     }
// }



// function overriding
// class Admin
// {
//     int id;
//     string? name; // Nullable string

//     // Method to accept input
//     public void Accept(int id, string name)
//     {
//         this.id = id;
//         this.name = name;
//     }

//     // Method to display the values
//     public void Display()
//     {
//         Console.WriteLine("Id is {0} and name is {1}", id, name);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Admin admin = new Admin();

//         // Accepting values
//         admin.Accept(1, "John Doe");       

//         // Displaying values
//         admin.Display();
//     }
// }





// // inhabitance
// class Employee:Admin{
//     int salary;

//     internal void Accept1(int salary){
//         this.salary = salary;

//      }

//     internal void Display(){
//         Console.WriteLine( salary.ToString());
//      }

//      Employee obj = new Employee();
//      obj.Accept(2,"Employee");
//      obj.Accept1(12000);
//      obj.Display();
//      obj.Display1();

// }






// class Admin
// {
//     protected int id; // Changed to protected for inheritance
//     protected string? name; // Nullable string

//     // Method to accept input
//     public virtual void Accept(int id, string name)
//     {
//         this.id = id;
//         this.name = name;
//     }

//     // Method to display the values
//     public virtual void Display()
//     {
//         Console.WriteLine($"Id is {id} and name is {name}");
//     }
// }

// class Employee : Admin
// {
//     private int salary;

//     // Method to accept salary
//     public void AcceptSalary(int salary)
//     {
//         this.salary = salary;
//     }

//     // Override the base class Display method
//     public override void Display()
//     {
//         // Call base class display method first
//         base.Display();
//         // Then display salary
//         Console.WriteLine($"Salary is {salary}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Example with Admin class
//         Admin admin = new Admin();
//         admin.Accept(1, "John Doe");       
//         admin.Display();

//         Console.WriteLine(); // Add a blank line for readability

//         // Example with Employee class
//         Employee employee = new Employee();
//         employee.Accept(2, "Jane Smith");  // Inherited method
//         employee.AcceptSalary(12000);      // Employee-specific method
//         employee.Display();                // Overridden display method
//     }
// }




// inheritance

// // Base class
// class Admin
// {
//     protected int id; // Use 'protected' to allow access in derived classes
//     protected string? name; // Nullable string

//     // Method to accept input
//     public void Accept(int id, string name)
//     {
//         this.id = id;
//         this.name = name;
//     }

//     // Method to display the values
//     public void Display()
//     {
//         Console.WriteLine("Id is {0} and Name is {1}", id, name);
//     }
// }

// // Derived class
// class Employee : Admin
// {
//     private int salary;

//     // Method to accept salary
//     public void Accept1(int salary)
//     {
//         this.salary = salary;
//     }

//     // Method to display employee details
//     public void Display1()
//     {
//         // Call base class Display() to show id and name
//         base.Display();
//         // Display salary
//         Console.WriteLine("Salary is {0}", salary);
//     }
// }

// // Main program
// class Program
// {
//     static void Main()
//     {
//         // Create an instance of Employee
//         Employee obj = new Employee();

//         // Accept values for id, name, and salary
//         obj.Accept(1, "Hammad");
//         obj.Accept(2, "Huzaifa");
//         obj.Accept(3, "Afzal");
//         obj.Accept(4, "Shakir");
//         obj.Accept1(12000);

//         // Display employee details
//         obj.Display1();
//     }
// }







//Inheritance

// using System;
// using System.Collections.Generic;

// // Base class
// class Admin
// {
//     protected int id; // Use 'protected' to allow access in derived classes
//     protected string? name; // Nullable string

//     // Method to accept input
//     public void Accept(int id, string name)
//     {
//         this.id = id;
//         this.name = name;
//     }

//     // Method to display the values
//     public void Display()
//     {
//         Console.WriteLine("Id is {0} and Name is {1}", id, name);
//     }
// }

// // Derived class
// class Employee : Admin
// {
//     private int salary;

//     // Method to accept salary
//     public void Accept1(int salary)
//     {
//         this.salary = salary;
//     }

//     // Method to display employee details
//     public void Display1()
//     {
//         // Call base class Display() to show id and name
//         base.Display();
//         // Display salary
//         Console.WriteLine("Salary is {0}", salary);
//     }
// }

// // Main program
// class Program
// {
//     static void Main()
//     {
//         // List to store multiple employees
//         List<Employee> employees = new List<Employee>();

//         // Create multiple employees
//         Employee emp1 = new Employee();
//         emp1.Accept(1, "Hammad");
//         emp1.Accept1(12000);
//         employees.Add(emp1);

//         Employee emp2 = new Employee();
//         emp2.Accept(2, "Huzaifa");
//         emp2.Accept1(15000);
//         employees.Add(emp2);

//         Employee emp3 = new Employee();
//         emp3.Accept(3, "Afzal");
//         emp3.Accept1(18000);
//         employees.Add(emp3);

//         Employee emp4 = new Employee();
//         emp4.Accept(4, "Shakir");
//         emp4.Accept1(20000);
//         employees.Add(emp4);

//         // Display details for all employees
//         foreach (var emp in employees)
//         {
//             emp.Display1();
//             Console.WriteLine(); // Add an empty line for better readability
//         }
//     }
// }




// loops 
// for loop
// class Program
// {
//     public static void Main()
//     {
//         for (int i = 1; i <= 100; i++) // Loop for rows
//         {
//             for (int j = 1; j <= i; j++) // Loop for columns
//             {
//                 Console.Write("*"); // Print star
//             }
//             Console.WriteLine(); // Move to the next line
//         }
//     }
// }





// using System;

// class Program
// {
//     public static void Main()
//     {
//         int n = 20; // Size of the heart
//         string name = "HAMMAD"; // Name to display
//         int nameRow = n / 2; // Row where the name will appear

//         // Top part of the heart
//         for (int i = n / 2; i <= n; i += 2)
//         {
//             // Print leading spaces
//             for (int j = 1; j < n - i; j += 2)
//             {
//                 Console.Write(" ");
//             }

//             // Print first half of the heart border
//             for (int j = 1; j <= i; j++)
//             {
//                 if (j == 1 || j == i)
//                 {
//                     Console.Write("*"); // Border
//                 }
//                 else
//                 {
//                     Console.Write(" "); // Empty inside
//                 }
//             }

//             // Print spaces between the two halves
//             for (int j = 1; j <= n - i; j++)
//             {
//                 Console.Write(" ");
//             }

//             // Print second half of the heart border
//             for (int j = 1; j <= i; j++)
//             {
//                 if (j == 1 || j == i)
//                 {
//                     Console.Write("*"); // Border
//                 }
//                 else
//                 {
//                     Console.Write(" "); // Empty inside
//                 }
//             }

//             Console.WriteLine();
//         }

//         // Bottom part of the heart
//         for (int i = n; i >= 1; i--)
//         {
//             // Print leading spaces
//             for (int j = i; j < n; j++)
//             {
//                 Console.Write(" ");
//             }

//             // Print the bottom border or the name row
//             for (int j = 1; j <= (i * 2) - 1; j++)
//             {
//                 if (i == nameRow && j > ((i * 2 - name.Length) / 2) && j <= ((i * 2 + name.Length) / 2))
//                 {
//                     // Display the name in the center row
//                     Console.Write(name[j - (i * 2 - name.Length) / 2 - 1]);
//                 }
//                 else if (j == 1 || j == (i * 2) - 1)
//                 {
//                     Console.Write("*"); // Border
//                 }
//                 else
//                 {
//                     Console.Write(" "); // Empty inside
//                 }
//             }

//             Console.WriteLine();
//         }
//     }
// }




//loop
// //for
// class Program{
//     public static void Main(){
//         for(int i = 1; i<= 12; i++){
//             Console.WriteLine(i);
//         }
//     }
// }


// class Program{
//     public static void Main(){
//         int num = 38;
//         for(int i = 1; i<= 12; i++){
//             Console.WriteLine(num*i);
//         }
//     }
// }


// in reverse order
// class Program{
//     public static void Main(){
//         int num = 38;
//         for(int i = 10; i>=1; i--){
//             Console.WriteLine("{0} * {1} = {2}",num,i,num*i);
//         }
//     }
// }



// check prime number

// class Program{
//     public static void Main(){
//         int num = 8, i;
//         for(i=2; i < num; i++){
//             if(num%i ==0){
//                 Console.WriteLine("{0} is not a prime number",num);
//                 break;
//             }
//         }
//         if(num==i){
//             Console.WriteLine("{0} is a prime number",num);
//         }

//     }
// }




//Nested for loop

// class Program{
//     public static void Main(){
//         for(int i = 1; i<=9; i++){
//            for(int j = 1; j<=i; j++){
//             Console.Write(j);
//            }
//            Console.WriteLine();
//         }
//     }
// }


// while Loop

// class Program{
//     public static void Main(){
//         int i = 1;
//         while(i<=12){
//             Console.WriteLine(i);
//             i++;
//         }
//     }
// }

//do while loop

// class Program{
//     public static void Main(){
//         int i = 1;
//         do{
//             Console.WriteLine(i);
//             i++;
//         }while(i<=10);
//     }
// }



//array

// class Array
// {
//     public static void Main()
//     {
//         int[] numbers = new int[5];
//         numbers[0] = 10;
//         numbers[1] = 20;
//         numbers[2] = 30;
//         numbers[3] = 40;
//         numbers[4] = 50;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(" | " +numbers[2] +" | ");
//         }
//     }


// }
// 


//one dimension array
// class Array
// {
//     public static void Main()
//     {
//         int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
//         for (int i = 0; i < arr.Length; i++)
//         {
//             Console.Write(" | " + arr[i] + " | ");
//         }
//     }
// }


//two dimension array
// class Array
// {
//     public static void Main()
//     {
//         int[,] arr = { {1, 2, 3, 4, 5, 6}, {7, 8, 9, 10, 11, 12} };
//         for (int i = 0; i < 2; i++){
//             for (int j = 0; j < 6; j++)
//             {
//                 Console.Write(" | " + arr[i, j] + " | ");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// //jagged array
// class Array
// {
//     public static void Main()
//     {
//        int [] [] arr= new int[3][];
//        arr[0] = new int[3] {1,2,3};
//        arr[1] = new int[2] {4,5};
//        arr[2] = new int[4] {6,7,8,9};
//        for (int i = 0; i < 3; i++){
//         for (int j = 0; j < arr[i].Length; j++){
//             Console.Write(" | " + arr[i][j] + " | ");
//         }
//         Console.WriteLine();
//        }
//     }
// }

//object array

// class Array
// {
//     public static void Main()
//     {
//         object[] arr = { "H", 8888, 8.8, true, "Welcome to program" };
//         // for(int i=0; i<arr.Length; i++){
//         //     Console.WriteLine(arr[i]);
//         // }
//         foreach (object obj in arr)
//         {
//             Console.WriteLine(obj);
//         }
//     }
// }




// // class and object
// class Student {
//     // Instance variables (properties)
//     private int id;
//     private String name;
//     private int gpa;

//     // Constructor
//     public Student() {
//         id = 1;
//         name = "John";
//         gpa = 3;
//     }

//     // Method to display student information
//     public void display() {
//         Console.WriteLine("ID: " + id);
//         Console.WriteLine("Name: " + name);
//         Console.WriteLine("GPA: " + gpa);
//     }

//     // Main method to create object and call display
//     public static void Main(String[] args) {
//         Student obj = new Student();
//         obj.display();
//     }
// }





//class and object


// class Student
// {
//     private int id;
//     private String? name;

//     Student(){
//         id = 211;
//         name = "John";
//     }

//     Student(int id, string name)
//     {
//         this.id = id;
//         this.name = name;
//     }
//     void Display()
//     {
//         Console.WriteLine("Roll no is {0} and Name is {1}", id, name);
//     }

//     public static void Main()
//     {
//         Student s1 = new Student();
//         s1.Display();


//         Student s2 = new Student(1001,"XYZ");
//         s2.Display();
//     }
// }




// abstract and interface topic

// public abstract class Bank
// {
//     internal int balance = 5000;
//     abstract public void Credit(int amt);
//     abstract public void Deposit(int amt);
//     abstract public bool Login(int pincode);
//     abstract public void CheckBalance();

//     void BankInfo()
//     {
//         Console.WriteLine("Ubl Bank");
//     }
// }


public interface  Bank
{
    abstract public void Credit(int amt);
    abstract public void Deposit(int amt);
    abstract public bool Login(int pincode);
    abstract public void CheckBalance(); 
}