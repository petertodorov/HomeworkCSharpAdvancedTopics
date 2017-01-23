using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ProblemOneFibonacciNumbers
{
    static void Fib(int n)
    {
        int first = 0;
        int second = 1;
        for (int i = 0; i < n; i++)
        {
            int next = first + second;
            first = second;
            second = next;
        }
        Console.WriteLine(second);
    }
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("Fib(n): ");
            Fib(n);
        }
    }
}

