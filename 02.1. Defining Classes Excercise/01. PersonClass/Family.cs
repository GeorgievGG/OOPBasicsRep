using System;
using System.Collections.Generic;
using System.Linq;
public class People
{
    public People(List<Person> familyMembers)
    {
        this.members = familyMembers;
    }
    private List<Person> members;
    public void AddMember(string name, int age)
    {
        members.Add(new Person(name, age));
    }
    public Person GetOldestMember()
    {
        if (members.Count > 0)
        {
            return members.OrderByDescending(x => x.age).First();
        }
        Console.WriteLine("The poll has no members");
        return null;
    }
}