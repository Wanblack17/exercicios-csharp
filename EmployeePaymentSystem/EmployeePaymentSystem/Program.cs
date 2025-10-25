using ConsoleApp1.Entities;
using System;
using System.Collections.Concurrent;
using System.Data.SqlTypes;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of employees: ");
        int number = int.Parse(Console.ReadLine());

        List<Employee> emps = new List<Employee>();
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Employee #{i + 1}: ");
            Console.Write("Outsourced? [Y/N]: ");
            string outs = Console.ReadLine().ToLower();
            while (outs != "y" && outs != "yes" && outs != "n" && outs != "no")
            {
                Console.WriteLine("Invalid!, you must type Y or N!");
                outs = Console.ReadLine().ToLower();
            }

            if (outs == "y" || outs == "yes")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valueperhour = double.Parse(Console.ReadLine());
                Console.Write("Adicional Charge: ");
                double adittionalcharge = double.Parse(Console.ReadLine());

                Employee e1 = new OutsourcedEmployee(name, hours, valueperhour, adittionalcharge);
                emps.Add(e1);

            }
            else if (outs == "n" || outs == "no")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value por Hour: ");
                double valueperhour = double.Parse(Console.ReadLine());


                Employee e1 = new Employee(name, hours, valueperhour);
                emps.Add(e1);

            }




        }
        Console.WriteLine("\nPAYMENTS: ");

        foreach (Employee obj in emps)
        {
            Console.Write(obj.ToString());
        }

    }
}
