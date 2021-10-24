using System;
using System.Collections.Generic;
using System.Linq;

namespace UC13lambdaFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UC13Person> listPerson = new List<UC13Person>();
            AddRecords(listPerson);
            RetrevingData(listPerson);
        }
        private static void AddRecords(List<UC13Person> listPerson)
        {
            listPerson.Add(new UC13Person("Amit", "Kumar", 18, "amit@gmail.com", 9897139203, "Amit1298"));
            listPerson.Add(new UC13Person("Krishna", "Amit", 16, "krishna@gmail.com", 45397139203, "Krishna1298"));
            listPerson.Add(new UC13Person("Satty", "Thakur", 17, "satty@gmail.com", 2347139203, "sumit1298"));
            listPerson.Add(new UC13Person("Sumit", "Kumar", 20, "sumit@gmail.com", 9847139203, "satty1298"));
            listPerson.Add(new UC13Person("Lala", "Gupta", 28, "lala@gmail.com", 83484139203, "lala1298"));
        }
        private static void RetrevingData(List<UC13Person> listPerson)
        {
            foreach (UC13Person person in listPerson.FindAll(x => (x.Age <= 28)).Take(5).ToList())
            {
                Console.WriteLine("Name " + person.firstName + " (Age)" + person.Age);
            }
        }
    }
}
