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