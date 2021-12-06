using System;

namespace LizkovPrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region BadCode
    public class BadKirsche
    {
        public string GetColour()
        {
            return "Rot";
        }
    }


    public class BadErdbeer : BadKirsche
    {
        public string GetFarbe()
        {
            return base.GetColour();
        }
    }
    #endregion

    #region Good Code
    public abstract class Fruits
    {
        public abstract string GetColour();
    }

    public class Erdbeer : Fruits
    {
        public override string GetColour()
        {
            return "Rot";
        }
    }

    public class Kirsche : Fruits
    {
        public override string GetColour()
        {
            return "Rot";
        }
    }
    #endregion
}
