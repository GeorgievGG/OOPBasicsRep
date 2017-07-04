using System;
using System.Collections.Generic;
using System.Linq;

public class Competition
{
    public static void Main()
    {

        var input = string.Empty;
        var teams = new List<Club>();
        while ((input = Console.ReadLine()) != "END")
        {
            var inputArgs = input.Split(';');
            if (inputArgs[0] == "Team")
            {
                teams.Add(new Club(inputArgs[1]));
            }
            else if (inputArgs[0] == "Add")
            {
                var teamName = inputArgs[1];
                var playerName = inputArgs[2];
                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                    continue;
                }
                try
                {
                    var endurance = new Endurance(int.Parse(inputArgs[3]));
                    var sprint = new Sprint(int.Parse(inputArgs[4]));
                    var dribble = new Dribble(int.Parse(inputArgs[5]));
                    var passing = new Passing(int.Parse(inputArgs[6]));
                    var shooting = new Shooting(int.Parse(inputArgs[7]));//possible problems with multible catches
                    var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                    var team = teams.First(x => x.Name == teamName);
                    team.AddPlayer(player);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    continue;
                }
            }
            else if (inputArgs[0] == "Remove")
            {
                var teamName = inputArgs[1];
                var playerName = inputArgs[2];
                try
                {
                    var team = teams.First(x => x.Name == teamName);
                    team.RemovePlayer(playerName);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                    continue;
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                    continue;
                }
            }
            else if (inputArgs[0] == "Rating")
            {
                var teamName = inputArgs[1];
                try
                {
                    var team = teams.First(x => x.Name == teamName);
                    Console.WriteLine($"{team.Name} - {team.AverageRating()}");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                    continue;
                }
            }
        }
    }
}