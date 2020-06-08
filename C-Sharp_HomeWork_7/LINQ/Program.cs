using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            int yearsTotal = 0;

            yearsTotal = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsExperience);
            Console.WriteLine($"The total years expetoence is {yearsTotal}");
            Console.ReadLine();
        }
    }
}
