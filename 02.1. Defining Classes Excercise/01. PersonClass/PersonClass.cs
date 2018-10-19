using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class PersonClass
{
    private const int REQUIRED_AGE_LIMIT = 30;

    public static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(People).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(People).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        var people = new List<Person>();
        var poll = new People(people);
        AddPollMembers(poll);
        PrintOlderPeople(people, REQUIRED_AGE_LIMIT);
    }

    private static void PrintOlderPeople(List<Person> people, int olderThan)
    {
        foreach (var person in people.OrderBy(x => x.Name))
        {
            if (person.Age > olderThan)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    private static void AddPollMembers(People newPoll)
    {
        var incomingPeople = int.Parse(Console.ReadLine());
        for (int i = 0; i < incomingPeople; i++)
        {
            string[] inputArgs = ReadValues();
            string personName = inputArgs[0];
            int personAge = int.Parse(inputArgs[1]);
            newPoll.AddMember(personName, personAge);
        }
    }

    private static string[] ReadValues()
    {
        return Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }
}