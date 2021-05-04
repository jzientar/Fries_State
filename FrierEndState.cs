using System;

namespace Fries_State
{
    public class FrierEndState : IDeepFrierState
    {
        public void operateMachine(Frier frierContext)
        {
            Console.WriteLine("{0}: the fries are ready", nameof(FrierEndState));
            frierContext.FrierState = new ReadyState();
            frierContext.FrierState.operateMachine(frierContext);
        }
    }
}