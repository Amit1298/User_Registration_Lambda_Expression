using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UC1FirstName
{
    class Program
    {
        public delegate string myDelegate(string name);
        static void Main(string[] args)
        {
            validateFirstName firstname = new validateFirstName();
            Predicate<string> IsName = (string x) => x = firstname.FirstNameCheck(name);
            var ie = IsName("Amit");
        }
    }
}
