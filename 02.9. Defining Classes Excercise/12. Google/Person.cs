using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    public Person(string name) : this(name, null, null)
    { }
    public Person(string name, Company company) : this(name, company, null)
    { }
    public Person(string name, Car car) : this(name, null, car)
    { }
    public Person(string name, Company company, Car car)
    {
        this.Name = name;
        this.Company = company;
        this.Car = car;
        this.Children = new List<Child>();
        this.Parents = new List<Parent>();
        this.Pokemons = new List<Pokemon>();
    }
    private string name;
    private Company company;
    private Car car;
    private List<Child> children;
    private List<Parent> parents;
    private List<Pokemon> pokemons;

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            this.name = value;
        }
    }

    public Company Company
    {
        get
        {
            return company;
        }

        set
        {
            company = value;
        }
    }

    public Car Car
    {
        get
        {
            return this.car;
        }

        set
        {
            this.car = value;
        }
    }

    public List<Child> Children
    {
        get
        {
            return this.children;
        }

        private set
        {
            this.children = value;
        }
    }

    public List<Parent> Parents
    {
        get
        {
            return this.parents;
        }

        private set
        {
            this.parents = value;
        }
    }

    public List<Pokemon> Pokemons
    {
        get
        {
            return this.pokemons;
        }

        private set
        {
            this.pokemons = value;
        }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(Name);
        sb.AppendLine("Company:");
        if (Company != null)
        {
            sb.AppendLine(Company.ToString());
        }
        sb.AppendLine("Car:");
        if (Car != null)
        {
            sb.AppendLine(Car.ToString());
        }
        sb.AppendLine("Pokemon:");
        if (Pokemons != null && Pokemons.Count != 0)
        {
            sb.AppendLine(string.Join(Environment.NewLine, Pokemons.Select(x => x.ToString())));
        }
        sb.AppendLine("Parents:");
        if (Parents != null && Parents.Count != 0)
        {
            sb.AppendLine(string.Join(Environment.NewLine, Parents.Select(x => x.ToString())));
        }
        sb.AppendLine("Children:");
        if (Children != null && Children.Count != 0)
        {
            sb.AppendLine(string.Join(Environment.NewLine, Children.Select(x => x.ToString())));
        }
        return sb.ToString();
    }
}