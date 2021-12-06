using System;

namespace SingleRespnsibilityPrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region Schlechtes Beispiel
    //Klasse EmployeeBad hat 3 Aufgaben
    //Wie sieht meine Datenstruktur aus?
    //Speichere Datenstruktur in Tabelle
    //Erstelle anhand der Datenstruktur ein Report (PDF oder andere Formate) 

    //Die Klasse erlebt mehrere Effekte:
    // - Sehr viele Codezeilen wird die Klasse beinhalten (bläht sich auf)
    // - Jede Methode muss genauer angeschaut werde (Redet die Methode mit der DB oder geht es um Reports) Multi Themen
    // - Wildwusch an Codezeilen -> bis zur unhandbarkeit = Software wird teuer 
    // - OOP geschrieben, aber Prozendual gedacht
    public class EmployeeBad
    {

        #region Datenstruktur
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        #endregion


        #region InsertIntoEmployeeTable - > Muss DataAccess - Layer
        public bool InsertIntoEmployeeTable(EmployeeBad em)
        {
            // Insert into employee table.
            return true;
        }
        #endregion

        #region Reports liegen als Library meist vor -> Generate Report (Präsentation - Layer) 
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(EmployeeBad em)
        {
            // Report generation with employee data using crystal report.
        }
        #endregion
    }
    #endregion



    #region Der Bessere Ansatz - Je Klasse hat eine Aufgabe
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class ReportGenerator
    {
        public void Generator()
        {
            //... // Wir erstellen eine PDF / CrystalReports / List10
        }
    }

    public class EmployeeRepository
    {
        public void Insert(Employee employee)
        {
            //Ein Employee Datensatz wird Richtung Tabelle gespeichert. 
        }

    }
    #endregion
}
