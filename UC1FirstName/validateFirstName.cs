using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC1FirstName
{
    class validateFirstName
    {
        public string RegexPattern = "^[A-Z][a-zA-Z]{3,}$";
        public bool FirstNameCheck(string FirstName)
        {
            return Regex.IsMatch(FirstName, RegexPattern);
        }
    }
}
