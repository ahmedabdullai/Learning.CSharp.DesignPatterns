using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    internal class TextFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Reading data from Text file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Processing data from Text file");
        }
    }
}
