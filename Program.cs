using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            DateTime myBirthday = DateTime.Parse("7/29/1993");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine("Difference in time between now and my birthday");
            Console.WriteLine("");
            Console.WriteLine(myAge.TotalDays);
            Console.WriteLine("Days");
            Console.WriteLine(myAge.TotalHours);
            Console.WriteLine("Hours");
            Console.WriteLine(myAge.TotalMinutes);
            Console.WriteLine("Minutes");


            Console.ReadLine();

        }
    }
}
