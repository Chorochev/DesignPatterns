namespace DesignPatterns.BehavioralPatterns.Pattern_Observer
{
    /// <summary>
    /// IObservable: представляет наблюдаемый объект. Определяет три метода: 
    /// - AddObserver() (для добавления наблюдателя), 
    /// - RemoveObserver() (удаление набюдателя) и 
    /// - NotifyObservers() (уведомление наблюдателей)
    /// </summary>
    interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
