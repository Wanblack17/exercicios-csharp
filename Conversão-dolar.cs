using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_Dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolar = 0.0;
            double real = 0.0;
            Console.WriteLine("Qual a cotação atual do Dólar?");
            dolar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantos Reais você vai converter");
            real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O valor convertido fica {Math.Round(Converter(real, dolar),2)} Dólares");
        }
    
      static double Converter(double x, double y)
        {
            return x / y;
        }
    } }
