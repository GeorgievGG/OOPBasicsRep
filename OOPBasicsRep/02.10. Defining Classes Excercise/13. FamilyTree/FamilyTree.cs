using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FamilyTree
{
    static void Main()
    {
        var input = string.Empty;
        var info = new List<string>();
        var people = new Dictionary<string, Person>();
        var reqPerson = Console.ReadLine();
        while ((input = Console.ReadLine()) != "End")
        {
            if (!input.Contains("-"))
            {
                var inputArgs = input.Split();
                var name = inputArgs[0] + " " + inputArgs[1];
                var date = DateTime.ParseExact(inputArgs[2], "d/M/yyyy", CultureInfo.InvariantCulture);
                people.Add(name, new Person(name, date));
            }
            else
            {
                info.Add(input);
            }
        }
        foreach (var relation in info)
        {
            var inputArgs = relation.Split('-').Select(x => x.Trim()).ToArray();
            var date = new DateTime();
            var date2 = new DateTime();
            if (DateTime.TryParseExact(inputArgs[0], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                if (DateTime.TryParseExact(inputArgs[1], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date2))
                {
                    people.First(x => x.Value.Birthday == date).Value.Children.Add(people.First(x => x.Value.Birthday == date2).Value);
                    people.First(x => x.Value.Birthday == date2).Value.Parents.Add(people.First(x => x.Value.Birthday == date).Value);
                }
                else
                {
                    people.First(x => x.Value.Birthday == date).Value.Children.Add(people[inputArgs[1]]);
                    people[inputArgs[1]].Parents.Add(people.First(x => x.Value.Birthday == date).Value);
                }
            }
            else
            {
                if (DateTime.TryParseExact(inputArgs[1], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date2))
                {
                    people[inputArgs[0]].Children.Add(people.First(x => x.Value.Birthday == date2).Value);
                    people.First(x => x.Value.Birthday == date2).Value.Parents.Add(people[inputArgs[0]]);
                }
                else
                {
                    people[inputArgs[0]].Children.Add(people[inputArgs[1]]);
                    people[inputArgs[1]].Parents.Add(people[inputArgs[0]]);
                }
            }
        }
        var dummyDate = new DateTime();
        if (DateTime.TryParseExact(reqPerson, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dummyDate))
        {
            Console.WriteLine(people.First(x => x.Value.Birthday == dummyDate).Value.ToString());
        }
        else
        {
            Console.WriteLine(people[reqPerson].ToString());
        }
    }
}