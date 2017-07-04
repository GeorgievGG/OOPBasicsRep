using System;

public class Dribble : Stat
{
    public Dribble(int rating) : base(rating)
    {
        this.Rating = rating;
    }

    private int rating;

    public int Rating
    {
        get
        {
            return rating;
        }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Dribble should be between 0 and 100.");
            }
            rating = value;
        }
    }
}