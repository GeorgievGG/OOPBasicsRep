using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

public class Person
{
    public Person(string name) : this(name, null)
    { }
    public Person(DateTime? birthday) : this(null, birthday)
    { }
    public Person(string name, DateTime? birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
        this.Children = new List<Person>();
        this.Parents = new List<Person>();
    }
    private string name;
    private DateTime? birthday;
    private List<Person> children;
    private List<Person> parents;

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

    public List<Person> Children
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

    public List<Person> Parents
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

    public DateTime? Birthday
    {
        get
        {
            return this.birthday;
        }

        set
        {
            this.birthday = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Name} {((DateTime)this.Birthday).ToString("d/M/yyyy", CultureInfo.InvariantCulture)}");
        sb.AppendLine("Parents:");
        if (Parents != null && Parents.Count != 0)
        {
            sb.AppendLine(string.Join(Environment.NewLine, Parents.Select(x => $"{x.Name} {((DateTime)x.Birthday).ToString("d/M/yyyy", CultureInfo.InvariantCulture)}")));
        }
        sb.AppendLine("Children:");
        if (Children != null && Children.Count != 0)
        {
            sb.AppendLine(string.Join(Environment.NewLine, Children.Select(x => $"{x.Name} {((DateTime)x.Birthday).ToString("d/M/yyyy", CultureInfo.InvariantCulture)}")));
        }
        return sb.ToString();
    }
}