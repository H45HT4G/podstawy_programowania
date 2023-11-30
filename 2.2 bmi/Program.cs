class Program

{
    static void Main(string[] args)
    {
        double weight, height, result;

        Console.WriteLine("Podaj swoją wagę i wzrost:\n Waga:");
        weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n Wzrost: ");
        height = Convert.ToDouble(Console.ReadLine());

        result = weight / ((height / 100) * (height / 100));
        Console.WriteLine($"Twój wskaźnik BMI wynosi: {result}");

        if (result < 18.5)
        {
            Console.WriteLine("Masz niedowagę!");
        } else if (result < 25)
        {
            Console.WriteLine("Jesteś normalnej wagi.");  
        } else if (result < 30) 
        {
            Console.WriteLine("Masz nadwagę!");
        } else 
        {
            Console.WriteLine("Jesteś otyły!");
        }
    }
}