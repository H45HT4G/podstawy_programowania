class Program
{
    static void Main(string[] args)
    {
        int start = Environment.TickCount;

        Random random = new Random();

        int totalPoints = 1000000;
        int pointsInsideCircle = 0;

        for (int i = 0; i < totalPoints; i++)
        {
            double x = random.NextDouble();
            double y = random.NextDouble();

            if (isInsideCircle(x, y))
            {
                pointsInsideCircle++;   
            }
        }

        double estimatedPi = 4.0 * pointsInsideCircle / totalPoints;

        int stop = Environment.TickCount;

        Console.WriteLine($"Szacowana wartość PI: {estimatedPi}\nCzas wykonania: {stop - start}ms");
    }

    static bool isInsideCircle(double x, double y)
    {
        return x * x + y * y <= 1.0;
    }
}