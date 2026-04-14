using System;

namespace MyVessel
{
    class Program
    {
        static void Main()
        {
            VesselEngine TinyVessel = new VesselEngine();

            TinyVessel.Start();
            TinyVessel.TurnOff();
        }
    }
}