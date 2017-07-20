namespace DesignPatterns.BehavioralPatterns.Pattern_State
{
    /// <summary>
    /// Context: представляет объект, поведение которого должно динамически изменяться в 
    /// соответствии с состоянием. Выполнение же конкретных действий делегируется объекту состояния.
    /// Вода.
    /// </summary>
    class Water
    {
        public IWaterState State { get; set; }

        public Water(IWaterState ws)
        {
            State = ws;
        }

        public void Heat()
        {
            State.Heat(this);
        }
        public void Frost()
        {
            State.Frost(this);
        }
    }
}
