using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Memento
{
    /// <summary>
    /// Memento: хранитель, который сохраняет состояние объекта Originator и предоставляет 
    /// полный доступ только этому объекту Originator.
    /// Хранитель игрового персонажа
    /// </summary>
    class HeroMemento
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }

        public HeroMemento(int patrons, int lives)
        {
            this.Patrons = patrons;
            this.Lives = lives;
        }
    }
}
