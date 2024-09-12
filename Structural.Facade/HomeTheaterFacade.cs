using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        private Amplifier _amplifier;
        private CDPlayer _cdPlayer;
        private Projector _projector;
        private Screen _screen;
        private Lights _lights;

        public HomeTheaterFacade(Amplifier amplifier, CDPlayer cdPlayer, Projector projector, Screen screen, Lights lights)
        {
            _amplifier = amplifier;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _screen = screen;
            _lights = lights;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.SetInput("DVD");
            _amplifier.On();
            _amplifier.SetVolume(5);
            _cdPlayer.On();
            _cdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the movie theater...");
            _cdPlayer.Stop();
            _cdPlayer.Off();
            _amplifier.Off();
            _projector.Off();
            _screen.Up();
            _lights.On();
        }
    }
}
