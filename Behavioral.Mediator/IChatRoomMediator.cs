﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IChatRoomMediator
    {
        void SendMessage(string message, User user);
    }
}
