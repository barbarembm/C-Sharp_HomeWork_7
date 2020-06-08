using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();
            output.Add(new Person { FirstName = "barbi", LastName = "dzidziguri", YearsExperience = 2, Birthday = Convert.ToDateTime("2/2/2006")});
            output.Add(new Person { FirstName = "mishka", LastName = "dzidziguri", YearsExperience = 2, Birthday = Convert.ToDateTime("2/2/2006") });
            output.Add(new Person { FirstName = "mishka2", LastName = "dzidziguri", YearsExperience = 2, Birthday = Convert.ToDateTime("2/2/2006") });
            return output;
        }
    }
}
