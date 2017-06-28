using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_AbstractFactory
{
    /// <summary>
    /// Конкретный класс который реализует абстрактный класс фабрики.
    /// </summary>
    class ConcreteFactory1 : AbstractFactory
    {
        /// <summary>
        /// Создание "Продукта A"
        /// </summary>
        /// <returns></returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        /// <summary>
        /// Создание "Продукта B"
        /// </summary>
        /// <returns></returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
