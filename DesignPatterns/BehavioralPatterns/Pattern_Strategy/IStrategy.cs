using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Strategy
{
    /// <summary>
    /// Интерфейс IStrategy, который определяет метод Algorithm(). Это общий 
    /// интерфейс для всех реализующих его алгоритмов. Вместо интерфейса здесь 
    /// также можно было бы использовать абстрактный класс.
    /// Стратегия вызова машин
    /// </summary>
    abstract class IStrategy
    {
        /// <summary>
        /// Стоимость вызова
        /// </summary>
        public double Price { get; protected set; }
       
        /// <summary>
        /// Алгоритм который нужно переопределить
        /// </summary>
        public virtual void Algorithm() { }
    }
}
