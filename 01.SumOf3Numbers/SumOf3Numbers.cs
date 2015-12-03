using System;

//Write a program that reads 3 real numbers from the console and prints their sum. Examples:
//a	b	c	sum
//3	4	11	18
//-2	0	3	1
//5.5	4.5	20.1	30.1
using System.Diagnostics.Eventing;
using System.Globalization;


class SumOf3Numbers
{
    static void Main(string[] args)
    {
        Console.Write("Write number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Write number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Write number c: ");
        double c = double.Parse(Console.ReadLine());
        
        Console.Write("The result is: ");
        Console.WriteLine("{0} + {1} + {2} = {3}",a,b,c,a+b+c);


        Console.ReadLine();
    }
}

