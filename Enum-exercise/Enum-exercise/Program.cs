using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual tamanho de Pizza você deseja?");
        foreach (Tamanho tamanho in Enum.GetValues(typeof(Tamanho)))
        {
            Console.WriteLine($"{tamanho} - R${(int)tamanho}");
        }

        Tamanho r = (Tamanho)Enum.Parse(typeof(Tamanho), Console.ReadLine(), true);

        Console.WriteLine("Agora escolha o sabor: ");
        int i = 1;
        foreach (Sabores sabor in Enum.GetValues(typeof(Sabores)))
        {
            Console.WriteLine($"{i} - {sabor}");
            i++;
        }

        int escolhaSabor = int.Parse(Console.ReadLine());
        Sabores s = (Sabores)(escolhaSabor - 1);

        Console.WriteLine($"Você escolheu uma pizza de {s} tamanho {r}.");
        Console.WriteLine($"Valor Total: R${(int)r:F2}");
    }
}

public enum Sabores
{
    Calabresa,
    FrangoCatupiry,
    Mussarela,
    Pepperoni
}

public enum Tamanho
{
    pequena = 25,
    media = 35,
    grande = 45
}