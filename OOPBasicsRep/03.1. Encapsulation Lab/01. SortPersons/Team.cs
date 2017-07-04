using System.Collections.Generic;

public class Team
{
    public Team(string name)
    {
        this.Name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            this.name = value;
        }
    }
    public IReadOnlyCollection<Person> FirstTeam
    {
        get
        {
            return this.firstTeam.AsReadOnly();
        }
    }

    public IReadOnlyCollection<Person> ReserveTeam
    {
        get
        {
            return this.reserveTeam.AsReadOnly();
        }
    }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            this.firstTeam.Add(person);
        }
        else
        {
            this.reserveTeam.Add(person);
        }
    }
    public override string ToString()
    {
        return $@"First team have {this.FirstTeam.Count} players
Reserve team have {this.ReserveTeam.Count} players";
    }
}