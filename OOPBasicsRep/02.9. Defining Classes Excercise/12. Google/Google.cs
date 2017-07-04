using System;
using System.Collections.Generic;
using System.Globalization;

namespace _12.Google
{
    class Google
    {
        static void Main()
        {
            var people = new Dictionary<string, Person>();
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var inputArgs = input.Split();
                switch (inputArgs[1])
                {
                    case "company":
                        AddPersonWithCompany(people, inputArgs);
                        break;
                    case "car":
                        AddPersonWithCar(people, inputArgs);
                        break;
                    case "children":
                        AddChild(people, inputArgs);
                        break;
                    case "pokemon":
                        AddPokemon(people, inputArgs);
                        break;
                    case "parents":
                        AddParent(people, inputArgs);
                        break;
                    default:
                        break;
                }
            }
            var reqName = Console.ReadLine();
            Console.WriteLine(people[reqName].ToString());
        }
        public static void AddPersonWithCompany(Dictionary<string, Person> people, string[] inputArgs)
        {
            if (people.ContainsKey(inputArgs[0]))
            {
                people[inputArgs[0]].Company = new Company(inputArgs[2], inputArgs[3], double.Parse(inputArgs[4]));
            }
            else
            {
                var person = new Person(inputArgs[0], new Company(inputArgs[2], inputArgs[3], double.Parse(inputArgs[4])));
                people.Add(inputArgs[0], person);
            }
        }
        public static void AddPersonWithCar(Dictionary<string, Person> people, string[] inputArgs)
        {
            if (people.ContainsKey(inputArgs[0]))
            {
                people[inputArgs[0]].Car = new Car(inputArgs[2], int.Parse(inputArgs[3]));
            }
            else
            {
                var person = new Person(inputArgs[0], new Car(inputArgs[2], int.Parse(inputArgs[3])));
                people.Add(inputArgs[0], person);
            }
        }
        public static void AddPokemon(Dictionary<string, Person> people, string[] inputArgs)
        {
            if (!people.ContainsKey(inputArgs[0]))
            {
                people.Add(inputArgs[0], new Person(inputArgs[0]));
            }
            people[inputArgs[0]].Pokemons.Add(new Pokemon(inputArgs[2], inputArgs[3]));
        }
        public static void AddParent(Dictionary<string, Person> people, string[] inputArgs)
        {
            if (!people.ContainsKey(inputArgs[0]))
            {
                people.Add(inputArgs[0], new Person(inputArgs[0]));
            }
            people[inputArgs[0]].Parents.Add(new Parent(inputArgs[2], inputArgs[3]));
        }
        public static void AddChild(Dictionary<string, Person> people, string[] inputArgs)
        {
            if (!people.ContainsKey(inputArgs[0]))
            {
                people.Add(inputArgs[0], new Person(inputArgs[0]));
            }
            people[inputArgs[0]].Children.Add(new Child(inputArgs[2], inputArgs[3]));
        }
    }
}
