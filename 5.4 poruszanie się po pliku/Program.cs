using System.Text;
class Program

{
    static void Main(string[] args)
    {
        string filePath = "biodata.txt";
        string sequence = "Sekwencja kwasów nukleinowych: 5-AATTGGCC-3";

        File.WriteAllText(filePath, sequence);

        using (var fs = new FileStream(filePath, FileMode.Open))
        {
            fs.Seek(32, SeekOrigin.Begin);

            using (var sr = new StreamReader(fs, Encoding.UTF8))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }

        File.Delete(filePath);
        Console.Clear();
    }
}