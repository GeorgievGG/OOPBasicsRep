using System;
using System.Collections.Generic;
using System.Linq;

public class People
{
    private List<Person> members;

    public People(List<Person> familyMembers)
    {
        this.members = familyMembers;
    }

    public void AddMember(string name, int age)
    {
        members.Add(new Person(name, age));
    }

    public Person GetOldestMember()
    {
        if (members.Count > 0)
        {
            return members.OrderByDescending(x => x.Age).First();
        }

        Console.WriteLine("The poll has no members");

        return null;
    }
}