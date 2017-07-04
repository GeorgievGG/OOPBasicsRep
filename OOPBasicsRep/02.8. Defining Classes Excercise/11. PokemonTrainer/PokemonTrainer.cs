using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonTrainer
{
    public static void Main()
    {
        var trainers = new Dictionary<string, Trainer>();
        CatchPokemons(trainers);
        Compete(trainers);
        foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
        {
            Console.WriteLine(trainer.Value.ToString());
        }
    }
    private static void CatchPokemons(Dictionary<string, Trainer> trainers)
    {
        var input = string.Empty;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            var inputArgs = input.Split();
            var trName = inputArgs[0];
            var pkName = inputArgs[1];
            var pkElement = inputArgs[2];
            var pkHealth = double.Parse(inputArgs[3]);
            if (!trainers.ContainsKey(trName))
            {
                trainers.Add(trName, new Trainer(trName));
            }
            trainers[trName].AddPokemon(new Pokemon(pkName, pkElement, pkHealth));
        }
    }
    private static void Compete(Dictionary<string, Trainer> trainers)
    {
        var input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            var reqElement = input;
            foreach (var trainer in trainers)
            {
                if (trainer.Value.Pokemons.Where(x => x.Element == reqElement).Count() > 0)
                {
                    trainer.Value.Badges += 1;
                }
                else
                {
                    foreach (var pokemon in trainer.Value.Pokemons.ToArray())
                    {
                        pokemon.Health -= 10;
                        if (pokemon.Health <= 0)
                        {
                            trainer.Value.Pokemons.Remove(pokemon);
                        }
                    }
                }
            }
        }
    }
}