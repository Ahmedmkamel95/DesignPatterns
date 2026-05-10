using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class CashPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Cash");
        }
    }
}
