internal class Program
{
    private static void Main(string[] args)
    {
        NewMessage();
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

    //static - staatiline selles klassis

    //private - meetod on saadaval ainult selles klassis
    //public - meetod on saadaval ükskõik millises klassis
    //protected - meetod on saadaval ainult selles klassis, või teistes klassides mis pärib selle klassi andmed
    //internal - on saadaval ainult iseenda sees.

    //signatuuri kompositsioon:
    //1. juurdepääsu modifikaator, 2. andme tagastustüüp, 3. meetodi nimi, 4. sulud, kus võivad olla parameetrid, 
    static                         void                   NewMessage       ()
    { //5. teostatav koodiplokk
        Console.WriteLine("NewMessage");
    }



}