using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<Lanches> l = new List<Lanches>();
        double ValorTotal = 0.0;
        string continuar;
        l.Add(new Lanches("X- TUDO", 39.90));
        l.Add(new Lanches("X- BACON", 29.90));
        l.Add(new Lanches("X- EGG", 29.90));
        l.Add(new Lanches("X- SALADA", 27.90));
        l.Add(new Lanches("PORÇÃO DE FRITAS", 12.90));
        l.Add(new Lanches("MILK SHAKE", 17.90));
        Console.WriteLine("----LANCHONETE----");
        Console.WriteLine("CARDAPIO: ");
        do
        {
            Console.Clear();
            foreach (Lanches lanches in l)
            {

                Console.Write($"{l.IndexOf(lanches) + 1}.");
                lanches.ExibirInfo();
            }
            Console.WriteLine("Qual você deseja comprar? ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > l.Count)
            {
                Console.WriteLine("Opção inválida! Digite um número válido do cardápio:");
            }
            ValorTotal += l[n - 1].Preco;
            l[n - 1].Quantidade++;
            Console.WriteLine($"\nVocê adicionou {l[n - 1].Nome} ao pedido!");
            Console.WriteLine($"Total parcial: R$ {ValorTotal:F2}\n");
            Console.WriteLine("Deseja comprar mais alguma coisa?[S/N] ");

            continuar = Console.ReadLine().ToLower();
            while (continuar != "sim" && continuar != "s" && continuar != "não" && continuar != "n")
            {
                Console.WriteLine("Você deve responder [S/N]");
                continuar = Console.ReadLine().ToLower();

            }

        }
        while (continuar == "sim" || continuar == "s");
        Console.WriteLine($"PEDIDO: ");
        foreach (Lanches lanches in l)
        {
            if (lanches.Quantidade > 0)
            { // mostra só os itens que foram comprados
                Console.WriteLine($"{lanches.Quantidade}x {lanches.Nome} - R$ {lanches.Preco * lanches.Quantidade:F2}");
            }

        }
        Console.WriteLine($"Valor Total: {ValorTotal}");
    }
    public class Lanches
    {
        public string Nome;
        public double Preco;
        public double Total;
        public int Quantidade;

        public Lanches(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }


        public void ExibirInfo()
        {
            Console.WriteLine($"{Nome}...................{Preco:F2}");
        }

    }
}