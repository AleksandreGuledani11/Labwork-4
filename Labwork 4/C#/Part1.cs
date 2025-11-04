
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        string b = "5";
        double c = 5.0;

        // Operations
        Console.WriteLine(a + c);   // ✅ 10.0 (int promoted to double)
        Console.WriteLine(a + b);   // ✅ "55" (string concatenation)
        Console.WriteLine(b + c);   // ✅ "55" (string concatenation)

        // Explicit casts to make all succeed
        Console.WriteLine(a + Convert.ToInt32(b));  // ✅ 10
        Console.WriteLine((double)a + c);           // ✅ 10.0
        Console.WriteLine(a.ToString() + b);        // ✅ "55"
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
