namespace DesignPatterns.Creational.FactoryMethod
{
    public class BikeFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}
