using System;

namespace DesignPatterns.Structural.Facade
{
    public class HomeTheaterFacade
    {
        private readonly Projector _projector;
        private readonly SoundSystem _soundSystem;
        private readonly Lights _lights;

        public HomeTheaterFacade(
            Projector projector,
            SoundSystem soundSystem,
            Lights lights)
        {
            _projector = projector;
            _soundSystem = soundSystem;
            _lights = lights;
        }

        public void WatchMovie()
        {
            _lights.TurnOff();
            _projector.TurnOn();
            _soundSystem.TurnOn();

            Console.WriteLine("Movie Started 🎬");
        }

        public void EndMovie()
        {
            _soundSystem.TurnOff();
            _projector.TurnOff();
            _lights.TurnOn();

            Console.WriteLine("Movie Ended");
        }
    }
}
