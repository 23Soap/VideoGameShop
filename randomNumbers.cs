namespace VideoGameShop;

public class randomNumbers
{
    private Random random;

    public randomNumbers()
    {
        random = new Random();
    }

    public int GenerateNumber(int min, int max)
    {
        return random.Next(1000, 9999);
    }
}

