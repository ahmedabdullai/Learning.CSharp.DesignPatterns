using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class PlayingState : IState
    {
        public void Play(MediaPlayer player)
        {
            Console.WriteLine("Already playing.");
        }

        public void Pause(MediaPlayer player)
        {
            Console.WriteLine("Pausing the media.");
            player.SetState(new PausedState());
        }

        public void Stop(MediaPlayer player)
        {
            Console.WriteLine("Stopping the media.");
            player.SetState(new StoppedState());
        }
    }
}
