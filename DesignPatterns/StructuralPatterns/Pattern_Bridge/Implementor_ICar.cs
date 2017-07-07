using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Bridge
{
    /// <summary>
    /// Базовый интерфейс для конкретных реализаций. Как правило, Implementor определяет только примитивные операции. 
    /// Более сложные операции, которые базируются на примитивных, определяются в Abstraction.
    /// В данном случае класс определяет машину.
    /// </summary>
    public abstract class Implementor_ICar
    {
        /// <summary>
        /// пункт отправления
        /// </summary>
        public string StartPath { get; set; }
        /// <summary>
        /// пункт назначения
        /// </summary>
        public string EndPath { get; set; }
        /// <summary>
        /// Вызов машины
        /// </summary>
        public abstract void Calling();
        /// <summary>
        /// Загрузка манины
        /// </summary>
        public abstract void Loading();
        /// <summary>
        /// Перемещение машины
        /// </summary>
        public void Transportation()
        {
            System.Console.WriteLine("Mашина выехала из пункта {0}.", StartPath);
            System.Console.WriteLine("Перемещение машины из пункта {0} в пункт {1}.", StartPath, EndPath);
            System.Console.WriteLine("Mашина приехала в пункт {0}.", EndPath);
        }
        /// <summary>
        /// Разгрузка автомобиля
        /// </summary>
        public abstract void Unloading();
    }
}
