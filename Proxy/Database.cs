using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Database : IDatabase
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to the database...");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing query: {query}");
        }
    }

}
