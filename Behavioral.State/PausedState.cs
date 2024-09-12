using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class PausedState : IState
    {
        public void Play(MediaPlayer player)
        {
            Console.WriteLine("Resuming the media.");
            player.SetState(new PlayingState());
        }

        public void Pause(MediaPlayer player)
        {
            Console.WriteLine("Already paused.");
        }

        public void Stop(MediaPlayer player)
        {
            Console.WriteLine("Stopping the media from paused state.");
            player.SetState(new StoppedState());
        }
    }
}
