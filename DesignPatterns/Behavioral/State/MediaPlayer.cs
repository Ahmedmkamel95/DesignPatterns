using System;

namespace DesignPatterns.Behavioral.State
{
    public class MediaPlayer
    {
        private IState _state;

        public MediaPlayer()
        {
            // Initial state
            _state = new StoppedState();
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
