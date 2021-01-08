using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    class Program
    {
        static void Main()
        {
            SortedList<string, Person> people = new();
            people.Add("Marcin", new Person("Marcin", 29, Country.PL));
            people.Add("Sabine", new Person("Sabine", 25, Country.DE));
            people.Add("Ann", new Person("Ann", 31, Country.PL));
            people.ToList().ForEach(p => Console.WriteLine($"{p.Value.Name} ({p.Value.Age} years) from {p.Value.Country}."));
        }
    }
}
