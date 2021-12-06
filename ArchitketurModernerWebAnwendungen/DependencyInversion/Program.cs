using System;

namespace DependencyInversion 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService service = new CarService(); 
            service.Repair(new CarDummyObject()); //Tag 4 und 5 zum Testen verwenden 
            service.Repair(new Car());

        }

        #region BadCode
        //Beispiel 1: BadCar.dll

        //Beispiel 2: Programmierer A: 5 Tage (Insgesamt Projektdauer 8 Tage) - Programmiere B muss warten bis Programmierer A fertig ist
        public class BadCar
        {
            public string Brand { get; set; }  
            public string Model { get; set; }
            public int Baujahr { get; set; }    
            
            //Erweiterungen 
        }

        //Beispiel 1: BadCarService.dll -> benötigt immer eine Referenz von BadCar.dll 


        //Beispiel 2: Programmierer B: 3 Tage

        public class BadCarService
        {
            public void Repair(BadCar badCar) //<- Hier wird BadCar als Parameter verwendet. 
            {
                //repariere Auto
            }
        }
        #endregion

        #region Guten Variante

        //Contract First mit Interfaces - 
        #region Interaces
        public interface ICar
        {
            string Brand { get; set; }
            string Model { get; set; }
            int Baujahr { get; set; }
        }

        public interface ICarService
        {
            void Repair(ICar car);  
        }
        #endregion

        #region Klassen-Implementierungen
        //Programmierer A benötigt immer noch 5 Tage
        public class Car : ICar
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Baujahr { get; set; }
        }

        //Programmierer B benötigt immer noch 3 Tage
        public class CarService : ICarService
        {
            public void Repair(ICar car)
            {
                
                //Repairiere Auto
            }
        }

        public class CarDummyObject : ICar
        {
            public string Brand { get; set; } = "VW";
            public string Model { get; set; } = "Polo";
            public int Baujahr { get; set; } = 2011;
        }
        #endregion



        #endregion
    }
}
