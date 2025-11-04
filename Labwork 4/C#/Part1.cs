
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        string b = "5";
        double c = 5.0;

        Console.WriteLine(a + c);   
        Console.WriteLine(a + b);   
        Console.WriteLine(b + c);   

        Console.WriteLine(a + Convert.ToInt32(b));  
        Console.WriteLine((double)a + c);           
        Console.WriteLine(a.ToString() + b);        
    }
}



// • Which of these operations fail and why?
//    None fail. 'a + b' works due to operator overloading for string concatenation.
// • Which language allows implicit coercion and how safely?
//    C# safely coerces numeric types (int ↔ double) and allows string concatenation.
//      Implicit conversions are safe and checked by the compiler.
// • What does this tell you about strong vs weak typing?
//    C# is strongly and statically typed.
//      It allows limited, controlled implicit conversions.
