using System;
using Calculate_taxes.Entities;
using System.Globalization;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<calculationBasis> list = new List<calculationBasis>();
        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i<n; i++)
        {
            Console.WriteLine($"Tax payer #{i+1} data: ");
           
            Console.Write("Individual or Company: [i/c] ");
            char answer = Char.Parse(Console.ReadLine().ToLower());

            Console.Write("Name: ");
            string name = Console.ReadLine();
           
            Console.Write("Annual Income: ");
            double annual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(answer == 'i')
            {
                Console.Write("Health Expenditures: ");
                double health = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                list.Add(new Privateindividual(name, annual, health));

            }
            else
            {
                Console.Write("Number of Employees: ");
                int employees = int.Parse(Console.ReadLine());
                list.Add(new LegalEntity(name, annual, employees));
            }

        }
        Console.WriteLine("TAXES PAID: ");
        double sum = 0;
        foreach(calculationBasis obj in list)
        {
            Console.WriteLine(obj.Name + "$ " + obj.Calculatetax().ToString("F2", CultureInfo.InvariantCulture));
            sum += obj.Calculatetax();
        }

        Console.WriteLine("\nTOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
    }
}
