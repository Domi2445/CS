using ConsoleAppVererbung;

internal class Program
{
    private static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");

        Hund meinhund = new Hund("Bello", "Dackel");
        //meinhund.Name = "Bello";

        meinhund.Essen();

        meinhund.Bellen();
    }
}