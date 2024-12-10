// // public class Program : Bank
// // {
// //     public override void CheckBalance()
// //     {
// //         if (this.Login(1234))
// //         {
// //             Console.WriteLine("Balance is {0}", balance);
// //         }
// //         else
// //         {
// //             Console.WriteLine("Invalid Login");
// //         }
// //     }

// //     public override void Credit(int amt)
// //     {
// //         if (this.Login(1234))
// //         {
// //             balance += amt;
// //             Console.WriteLine("Credited: {0}", amt);
// //         }
// //         else
// //         {
// //             Console.WriteLine("Invalid Login");
// //         }
// //     }

// //     public override void Deposit(int amt)
// //     {
// //         if (this.Login(1234))
// //         {
// //             balance -= amt;
// //             Console.WriteLine("Deposited: {0}", amt);
// //         }
// //         else
// //         {
// //             Console.WriteLine("Invalid Login");
// //         }
// //     }

// //     public override bool Login(int pincode)
// //     {
// //         if (pincode == 1234)
// //         {
// //             Console.WriteLine("Login Success");
// //             return true;
// //         }
// //         else
// //         {
// //             Console.WriteLine("Invalid Pin");
// //             return false;
// //         }
// //     }
// // }




// //for interface

// public class Program : Bank, Promotion
// {
//     int balance = 12000;

//     public void Branding()
//     {
//        Console.WriteLine("Branding");
//     }

//     public  void CheckBalance()
//     {
//         if (this.Login(1234))
//         {
//             Console.WriteLine("Balance is {0}", balance);
//         }
//         else
//         {
//             Console.WriteLine("Invalid Login");
//         }
//     }

//     public  void Credit(int amt)
//     {
//         if (this.Login(1234))
//         {
//             balance -= amt;
//             Console.WriteLine("Credited: {0}", amt);
//         }
//         else
//         {
//             Console.WriteLine("Invalid Login");
//         }
//     }

//     public  void Deposit(int amt)
//     {
//         if (this.Login(1234))
//         {
//             balance += amt;
//             Console.WriteLine("Deposited: {0}", amt);
//         }
//         else
//         {
//             Console.WriteLine("Invalid Login");
//         }
//     }

//     public  bool Login(int pincode)
//     {
//         if (pincode == 1234)
//         {
//             Console.WriteLine("Login Success");
//             return true;
//         }
//         else
//         {
//             Console.WriteLine("Invalid Pin");
//             return false;
//         }
//     }

//     public void marketing()
//     {
//        Console.WriteLine("Marketing");
//     }
// }

