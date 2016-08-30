using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Problem6LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int length = 0;
        string value = string.Empty;
        string[] elements = new string[n];
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = Console.ReadLine();
        }
        for (int i = 0; i < elements.Length; i++)
        {
            int count = 0;
            for (int j = i; j < elements.Length; j++)
            {
                if (elements[i] == elements[j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (length < count)
            {
                length = count;
                value = elements[i];
            }
        }
        Console.WriteLine(length);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(value);
        }
    }
}

