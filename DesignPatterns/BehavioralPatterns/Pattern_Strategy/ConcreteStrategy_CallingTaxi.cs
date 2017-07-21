namespace DesignPatterns.BehavioralPatterns.Pattern_Strategy
{
    /// <summary>
    /// Класс который реализует интерфейс IStrategy, предоставляя свою версию 
    /// метода Algorithm(). Подобных классов-реализаций может быть множество.
    /// Конкретная реализация - стратегии вызова такси.
    /// </summary>
    class ConcreteStrategy_CallingTaxi : IStrategy
    {
        /// <summary>
        /// Создание стратегии вызова такси
        /// </summary>        
        public ConcreteStrategy_CallingTaxi()
        {
            this.Price = 1000d;
        }
        /// <summary>
        /// Конкретная реализация - стратегии вызова такси.
        /// </summary>
        public override void Algorithm()
        {
            System.Console.WriteLine("Стратегия вызова такси:");           
            System.Console.WriteLine("1 - Вызов такси");
            System.Console.WriteLine("2 - Установка стоимости = {0}", Price);
            System.Console.WriteLine("3 - Забор пассажиров из определенного места.");
            System.Console.WriteLine("4 - Отвезсти пассажиров в пункт назначения.");
        }
    }
}
