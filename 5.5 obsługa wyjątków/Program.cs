class Program

{
    static void Main(string[] args)
    {
        int[,] array = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                array[i, j] = 1;
            }
        }

        string filePath = "dane.txt";

        using (var sw = new StreamWriter(filePath))
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sw.Write(array[i, j] + " ");
                }
                sw.WriteLine();
            }
        }

        try
        {
            var readFile = File.ReadAllLines(filePath);

            foreach (var line in readFile)
            {
                Console.WriteLine(line);
            }
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("Plik, który próbujesz otworzyć nie istnieje.");
        }
    }
}