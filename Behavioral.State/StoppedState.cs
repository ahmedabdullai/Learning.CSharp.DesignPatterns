using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class StoppedState : IState
    {
        public void Play(MediaPlayer player)
        {
            Console.WriteLine("Starting the media.");
            player.SetState(new PlayingState());
        }

        public void Pause(MediaPlayer player)
        {
            Console.WriteLine("Cannot pause. The media is stopped.");
        }

        public void Stop(MediaPlayer player)
        {
            Console.WriteLine("Already stopped.");
        }
    }
}
