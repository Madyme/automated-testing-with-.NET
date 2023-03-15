public class Bus : Vehicle
{
    private int numberOfSeats;
    public int NumberOfSeats
    {
        set
        {
            if (value < 36)
            {
                throw new InitializationException("Minimal Number of seats is 36", value);
            }
            else
            {
                numberOfSeats = value;
            }
        }
        get
        {
            return numberOfSeats;
        }
    }
}