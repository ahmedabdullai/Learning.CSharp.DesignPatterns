using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ManagerSupport : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Very Complex Issue")
            {
                Console.WriteLine("Manager Support: I'll handle this very complex issue.");
            }
            else
            {
                Console.WriteLine("Manager Support: This issue is outside our support capabilities.");
                base.HandleRequest(request);
            }
        }
    }
}
