namespace DesignPatterns.BehavioralPatterns.Pattern_State
{
    /// <summary>
    /// State: определяет интерфейс состояния
    /// </summary>
    interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
