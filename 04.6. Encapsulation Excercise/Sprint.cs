using System;

public class Sprint : Stat
{
    public Sprint(int rating) : base(rating)
    {
        this.Rating = rating;
    }

    private int rating;

    public int Rating
    {
        get
        {
            return this.rating;
        }

        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Sprint should be between 0 and 100.");
            }
            this.rating = value;
        }
    }
}