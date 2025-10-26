using Exceptions.Entities;
using System;
using System.Globalization;
using Exceptions.Exceps;
public class HelloWorld 
{ 
    public static void Main(string[] args) 
    { 
        Console.WriteLine("Enter Account Data: "); 
        try 
        { 
            Console.Write("Number: "); 
            int number = int.Parse(Console.ReadLine()); 
            Console.Write("Holder: "); 
            string holder = Console.ReadLine(); 
            Console.Write("Initial Balance:"); 
            double initial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw Limit: "); 
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            Account account = new Account(number, holder, initial, withdrawLimit); 
            Console.Write("Enter amount fot withdraw: "); 
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            account.Withdraw(withdraw); 
            Console.WriteLine($"New Balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}"); } 
        catch (DomainException e)
        { 
            Console.WriteLine($"ERROR: {e.Message}"); } 
        catch (FormatException) 
        { 
            Console.WriteLine("ERROR: This field accepts numbers only "); 
        }
    }
}