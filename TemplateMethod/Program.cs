namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator pdfReport = new PdfReport();
            ReportGenerator wordReport = new WordReport();
            ReportGenerator excelReport = new ExcelReport();

            Console.WriteLine("Генерация PDF отчета:");
            pdfReport.GenerateReport();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Генерация Word отчета:");
            wordReport.GenerateReport();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Генерация Excel отчета:");
            excelReport.GenerateReport();
        }
    }
}
