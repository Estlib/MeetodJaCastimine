namespace Eelarve_arvutaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutajalt tema nime (tsüklis)
            string kasutajanimi = "";
            Console.WriteLine("Mis on teie nimi:");
            do
            {
                Console.WriteLine("Sinu nimi on: ");
                kasutajanimi = Console.ReadLine();
            } while (kasutajanimi == "");

            //küsi kasutajalt tema tulusid, niikaua kuni rohkem pole
            //siis küsi kasutajalt tema kulusid, ka niikaua kuni rohkem pole.
            //hoia andmeid List tüüpi muutujas, andmed ise peavad olema komakohaga.
            string kasutajasisestus = "";
            List<float> kasutajatulud = new List<float>();
            List<float> kasutajakulud = new List<float>();

            kasutajasisestus = KüsiSisendeid(kasutajasisestus, kasutajatulud, true);
            kasutajasisestus = "";
            kasutajasisestus = KüsiSisendeid(kasutajasisestus, kasutajakulud, false);
            //tee uus meetod, mis arvutab kokku järjendi sisu
            //hoia kogutulusid ja kogukulusid eraldi muutujates kasutades oma meetodit.
            float tuludkokku = Arvutus(kasutajatulud);
            float kuludkokku = Arvutus(kasutajakulud);
            //arvuta kasutajale tulude ja kulude põhjal tema hetkeseis.
            float kontojääk = tuludkokku - kuludkokku;
            //Ümarda kasutajale tagastatav arv kahe komakohani. Ja kuva nimeline sõnum
            Console.WriteLine($"{kasutajanimi}, sinu kontojääk on: {Math.Round(kontojääk,2)}");


            



          
            
            
            //while (kasutajasisestus != "rohkem pole")

            //{

            //    Console.WriteLine("Mis on teie väljaminekud? \n kui rohkem ei ole midagi lisada, siis kirjuta \"rohkem pole\"");
            //    kasutajasisestus = Console.ReadLine();
            //    if (kasutajasisestus != "rohkem pole")
            //    {
            //        kasutajakulud.Add(float.Parse(kasutajasisestus));
            //    }
            //}
        }

        public static float Arvutus(List<float> kokkuarvutatavkollektsioon)
        {
            float tulemus = 0.00f;
            foreach (var arv in kokkuarvutatavkollektsioon)
            {
                tulemus = tulemus + arv;
            }
            return tulemus;
        }

        private static string KüsiSisendeid(string kasutajasisestus, List<float> kasutajatulud, bool whichone)
        {
            while (kasutajasisestus != "rohkem pole")
            {
                if (whichone)
                {
                    Console.WriteLine("Mis on teie sissetulekud? \n kui rohkem ei ole midagi lisada, siis kirjuta \"rohkem pole\"");
                }
                else
                {
                    Console.WriteLine("Mis on teie väljaminekud? \n kui rohkem ei ole midagi lisada, siis kirjuta \"rohkem pole\"");
                }
                kasutajasisestus = Console.ReadLine();
                if (kasutajasisestus != "rohkem pole")
                {
                    kasutajatulud.Add(float.Parse(kasutajasisestus));
                }

            }
            return kasutajasisestus;
        }
    }
}
