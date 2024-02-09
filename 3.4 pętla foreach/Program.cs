class Program
{
    static void Main(string[] args)
    {
        string[] pets = { "cat", "dog", "parrot", "guinea pig" };

        foreach (var pet in pets) 
        {
            Console.WriteLine(pet);

            if (pet == "dog")
            {
                Console.WriteLine("End\nDo You want to continue Y/N?");
                var answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    break;
                }
            }
        }
    }
}