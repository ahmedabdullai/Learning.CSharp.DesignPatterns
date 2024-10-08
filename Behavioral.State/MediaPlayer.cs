﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class MediaPlayer
    {
        private IState _state;

        public MediaPlayer()
        {
            _state = new StoppedState(); // Initial state
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void Play()
        {
            _state.Play(this);
        }

        public void Pause()
        {
            _state.Pause(this);
        }

        public void Stop()
        {
            _state.Stop(this);
        }
    }

}
