using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Handler : IHandler
    {
        private IHandler _nextHandler;

        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }

        public virtual void HandleRequest(string request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }

}
