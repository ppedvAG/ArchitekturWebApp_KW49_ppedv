using System;

namespace OpenClosePrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region BadCode
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }


    public class BadReportGenerator
    {
        /// <summary>
        /// Report type
        /// </summary>
        public string ReportType { get; set; } = string.Empty;

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(Employee em)
        {
            if (ReportType == "CR")
            {
                // Report generation with employee data in Crystal Report.
            }
            else if (ReportType == "PDF")
            {
                //Libary für PDF Export
                //Fülllogik us
                // Report generation with employee data in PDF.
            }
        }

        //private void CR_LoadTemplate(string Path);


        //private void PDF_Compress();
    }
    #endregion

    public interface IReportGenerateBase
    {
        void Generate(Employee em);
    }

    public class PDFGenerator : IReportGenerateBase
    {
        public void Generate(Employee em)
        {
            //Erstelle für Employee ein PDF
        }
    }


    public class CrystalReportGenerator : IReportGenerateBase
    {
        public void Generate(Employee em)
        {
            //Erstelle für Employee ein PDF
        }
    }



    #region weitere Variante
    public abstract class ReportGeneratorBase 
    {
        public abstract void Generate(Employee employee);

        //virtual Methoden hinzufügen
        public virtual string ReportInfo()
        {
            return "Basisklasse Report Generator";
        }
    }

    public class MyPDFGenerator : ReportGeneratorBase //erben von einer abstrakten Klasse
    {
        public override void Generate(Employee employee)
        {
            //Erstelle ein PDF
        }

        public override string ReportInfo()
        {
            return "Ich bin der PDF Reporter in der Version 1.2";
        }
    }

    public class MyCrystalReportGenerator : ReportGeneratorBase //erben von einer abstrakten Klasse
    {
        public override void Generate(Employee employee)
        {
            //Erstelle ein PDF
        }

        public override string ReportInfo()
        {
            return "Ich bin der Crystal Report Generator";
        }
    }


    #endregion
}
