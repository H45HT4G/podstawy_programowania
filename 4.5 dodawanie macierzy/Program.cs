class Program
{
    static void Main(string[] args)
    {
        int[,] a = new int[10, 10];
        int[,] b = new int[10, 10];
        int[,] c = new int[10, 10];

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = 1;

                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n         |\n       -----\n         |\n");

        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                b[i, j] = 2;

                Console.Write(b[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n       -----\n       -----\n");

        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
            {
                c[i, j] = a[i, j] + b[i, j];

                Console.Write(c[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}