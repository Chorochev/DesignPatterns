using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_AbstractFactory
{
    /// <summary>
    /// Конкретная реализация класса представляющего "Продукт A"
    /// </summary>
    class ProductA1 : AbstractProductA
    {
        /// <summary>
        /// конкретный метод - Номер продукта "A"
        /// </summary>
        /// <returns></returns>
        public override string GetNumberA()
        {
            return "ART-111-TEST";
        }
        /// <summary>
        /// конкретный метод - Масса продукта "A"
        /// </summary>
        /// <returns></returns>
        public override double GetWeightA()
        {
            return (double)100.123456;
        }
    }
}
