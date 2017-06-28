using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_AbstractFactory
{
    /// <summary>
    /// Абстрактный класс в котором определены абстрактные методы для создания продуктов "A" и "B"
    /// </summary>
    abstract class AbstractFactory
    {
        /// <summary>
        /// Создание продукта "A"
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProductA CreateProductA();
        /// <summary>
        /// Создание продукта "B"
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProductB CreateProductB();
    }
}
