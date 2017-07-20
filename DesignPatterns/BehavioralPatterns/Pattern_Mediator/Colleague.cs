namespace DesignPatterns.BehavioralPatterns.Pattern_Mediator
{
    /// <summary>
    /// Colleague: представляет интерфейс для взаимодействия с объектом Mediator.
    /// </summary>
    abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }
        public abstract void Notify(string message);
    }
}
