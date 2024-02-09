class Program

{
    static void Main(string[] args)
    {
        int x, sum = 0, min;

        Console.WriteLine("Wybierz liczbę od 0 do 10.");
        x = Convert.ToInt32(Console.ReadLine());
        min = x;

        if (x >= 0 && x <= 10)
        {
            while (x != 5)
            {
                sum = sum + x;

                if (x < min)
                {
                    min = x;
                }

                Console.WriteLine("Wybierz liczbę od 0 do 10.");
                x = Convert.ToInt32(Console.ReadLine());
            }

            if (x == 5)
            {
                sum = sum + x;
                Console.WriteLine($"Suma kwadratu wynosi: {sum * sum}\nMinimalna wartość wynosi {min}");
            }
        }

        else
        {
            Console.WriteLine("Liczba jest poza zakresem od 1 do 10!!!");
        }
    }   
    
}