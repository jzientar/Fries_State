using System;

namespace Fries_State
{
    public class FrierStartState : IDeepFrierState
    {
        public void operateMachine(Frier frierContext)
        {
            Console.WriteLine("{0}: starting to fry potatoes ", nameof(FrierStartState));
            frierContext.FrierState = new FryingState();
            frierContext.FrierState.operateMachine(frierContext);
        }
    }
}