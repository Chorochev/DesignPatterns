using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_AbstractFactory
{
    /// <summary>
    /// Класс определяющий интерфейс для классов которые реализуют продукт "A".
    /// </summary>
    abstract class AbstractProductA
    {
        /// <summary>
        /// абстрактный метод - Номер продукта "A"
        /// </summary>
        /// <returns></returns>
        public abstract string GetNumberA();
        /// <summary>
        /// абстрактный метод - Масса продукта "A"
        /// </summary>
        /// <returns></returns>
        public abstract double GetWeightA();
    }
}
