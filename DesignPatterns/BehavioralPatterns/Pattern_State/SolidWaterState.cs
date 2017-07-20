using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_State
{
    /// <summary>
    /// Конкретная реализации состояния.
    /// Твердое состояние воды (лед).
    /// </summary>
    class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в жидкость");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморозку льда");
        }
    }
}
