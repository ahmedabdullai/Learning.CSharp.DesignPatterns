using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ChatRoom : IChatRoomMediator
    {
        public void SendMessage(string message, User user)
        {
            Console.WriteLine($"{user.Name}: {message}");
        }
    }
}
