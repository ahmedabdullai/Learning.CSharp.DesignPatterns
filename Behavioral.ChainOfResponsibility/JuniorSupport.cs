using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class JuniorSupport : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Simple Issue")
            {
                Console.WriteLine("Junior Support: I'll handle this simple issue.");
            }
            else
            {
                Console.WriteLine("Junior Support: This issue is too complex for me.");
                base.HandleRequest(request);
            }
        }
    }
}
