public class Stat
{
    public Stat(int rating)
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
            this.rating = value;
        }
    }
}