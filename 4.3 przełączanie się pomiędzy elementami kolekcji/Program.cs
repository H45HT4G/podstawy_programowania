class Program

{
    static void Main(string[] args)
    {
        int[] array = new int[100];
        int even = 0, odd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        foreach (int i in array)
        {
            if (i % 2 == 0)
            {
                even += i;
            } else if (i % 2 != 0)
            {
                odd += i;
            }
        }
        Console.WriteLine($"Sumy z przedziału 1 - 100:\nSuma liczb parzystych: {even}\nSuma liczb nieparzystych: {odd}");

    }
}