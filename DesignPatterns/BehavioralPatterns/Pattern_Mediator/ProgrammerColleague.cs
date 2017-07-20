using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_Mediator
{
    /// <summary>
    /// ConcreteColleague: конкретный класс коллеги, который обменивается другими 
    /// классами (наследовавших класс "Colleague") через объект Mediator.
    /// Класс программиста.
    /// </summary>
    class ProgrammerColleague : Colleague
    {
        public ProgrammerColleague(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение программисту: " + message);
        }
    }
}
