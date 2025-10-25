using Compositions_Exercise.Entities;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Comments c1 = new Comments("Have a nice trip!");
        Comments c2 = new Comments("OW!! That's awesome");
        Post p1 = new Post(DateTime.Parse("21/06/18 13:05:44"), "Travelling to new Zealand", "I'm going to visit this amazing country!", 12 );

        p1.AddComment(c1);
        p1.AddComment(c2);

        Console.WriteLine(p1);
    }
}