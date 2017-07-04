using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    public Pizza(string name, int toppings)
    {
        this.Name = name;
        this.Dough = dough;
        this.NumberOfToppings = toppings;
        this.toppings = new List<Topping>();
    }

    private string name;
    private Dough dough;
    private List<Topping> toppings;
    private int numberOfToppings;

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (value.Length > 15 || string.IsNullOrWhiteSpace(value) || value == string.Empty)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            this.name = value;
        }
    }

    public Dough Dough
    {
        get
        {
            return this.dough;
        }

        set
        {
            this.dough = value;
        }
    }

    public IReadOnlyList<Topping> Toppings
    {
        get
        {
            return this.toppings.AsReadOnly();
        }
    }
    public int NumberOfToppings
    {
        get
        {
            return this.numberOfToppings;
        }

        set
        {
            if (value > 10 || value < 0)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.numberOfToppings = value;
        }
    }

    public double TotalCalories
    {
        get
        {
            return this.Toppings.Sum(x => x.Calories) + Dough.Calories;
        }
    }

    public void AddTopping(Topping topping)
    {
        this.toppings.Add(topping);
    }
}