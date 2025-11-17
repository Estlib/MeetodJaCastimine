internal class Program
{
    private static void Main(string[] args)
    {
        List<string> ostunimekiri = new List<string>();
        Console.WriteLine("Sisesta oma tänane poeskäigunimekiri");
        string kasutajasisestus = "";

        GetUserInput(kasutajasisestus, ostunimekiri);

        Console.WriteLine("See on sinu nimekiri:\n");
        foreach (var söök in ostunimekiri)
        {
            Console.WriteLine($" -*- {söök}");
        }

        GetUserInput(kasutajasisestus, ostunimekiri);
    }

    static List<string> GetUserInput(string kasutajasisestus, List<string> ostunimekiri)
    {
        while (kasutajasisestus == "")
        {
            Console.WriteLine("Palun järgmine ost nimekirja, kirjuta \"rohkem pole\" et lõpetada:");
            kasutajasisestus = Console.ReadLine();
            if (kasutajasisestus == "rohkem pole")
            {
                break;
            }
            ostunimekiri.Add(kasutajasisestus);
            kasutajasisestus = "";
        }
        return ostunimekiri;
    }

}