using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        f1.SetTop(1);
        f1.SetBottom(2);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        
        Fraction f2 = new Fraction(6,1);
        f2.SetTop(5);
        f2.SetBottom(2);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
       
        Fraction f3 = new Fraction(6,7);
        f3.SetTop(4);
        f3.SetBottom(5);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());





        

    }   

}