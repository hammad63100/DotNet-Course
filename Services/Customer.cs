public class Customer
{
    public static void Main(string[] args)
    {
        Bank obj = new Program();
        obj.Credit(1000);
        obj.Deposit(500);
        obj.CheckBalance();
    }
}