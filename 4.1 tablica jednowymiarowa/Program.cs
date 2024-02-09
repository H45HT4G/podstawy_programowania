class Program
{
    static void Main(string[] args)
    {
        int[] array1 = new int[10];

        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = i;
        }

        foreach (int i in array1) 
        {
            Console.WriteLine($"Indeks tablicy | Wartość tablicy\n       {array1[i]}       |         {i}");
        }
    }
}