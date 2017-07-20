using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_Observer
{
    /// <summary>
    /// IObserver: представляет наблюдателя, который подписывается на все уведомления 
    /// наблюдаемого объекта. Определяет метод Update(), который вызывается наблюдаемым 
    /// объектом для уведомления наблюдателя.
    /// </summary>
    interface IObserver
    {
        void Update(Object ob);
    }
}
