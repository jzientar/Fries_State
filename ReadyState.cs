using System;

namespace Fries_State
{
    public class ReadyState : IDeepFrierState
    {
        public void operateMachine(Frier frierContext)
        {
            Console.WriteLine("The frier is ready to use.");
        }
    }
}