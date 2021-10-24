using System;
using System.Collections.Generic;
using System.Text;

namespace UC13lambdaFunction
{
    class UC13Person
    {
        public string firstName;
        public string lastName;
        public int Age;
        public string Email;
        public long mobileNumber;
        public string Password;
        public UC13Person(string firstname, string lastname, int age, string email, long moblienumber, string password)
        {
            firstName = firstname;
            lastName = lastname;
            Age = age;
            Email = email;
            mobileNumber = moblienumber;
            Password = password;
        }
    }
}
