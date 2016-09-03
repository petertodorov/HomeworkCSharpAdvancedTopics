using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine()); int c = int.Parse(Console.ReadLine());
            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    string a = Convert.ToString((char)('a' + row));
                    string b = Convert.ToString((char)('a' + row + col));
                    string d = Convert.ToString((char)('a' + row) + " ");
                    Console.Write(Join(a, b, d));
                }
                Console.WriteLine();
            }
        }

        private static string Join(string a, string b, string d)
        {
            return String.Join("", a, b, d);
        }
    }
}
