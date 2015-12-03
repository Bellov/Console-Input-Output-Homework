using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b=1;
        int c;
        if (n >= 3) {
            Console.Write(a+ " " + b + " ");
            for (int i = 0; i < n-2; i++)
            {
                c = a;
                a = b;
                b = c + a;
                Console.Write(b+ " ");
            }
          
        }
        else if (n==2)
        {
            Console.WriteLine(a+ " "+b);
        }

        else if (n==1)
        {
            Console.WriteLine(a);
        }


        Console.ReadLine();
    }
}

