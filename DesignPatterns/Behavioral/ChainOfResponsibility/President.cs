using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class President : Approver
    {
        public override void ProcessRequest(int amount)
        {
            if (amount < 20000)
            {
                Console.WriteLine($"{this.GetType().Name} approved request for {amount}.");
            }
            else
            {
                Console.WriteLine($"Request for {amount} requires a board meeting!");
            }
        }
    }
}
