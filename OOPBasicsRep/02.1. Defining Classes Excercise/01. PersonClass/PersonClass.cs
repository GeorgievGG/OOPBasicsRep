using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class PersonClass
{
    public static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(People).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(People).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }
        var incomingPeople = int.Parse(Console.ReadLine());
        var people = new List<Person>();
        var newPoll = new People(people);
        for (int i = 0; i < incomingPeople; i++)
        {
            var inputArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            newPoll.AddMember(inputArgs[0], int.Parse(inputArgs[1]));
        }
        foreach (var person in people.OrderBy(x => x.name))
        {
            if (person.age > 30)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}