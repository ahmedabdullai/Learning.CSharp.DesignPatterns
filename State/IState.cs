using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IState
    {
        void Play(MediaPlayer player);
        void Pause(MediaPlayer player);
        void Stop(MediaPlayer player);
    }
}
