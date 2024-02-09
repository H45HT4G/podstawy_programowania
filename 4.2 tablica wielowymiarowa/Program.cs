class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[10, 10];
        int value = 0, sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    matrix[i, j] = value;
                    sum = sum + value;
                    value++;  
                }

                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nSuma elementów na przekątnej: {sum}");

    }
}