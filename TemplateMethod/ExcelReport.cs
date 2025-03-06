using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class ExcelReport : ReportGenerator
    {
        public override void CollectData()
        {
            Console.WriteLine("Сбор данных для Excel отчета ...");
        }

        public override void FormatReport()
        {
            Console.WriteLine("Форматирование данных в Excel ...");
        }

        public override void SaveReport()
        {
            Console.WriteLine("Сохранение отчета в Excel формате.");
        }
    }
}
