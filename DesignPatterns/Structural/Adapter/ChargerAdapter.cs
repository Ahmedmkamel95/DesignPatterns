// Adapter class in the Adapter pattern - adapts the adaptee to the target interface
// This class implements the target interface and delegates calls to the adaptee
namespace DesignPatterns.Structural.Adapter;

public class ChargerAdapter : IPhoneCharger
{
    private readonly TypeCCharger _typeCCharger;

    public ChargerAdapter(TypeCCharger typeCCharger)
    {
        _typeCCharger = typeCCharger;
    }

    public void ChargeWithIPhone()
    {
        _typeCCharger.ChargeWithTypeC();
    }
}