using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_AbstractFactory
{
    /// <summary>
    /// Конкретная реализация класса представляющего "Продукт B"
    /// </summary>
    class ProductB1 : AbstractProductB
    {
        /// <summary>
        /// конкретный метод - Номер продукта "B"
        /// </summary>
        /// <returns></returns>
        public override int GetNumberB()
        {
            return (int)111111;
        }
        /// <summary>
        /// конкретный метод - Размер продукта "B"
        /// </summary>
        /// <returns></returns>
        public override long GetSizeB()
        {
            return (long)100111111;
        }
        /// <summary>
        /// конкретный метод - Тип продукта "B"
        /// </summary>
        /// <returns></returns>
        public override string GetTypeB()
        {
            return "super test type B1";
        }
    }
}
