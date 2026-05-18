using System;

namespace DesignPatterns.Behavioral.State
{
    public class PlayingState : IState
    {
        public void Play(MediaPlayer player)
        {
            Console.WriteLine("Already playing.");
        }

        public void Pause(MediaPlayer player)
        {
            Console.WriteLine("Pausing the player.");
            player.SetState(new PausedState());
        }

        public void Stop(MediaPlayer player)
        {
            Console.WriteLine("Stopping the player.");
            player.SetState(new StoppedState());
        }
    }
}
