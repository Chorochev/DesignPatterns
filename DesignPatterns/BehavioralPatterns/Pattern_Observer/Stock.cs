using System;
using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Pattern_Observer
{
    /// <summary>
    /// ConcreteObservable: конкретная реализация интерфейса IObservable. Определяет коллекцию объектов наблюдателей.
    /// </summary>
    class Stock : IObservable
    {
        StockInfo sInfo; // информация о торгах

        List<IObserver> observers;
        public Stock()
        {
            observers = new List<IObserver>();
            sInfo = new StockInfo();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(sInfo);
            }
        }

        public void Market()
        {
            Random rnd = new Random();
            sInfo.USD = rnd.Next(20, 40);
            sInfo.Euro = rnd.Next(30, 50);
            NotifyObservers();
        }
    }
}
