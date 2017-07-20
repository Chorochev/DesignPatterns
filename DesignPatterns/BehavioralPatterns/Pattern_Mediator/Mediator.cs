namespace DesignPatterns.BehavioralPatterns.Pattern_Mediator
{
    /// <summary>
    /// Mediator: представляет интерфейс для взаимодействия с объектами Colleague.
    /// </summary>
    abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
}
