using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Memento
{
    /// <summary>
    /// Caretaker: выполняет только функцию хранения объекта Memento, в то же время у него 
    /// нет полного доступа к хранителю и никаких других операций над хранителем, кроме 
    /// собственно сохранения, он не производит.
    /// Хранитель состояний игрового персонажа
    /// </summary>
    class GameHistory
    {
        /// <summary>
        /// Стек сосояний игрового персонажа
        /// </summary>
        public Stack<HeroMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }
}
