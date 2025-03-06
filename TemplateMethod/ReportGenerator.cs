using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            CollectData();
            FormatReport();
            SaveReport();
        }

        public abstract void CollectData();
        public abstract void FormatReport();
        public abstract void SaveReport();
    }
}
