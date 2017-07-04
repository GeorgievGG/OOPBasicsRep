using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    public Player(string name, Endurance e, Sprint sp, Dribble d, Passing p, Shooting sh)
    {
        this.Name = name;
        this.stats = new List<Stat>();
        this.stats.Add(e);
        this.stats.Add(sp);
        this.stats.Add(d);
        this.stats.Add(p);
        this.stats.Add(sh);
    }

    private string name;
    private List<Stat> stats;

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (value == string.Empty || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            this.name = value;
        }
    }

    public IReadOnlyList<Stat> Stats
    {
        get
        {
            return stats.AsReadOnly();
        }
    }

    public double AverageStat()
    {
        return this.stats.Average(x => x.Rating);
    }
}