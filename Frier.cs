using System;

namespace Fries_State
{
    public class Frier
    {
        private IDeepFrierState _frierState;

        public Frier()
        {
            _frierState = new ReadyState();
        }
        public IDeepFrierState FrierState
        {
            get
            {
                return _frierState;
            }
            set
            {
                _frierState = value;
            }
        }
        public void DeepFrier()
        {
            Console.WriteLine("Frying fries process begins.");
            _frierState = new FrierStartState();
            _frierState.operateMachine(this);
        }
    }
}