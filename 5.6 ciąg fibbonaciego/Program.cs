class Program

{
    static void Main(string[] args)
    {
        int n = 10;
        int a = 0, b = 1, fib = 0;

        for (int i = 0; i < n; i++)
        {
            if (i <= 1)
            {
                fib = i;
            } else
            {
                fib = a + b;
                a = b;
                b = fib;
            }
            Console.WriteLine(fib);
        }
    }
}