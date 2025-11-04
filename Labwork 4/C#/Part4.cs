using System;

public class Calculator
{
    public static double Calc(double a, double b, char op)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => throw new ArgumentException("Unsupported operation")
        };
    }

    public static void Main()
    {
        Console.WriteLine(Calc(10, 5, '+'));   
        Console.WriteLine(Calc(10.5, 2, '/')); 

       
    }
}
