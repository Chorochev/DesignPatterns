using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_State
{
    /// <summary>
    /// Конкретная реализации состояния.
    /// Газообразное состояние воды.
    /// </summary>
    class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Повышаем температуру водяного пара");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем водяной пар в жидкость");
            water.State = new LiquidWaterState();
        }
    }
}
