using System;

namespace Fries_State
{
    class Program
    {
        static void Main(string[] args)
        {
            Frier frier = new Frier();
            frier.DeepFrier();
            Console.ReadKey();
        }
    }
}
