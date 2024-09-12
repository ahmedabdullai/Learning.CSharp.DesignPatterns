using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class DatabaseProxy : IDatabase
    {
        private Database _realDatabase;
        private bool _isConnected;

        public void Connect()
        {
            if (_realDatabase == null)
            {
                _realDatabase = new Database();
            }

            if (!_isConnected)
            {
                _realDatabase.Connect();
                _isConnected = true;
            }
        }

        public void ExecuteQuery(string query)
        {
            if (!_isConnected)
            {
                Connect();
            }

            _realDatabase.ExecuteQuery(query);
        }
    }

}
