using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Person
    {
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public int YearsExperience { get; set; }
        public DateTime Birthday { get; set; }
        public string FullName { get => $"({FirstName} {LastName})"; }
    }
}
