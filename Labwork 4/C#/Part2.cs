using System;

class Program
{
    static void Main()
    {
        int x = 10;
        Console.WriteLine($"{x} ({x.GetType()})"); 


        dynamic y = 10;
        Console.WriteLine($"{y} ({y.GetType()})");  

        y = "ten";
        Console.WriteLine($"{y} ({y.GetType()})");  

        y = true;
        Console.WriteLine($"{y} ({y.GetType()})");  
    }
}


// • What happens in each case?
//      Using 'int x' enforces static typing — reassigning to a different type fails at compile time.
//      Using 'dynamic y' allows changing types at runtime, similar to Python.
//
// • If the compiler/interpreter allows it, print type(x) or equivalent.
//      For 'dynamic', y.GetType() returns the runtime type.
//
