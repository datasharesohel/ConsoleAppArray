using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = new[]
            {
                 new {name="Jhon",Age=50},
                 new {name="Bill",Age=40},
                 new {name="Farid",Age=30},
            };
            foreach (var item in names)
            {
                Console.WriteLine($"Name:{item.name }, Age: {item.Age }");
                //Console.WriteLine(item.Age);
            }            
            
            Console.WriteLine("------------");
            Console.WriteLine("-------Array Example-----");

            Person[] family = new[]
            {
                new Person("Jhon",53),
                new Person("Marry",45),
                new Person("Dolly",20)
            };

            foreach (var item in family)
            {
                Console.WriteLine($"Name:{item.Name }, Age: {item.Age }");
               
            }

            Console.WriteLine("-------List Example -----");
            List<Person> family1 = new List<Person>()
            {
                new Person("Jhon",53),
                new Person("Marry",45),
                new Person("Dolly",20)

            };
            foreach (var item in family1)
            {
                Console.WriteLine($"Name:{item.Name }, Age: {item.Age }");

            }

          

        }
    }
}
