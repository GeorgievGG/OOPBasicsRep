using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Trainer
{
    public Trainer(string name)
    {
        this.Name = name;
        this.Badges = 0;
        this.Pokemons = new List<Pokemon>();
    }

    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public int Badges
    {
        get
        {
            return this.badges;
        }

        set
        {
            this.badges = value;
        }
    }

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

    public List<Pokemon> Pokemons
    {
        get
        {
            return this.pokemons;
        }
        set
        {
            this.pokemons = value;
        }
    }
    public void AddPokemon(Pokemon pk)
    {
        pokemons.Add(pk);
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
    }
}