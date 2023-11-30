class Program

{
    static void Main(string[] args)
    {
        int age;

        Console.WriteLine("Podaj swój wiek: ");
        age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Access granted");

        }
        else if (age < 18 && age >= 15)
        {
            Console.WriteLine("Do you have parental constent? Y/N");
            string consent = Console.ReadLine().ToUpper();

            switch (consent)
            {
                case "Y":
                    Console.WriteLine("Access granted");
                    break;
                case "N":
                    Console.WriteLine("Access denied");
                    break;
                default:
                    Console.WriteLine("Wrong answer");
                    break;
            }
        }
        else if (age < 15)
        {
            Console.WriteLine("Access denied");
        }
    }
}