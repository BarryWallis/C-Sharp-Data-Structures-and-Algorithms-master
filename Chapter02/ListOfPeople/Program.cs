using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPeople
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new();

            people.Add(new Person("Marcin", 29, Country.PL));
            people.Add(new Person("Sabine", 25, Country.DE));
            people.Add(new Person("Ann", 31, Country.PL));
            people.OrderBy(p => p.Name)
                  .ToList()
                  .ForEach(p => Console.WriteLine($"{p.Name} ({p.Age} years) from {p.Country}."));

            Console.WriteLine();
            people.Where(p => p.Age <= 30)
                  .OrderBy(p => p.Name)
                  .Select(p =>  new { name = p.Name })
                  .ToList()
                  .ForEach(p => Console.WriteLine($"{p.name}."));
        }
    }
}
