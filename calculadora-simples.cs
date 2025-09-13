// Calculadora simples em C# com validação de números e operações básicas (+, -, x, /)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes_matematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um numero :");
            double n1;
                while (!double.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Entrada inválida! Digite apenas números:");
            }
            Console.WriteLine("Escolha uma operação matemática: +, - , x , /");
           string operacao = Console.ReadLine().ToLower();
            while(operacao!="+" && operacao!="x" && operacao != "-" && operacao != "/")
            {
                Console.WriteLine("Operação Invalida! você deve digitar: +, x, -, /");
                operacao = Console.ReadLine().ToLower();
            }


            Console.WriteLine("Escolha outro número:");
            double n2;
            while (true)
            {
                string entrada = Console.ReadLine();
                if (!double.TryParse(entrada, out n2))
                {
                    Console.WriteLine("Entrada inválida! Digite apenas números:");
                }
                else if (operacao == "/" && n2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por 0! Digite outro número:");
                }
                else
                {
                    break; 
                }
            }


            if (operacao == "+")
            {
                Console.WriteLine($"{n1} + {n2} = {n1+n2}");
            }
            else if (operacao == "-")
            {
                Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            }
            else if(operacao == "x")
            {
                Console.WriteLine($"{n1} X {n2} = {n1 * n2}");
            }
            else if(operacao == "/")
            {
                Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                
              
            }
        }
    }
}
        
    
  