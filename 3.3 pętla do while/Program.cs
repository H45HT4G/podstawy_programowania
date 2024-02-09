class Program
{
    static void Main()
    {
        int x = 1;

        do
        {
            Console.WriteLine($"Kwadrat liczby {x}: {x * x}");
            x++;

        } while (x <= 20);
    }
}