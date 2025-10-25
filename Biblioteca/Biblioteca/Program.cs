using System;


public class Program
{
    public static void Main(string[] args)
    {
        Livro l1 = new Livro("O chamado de Cthulu", "H.P Lovecraft", 1939);
        Livro l2 = new Livro("Sussuros na Escuridão", "H.P Lovecraft", 1937);
        Livro l3 = new Livro("O Iluminado", "Stephen King", 1980);
        Biblioteca b1 = new Biblioteca("Saraiva", "Av.Paulista");

        b1.AdicionarLivro(l1);
        b1.AdicionarLivro(l2);
        b1.AdicionarLivro(l3);

        Console.WriteLine($"TODOS OS LIVROS DA {b1.Nome}:");
        b1.ListarLivros();
        Console.WriteLine($"TODOS OS LIVROS DE LOVECRAFT");
        b1.BuscarAutor("H.P Lovecraft");
    }
}
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public int AnoPublicacao { get; set; }

    public Livro()
    {
    }

    public Livro(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }
}
    public class Biblioteca
    {
        public string Nome;
        public string Endereco;
        public List<Livro> Livros = new List<Livro>();

        public Biblioteca()
        {
        }

        public Biblioteca(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }
        public void ListarLivros()
        {
            foreach (Livro l in Livros)
            {
                Console.WriteLine($"{l.Titulo}\n");
            }
        }
        public void BuscarAutor(string autor)
        {
            foreach (Livro l in Livros)
            {
                if (autor == l.Autor)
                {
                    Console.WriteLine($"{l.Titulo}\n");
                }
            }
        }
    }
