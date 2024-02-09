class Program
{
    static void Main(string[] args)
    {
        double x = 0, y = 0;

        for (int i = 0; i <= 10; i++) 
        {
            y = Math.Sqrt(Math.Pow(3 , 2)) * x;
            Console.WriteLine(y);
            x++;
        }
    }
}