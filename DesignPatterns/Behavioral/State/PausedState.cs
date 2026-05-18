using System;

namespace DesignPatterns.Behavioral.State
{
    public class PausedState : IState
    {
        public void Play(MediaPlayer player)
        {
            Console.WriteLine("Resuming the player.");
            player.SetState(new PlayingState());
        }

        public void Pause(MediaPlayer player)
        {
            Console.WriteLine("Already paused.");
        }

        public void Stop(MediaPlayer player)
        {
            Console.WriteLine("Stopping the player.");
            player.SetState(new StoppedState());
        }
    }
}
