using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class WordReport : ReportGenerator
    {
        public override void CollectData()
        {
            Console.WriteLine("Сбор данных для Word отчета ...");
        }

        public override void FormatReport()
        {
            Console.WriteLine("Форматирование данных в Word ...");
        }

        public override void SaveReport()
        {
            Console.WriteLine("Сохранение отчета в Word формате.");
        }
    }
}
