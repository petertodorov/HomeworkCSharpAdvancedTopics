using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Problem2PrimeChecker
{
    static bool IsPrime(long n)
    {
        bool isPrime = true;
        if (n>=2)
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        else
        {
            isPrime = false;
        }
        return isPrime;
    }
    static void Main()
    {
        while (true)
        {
        
        long n = long.Parse(Console.ReadLine());
        bool toPrint = IsPrime(n);
        Console.WriteLine(toPrint);
        }
    }
}
