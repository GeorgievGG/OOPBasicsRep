using System;
using System.Collections.Generic;
using System.Linq;

public class Club
{
    public Club(string name)
    {
        try
        {
            this.Name = name;
            this.players = new List<Player>();
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
    private string name;
    private List<Player> players;

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

    public IReadOnlyList<Player> Players
    {
        get
        {
            return this.players.AsReadOnly();
        }
    }

    public double AverageRating()
    {
        if (this.Players.Count == 0)
        {
            return 0;
        }
        else
        {
            return Math.Round(this.Players.Average(x => x.AverageStat()), 0);
        }
    }

    public void AddPlayer(Player player)
    {
        this.players.Add(player);
    }

    public void RemovePlayer(string player)
    {
        if (players.Where(x => x.Name == player).Count() == 0)
        {
            throw new ArgumentException();
        }
        this.players.RemoveAll(x => x.Name == player);
    }
}