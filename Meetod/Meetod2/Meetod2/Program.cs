namespace Meetod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tervitus();
            string kasutajaNimi = "";
            kasutajaNimi = NimeKüsimine(kasutajaNimi);

            Console.WriteLine("Mis on sinu nädalane eelarve?");
            float eelarve = 0.00f;
            bool kaskasutajanõustub = false;
            kaskasutajanõustub = Eelarve(kasutajaNimi, eelarve, kaskasutajanõustub);

        }

        private static bool Eelarve(string kasutajaNimi, float eelarve, bool kaskasutajanõustub)
        {
            while (kaskasutajanõustub != true)
            {
                Console.WriteLine($"Praegune eelarve on {eelarve}, kas see on õige?");
                Console.WriteLine("Vasta kas jah või ei:");
                string mistaütles = Console.ReadLine();

                if (mistaütles == "jah")
                {
                    kaskasutajanõustub = true;
                }
            }
            Console.WriteLine($"{kasutajaNimi}sinu eelarve on:{SinuEelarvePäevas(eelarve)}");
            return kaskasutajanõustub;
        }

        private static string NimeKüsimine(string kasutajaNimi)
        {
            while (kasutajaNimi == "")
            {
                Tervitus();
                Console.WriteLine("Palun sisesta oma kasutajanimi");
                kasutajaNimi = Console.ReadLine();
            }

            return kasutajaNimi;
        }

        public static void Tervitus()
        {
            Console.WriteLine("'ommik");
        }
        //hallingux4 /janterx3
        public static int SinuEelarvePäevas(float eelarve)
        {
            double eelarvepäevas = eelarve / 7;
            return (int)eelarvepäevas;
        }

    }
}
