using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SeniorSupport : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Complex Issue")
            {
                Console.WriteLine("Senior Support: I'll handle this complex issue.");
            }
            else
            {
                Console.WriteLine("Senior Support: This issue is too complex for me.");
                base.HandleRequest(request);
            }
        }
    }
}
