
using System;

public record Person(string Name, int Age);

public class Program
{
    public static void Main()
    {
        var p1 = new Person("Guga", 27);

        
        var p2 = p1 with { Age = 28 };

        Console.WriteLine(p1); 
        Console.WriteLine(p2); 
    }
}
