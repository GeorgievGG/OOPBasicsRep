﻿class Pokemon
{
    public Pokemon(string name, string element, double health)
    {
        this.Name = name;
        this.Element = element;
        this.Health = health;
    }

    private string name;
    private string element;
    private double health;

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

    public string Element
    {
        get
        {
            return this.element;
        }

        set
        {
            this.element = value;
        }
    }

    public double Health
    {
        get
        {
            return this.health;
        }

        set
        {
            this.health = value;
        }
    }
}