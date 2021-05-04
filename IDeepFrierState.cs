using System;

namespace Fries_State
{
    public interface IDeepFrierState
    {
        void operateMachine(Frier frierContext);
    }
}