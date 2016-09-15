using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Problem4DifferenceBetweenDates
{
    static double NumberOfDays(DateTime first, DateTime second)
    {
        TimeSpan difference = second - first;
        int result = (int)difference.TotalDays;
        return result;
    }
    static void Main()
    {
        string format = "dd.mm.yyyy";
        string firstInput = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(firstInput,format,CultureInfo.CurrentCulture);
        string secondInput = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(secondInput, format, CultureInfo.CurrentCulture);
        int daysDiff = (int)NumberOfDays(firstDate, secondDate);
        Console.WriteLine(daysDiff);
    }
    
}
