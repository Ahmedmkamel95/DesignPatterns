namespace DesignPatterns.Behavioral.State
{
    public interface IState
    {
        void Play(MediaPlayer player);
        void Pause(MediaPlayer player);
        void Stop(MediaPlayer player);
    }
}
