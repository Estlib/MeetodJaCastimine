
namespace Veehoidla_tase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programm mis küsib kasutajalt kasutajanime - tsükliga, meetodis


            string kasutajaNimi = GetUserName();

            //kui on vale kasutajanimi, programm lõppeb kasutajale teavitamisega

            if (kasutajaNimi != "apelsin69")
            {
                Console.WriteLine($"Kasutajanimi ei ole õige, {kasutajaNimi}.");
            }

            //kui on õige, küsi veetaseme hetkeseisu komakohalise arvuga - tsüklis

            else
            {
                float veeTase = 0.0F;
                while (veeTase == 0.0F)
                {
                    Console.WriteLine("Mis on veetase anduril?");
                    veeTase = float.Parse(Console.ReadLine());
                }
                //kutsu välja eraldi meetod, mille parameetriks on veetase, mis tagastab string-tüüpi andme
                Console.WriteLine(VeeTaseTuvastus(veeTase));
                
            }

         
        }
        public static string VeeTaseTuvastus(float vt)
        {
            //meetod kontrollib 3 vahemikku, ja tagastab teavituse põhinedes sellele kui kõrge vesi on
            // vahemik 1: 1-2m tase madal
            // vahemik 2: 2-3.5m tase normaalne
            // vahemik 3: 3.5-4.25m tase kõrge
            // kõik muu annab veateate anduri kohta.
            if (vt >= 1.00F && vt < 2.00F)
            {
                return "Veetase on madal, hoia veega kokku.";
            }
            else if (vt >= 2.00F && vt < 3.50F)
            {
                return "Veetase on normaalne, tarbimine stabiilne.";
            }
            else if (vt >= 3.50F && vt < 4.25F)
            {
                return "Veetase on liiga kõrge! Ava tammi luugid.";
            }
            else
            {
                return "ANDUR ON KATKI, KONTROLLI VEETASET MANUAALSELT,\n NING SAADA PARANDUSMEESKOND VÄLJA, POTENSIAALNE ÜLEUJUTUS";
            }
        }


        private static string GetUserName()
        {
            string hetkesisestus = "";
            while (hetkesisestus == "") 
            {
                Console.WriteLine("Mis sinu kasutajanimi?:");
                hetkesisestus = Console.ReadLine();
            }
            return hetkesisestus;
        }
    }
}
