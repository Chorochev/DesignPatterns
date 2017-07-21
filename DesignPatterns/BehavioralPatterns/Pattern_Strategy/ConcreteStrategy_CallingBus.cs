namespace DesignPatterns.BehavioralPatterns.Pattern_Strategy
{
    /// <summary>
    /// Класс который реализует интерфейс IStrategy, предоставляя свою версию 
    /// метода Algorithm(). Подобных классов-реализаций может быть множество.
    /// Конкретная реализация - стратегии вызова автобуса.
    /// </summary>
    class ConcreteStrategy_CallingBus : IStrategy
    {
        /// <summary>
        /// Создание стратегии вызова автобуса
        /// </summary>        
        public ConcreteStrategy_CallingBus() 
        {           
            this.Price = 1500.25d;
        }
        /// <summary>
        /// Конкретная реализация - стратегии вызова автобуса.
        /// </summary>
        public override void Algorithm()
        {
            System.Console.WriteLine("Стратегия вызова автобуса:");
            System.Console.WriteLine("1 - Нахождение свободного автобуса.");
            System.Console.WriteLine("2 - Вызов автобуса");
            System.Console.WriteLine("3 - Установка стоимости = {0}", Price);
            System.Console.WriteLine("4 - Посадка пассажиров");
            System.Console.WriteLine("5 - Отправка атобуса в рейс.");            
        }
    }
}
