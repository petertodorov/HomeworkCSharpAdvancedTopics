using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Problem5SortingNumbers
{

    static void SortNumber(int n)
    {
        List<int> sequence = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            sequence.Add(temp);
            sequence.Sort();
        }
        for (int i = 0; i < sequence.Count; i++)
        {
            Console.WriteLine(sequence[i]);
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortNumber(n);
    }
}

