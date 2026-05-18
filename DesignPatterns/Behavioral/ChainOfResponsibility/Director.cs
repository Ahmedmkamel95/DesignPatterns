using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Director : Approver
    {
        public override void ProcessRequest(int amount)
        {
            if (amount < 5000)
            {
                Console.WriteLine($"{this.GetType().Name} approved request for {amount}.");
            }
            else if (successor != null)
            {
                successor.ProcessRequest(amount);
            }
        }
    }
}
