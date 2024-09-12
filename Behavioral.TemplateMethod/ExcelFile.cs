using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    internal class ExcelFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Reading data from Excel file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Processing data from Excel file");
        }
    }
}
