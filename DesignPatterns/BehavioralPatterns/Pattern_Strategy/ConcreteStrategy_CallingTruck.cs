namespace DesignPatterns.BehavioralPatterns.Pattern_Strategy
{
    /// <summary>
    /// Класс который реализует интерфейс IStrategy, предоставляя свою версию 
    /// метода Algorithm(). Подобных классов-реализаций может быть множество.
    /// Конкретная реализация - стратегии вызова грузовика.
    /// </summary>
    class ConcreteStrategy_CallingTruck : IStrategy
    {
        /// <summary>
        /// Создание стратегии вызова грузовика
        /// </summary>        
        public ConcreteStrategy_CallingTruck()
        {
            this.Price = 5240d;
        }
        /// <summary>
        /// Конкретная реализация - стратегии вызова грузовика.
        /// </summary>
        public override void Algorithm()
        {
            System.Console.WriteLine("Стратегия вызова такси:");            
            System.Console.WriteLine("1 - Установка стоимости = {0}", Price);
            System.Console.WriteLine("2 - Отправка грузовика к месту забора груза.");
            System.Console.WriteLine("3 - Погрузка.");
            System.Console.WriteLine("4 - Отправка грузовика к месту выгрузки груза.");
            System.Console.WriteLine("5 - Выгрузка.");
            System.Console.WriteLine("6 - Отправка грузовика на базу.");
        }
    }
}
