namespace Castimine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double komakohagaarv = 9.55d;
            Console.WriteLine((int)komakohagaarv);
            int roundedarv = (int)Math.Round(komakohagaarv);
            Console.WriteLine(roundedarv);


            int arv = 35;
            string arvtekstina = arv.ToString();
            Console.WriteLine(arvtekstina);
            Console.WriteLine(arv);
            double arvdouble = 279346559d;
            int arvint = 0;
            arvint = (int)arvdouble;

            double uusdouble = arvint;

            //kirjuta programm mis küsib kasutajalt meetrites tema pikkust (komakohtadega)
            //teisenda kasutaja pikkus sentimeetriteks.
            //küsimine esialgu on tekstikujul (kasutaja sisestab teksti),
            //programm ise peab tekstist välja lugema komakohaga arvu.
            string pikkusm = "";
            Console.WriteLine("sisesta oma pikkus");
            pikkusm = Console.ReadLine();
            float pikkusFm = float.Parse(pikkusm);
            int pikkuscm = (int)pikkusFm;
            Console.WriteLine($"Sinu pikkus sentimeetrites on: {pikkuscm}");
        }
    }
}
