using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class PdfReport : ReportGenerator
    {
        public override void CollectData()
        {
            Console.WriteLine("Сбор данных для PDF отчета ...");
        }

        public override void FormatReport()
        {
            Console.WriteLine("Форматирование данных в PDF ...");
        }

        public override void SaveReport()
        {
            Console.WriteLine("Сохранение отчета в PDF формате.");
        }
    }
}
