using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_AbstractFactory
{
    /// <summary>
    /// Класс определяющий интерфейс для классов которые реализуют продукт "B".
    /// </summary>
    abstract class AbstractProductB
    {
        /// <summary>
        /// абстрактный метод - Номер продукта "B"
        /// </summary>
        /// <returns></returns>
        public abstract int GetNumberB();
        /// <summary>
        /// абстрактный метод - Размер продукта "B"
        /// </summary>
        /// <returns></returns>
        public abstract long GetSizeB();
        /// <summary>
        /// абстрактный метод - Тип продукта "B"
        /// </summary>
        /// <returns></returns>
        public abstract string GetTypeB();
    }
}
