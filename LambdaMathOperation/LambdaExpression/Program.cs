using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            AddRecord(listPersonsInCity);

            CheckingForTeenagerPerson(listPersonsInCity);
        }

        private static void AddRecord(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("7588331911", "Sagar", "Rajgurunagar", 24));
            listPersonsInCity.Add(new Person("7588394855", "Nisarg", "Khed", 30));
            listPersonsInCity.Add(new Person("9422982994", "Kishor", "Junnar", 35));
            listPersonsInCity.Add(new Person("8698004161", "Akshay", "Raigad", 40));
            listPersonsInCity.Add(new Person("7583316771", "Ankit", "Thane", 45));
            listPersonsInCity.Add(new Person("8526944231", "Hrishi", "Beed", 50));
            listPersonsInCity.Add(new Person("8552399774", "Ketan", "Nagpur", 55));
            listPersonsInCity.Add(new Person("5523699741", "Abhi", "nagar", 60));
            listPersonsInCity.Add(new Person("8522369974", "Pranit", "solapur", 65));
            listPersonsInCity.Add(new Person("885236994", "Adesh", "Pune", 70));


            foreach (Person person in listPersonsInCity)
            {
                Console.WriteLine("SSN:" + person.SSN);
                Console.WriteLine("Name:" + person.Name);
                Console.WriteLine("Address:" + person.Address);
                Console.WriteLine("Age:" + person.Age);

            }
        }
        private static void CheckingForTeenagerPerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => (e.Age >= 13 && e.Age < 19)))
            {
                Console.WriteLine("Yes We Have teen Agers in lIst");
            }
            else
            {
                Console.WriteLine("No, We Dont Have Teen Agers in list");
            }


        }
    }
}
