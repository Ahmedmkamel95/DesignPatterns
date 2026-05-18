using System;

namespace DesignPatterns.Behavioral.State
{
    public class StoppedState : IState
    {
        public void Play(MediaPlayer player)
        {
            Console.WriteLine("Starting the player.");
            player.SetState(new PlayingState());
        }

        public void Pause(MediaPlayer player)
        {
            Console.WriteLine("Can't pause. The player is stopped.");
        }

        public void Stop(MediaPlayer player)
        {
            Console.WriteLine("Already stopped.");
        }
    }
}
