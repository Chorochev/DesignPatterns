using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_State
{
    public static class State_Main
    {
        public static void Go()
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
            water.Frost();
            water.Heat();
            water.Heat();
            water.Heat();

            Console.Read();
        }
    }
}
