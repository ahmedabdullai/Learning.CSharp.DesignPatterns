using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class User
    {
        private IChatRoomMediator _chatRoom;
        public string Name { get; private set; }

        public User(string name, IChatRoomMediator chatRoom)
        {
            Name = name;
            _chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            _chatRoom.SendMessage(message, this);
        }
    }
}
