using System.Collections;

class Program

{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add("Gdańsk");
        arrayList.Add("Warszawa");
        arrayList.Add("Katowice");
        arrayList.Add("Poznań");
        arrayList.Add("Kraków");
        arrayList.Add("Rzeszów");

        arrayList.Sort();

        foreach (string i in arrayList) 
        {
            Console.WriteLine(i);
        }
    }
}