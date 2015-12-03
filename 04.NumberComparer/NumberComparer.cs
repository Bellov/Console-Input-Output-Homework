using System;
using System.Deployment.Internal;
using System.Diagnostics.Eventing.Reader;

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("Write number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write number b: ");
        double b = double.Parse(Console.ReadLine());

       Console.WriteLine(Math.Max(a,b));
    }
}

