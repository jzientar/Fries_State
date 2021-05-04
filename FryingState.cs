using System;

namespace Fries_State
{
    public class FryingState : IDeepFrierState
    {
        public void operateMachine(Frier frierContext)
        {
            Console.WriteLine("{0}: grilling the meat:", nameof(FryingState));
            frierContext.FrierState = new FrierEndState();
            frierContext.FrierState.operateMachine(frierContext);
        }
    }
}