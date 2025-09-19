using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int maior = MaiorNumero(); // Chama a função e armazena o retorno
        Console.WriteLine($"O maior número digitado foi {maior}");
    }

    public static int MaiorNumero() // Função que retorna o maior número digitado
    {
        int maior = int.MinValue; // Inicializa com o menor valor possível de int
        for (int i = 0; i < 3; i++) // Laço de repetição para ler 3 números
        {
            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            if (n > maior)
            {
                maior = n; // Atualiza se o número atual for maior
            }
        }
        return maior; // Retorna o maior número encontrado
    }
}
