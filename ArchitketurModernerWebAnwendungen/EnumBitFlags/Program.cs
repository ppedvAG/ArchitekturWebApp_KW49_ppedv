using System;

namespace EnumBitFlags
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Fruechte fruchtkorb = Fruechte.Orange | Fruechte.Banane | Fruechte.Birne;

            bool IsOrangeImFruchtkorb = fruchtkorb.HasFlag(Fruechte.Orange);




            Fruechte[] myFruitArray = (Fruechte[])Enum.GetValues(typeof(Fruechte));


            //Gehe das komplette Array durch und prüfe, ob jeder Eintrag eventuell auch im Früchtekorb enthalten ist
            foreach (Fruechte currentFruit in myFruitArray)
            {
                if (fruchtkorb.HasFlag(currentFruit) && currentFruit != Fruechte.Keines)
                    Console.WriteLine(currentFruit);
            }

            ////A
            //for (int val = 0; val <= 32; val++)
            //    Console.WriteLine("{0,3} - {1:G}", val, (Fruechte)val);
        }
    }

    [Flags]
    enum Fruechte
    {
        Keines = 0,
        Orange = 1,
        Kirsche = 2,
        Banane = 4,
        Apfel = 8,
        Pflaume = 16,
        Birne = 32
    }
}
